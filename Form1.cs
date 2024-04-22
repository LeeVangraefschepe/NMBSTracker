using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Security.Policy;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace NMBSTracker
{
    public partial class Form1 : Form
    {
        private int _lastDelay = -1;
        private string _default = "None";
        private bool _canceled = false;
        private Station _from = new Station();
        private Station _to = new Station();

        public Form1()
        {
            InitializeComponent();

            // Apply version text
            LblVersion.Text = $"V{Application.ProductVersion}";

            // Check version
            if (!VersionChecker.IsLatest())
            {
                DialogResult result = MessageBox.Show("Do you want to update now?", "Update available", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Process.Start("https://github.com/LeeVangraefschepe/NMBSTracker/releases");
                    Environment.Exit(0);
                    return;
                }
            }

            // Initialize stations
            WebClient client = new WebClient();
            string webStations = client.DownloadString("https://api.irail.be/stations/");

            XmlDocument document = new XmlDocument();
            document.LoadXml(webStations);

            List<string> stations = new List<string>();

            XmlNodeList xmlStations = document.GetElementsByTagName("station");
            foreach (XmlNode xmlStation in xmlStations)
            {
                stations.Add(xmlStation.InnerText);
            }
            stations.Sort();
            stations.Reverse();
            stations.Add(_default);
            stations.Reverse();

            // Initialize time
            List<string> minutes = new List<string>(60);
            for (int i = 0; i < 60; ++i)
            {
                minutes.Add(i.ToString("00"));
            }

            List<string> hours = new List<string>(24);
            for (int i = 0; i < 24; ++i)
            {
                hours.Add(i.ToString("00"));
            }

            // Initialize interval dropdown
            List<string> intervals = new List<string>
            {
                "1 minute",
                "3 minutes",
                "5 minutes"
            };

            // Apply to form elements
            FromStation.DataSource = stations.ToArray();
            ToStation.DataSource = stations.ToArray();
            DepartMinute.DataSource = minutes;
            DepartHour.DataSource = hours;
            Intervals.DataSource = intervals;

            LoadSettings();
        }

        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            RefreshAPI();
        }

        private void HandleDelay(int delay)
        {
            // Only notify when delay changed
            if (_lastDelay == delay) return;

            // Set default text
            DelayNotification.Text = GetDelayText(delay);

            // Adjust notification based on last & current delay
            if (_lastDelay == -1)
            {
                DelayNotification.BalloonTipTitle = "Update";
            }
            else if (_lastDelay < delay)
            {
                DelayNotification.BalloonTipTitle = "Delay increase";
            }
            else
            {
                DelayNotification.BalloonTipTitle = "Delay decrease";
                DelayNotification.Text += $" Was {_lastDelay} minute(s) before.";
            }

            // Push notification
            DelayNotification.Visible = true;
            DelayNotification.BalloonTipText = DelayNotification.Text;
            DelayNotification.ShowBalloonTip(100);

            // Update new delay
            _lastDelay = delay;
        }

        private void RefreshAPI(bool checkRange = true)
        {
            if (checkRange)
            {
                // Stop API calls if 3H or more from train department
                DateTime now = DateTime.Now;
                DateTime customDateTime = new DateTime(now.Year, now.Month, now.Day, Convert.ToInt32(DepartHour.Text), Convert.ToInt32(DepartMinute.Text), 0);

                if (Math.Abs((now - customDateTime).TotalHours) >= 3)
                {
                    return;
                }
            }

            // Call API
            int delay = RefreshAPITask();
            LblTrainFrom.Text = $"{_from.Name}\n";
            LblTrainFrom.Text += $"{_from.ArrivalTime.ToString("HH:mm")}";
            LblTrainTo.Text = $"{_to.Name}\n";
            LblTrainTo.Text += $"{_to.ArrivalTime.ToString("HH:mm")}";

            if (_canceled)
            {
                DelayNotification.Text = $"Your train is canceled. This message will keep appearing.";
                DelayNotification.Visible = true;
                DelayNotification.BalloonTipTitle = "Warning";
                DelayNotification.BalloonTipText = DelayNotification.Text;
                DelayNotification.ShowBalloonTip(100);
                return;
            }

            HandleDelay(delay);
        }

        private int RefreshAPITask()
        {
            if (FromStation.Text == _default || ToStation.Text == _default) return 0;

            XmlDocument document = new XmlDocument();
            try
            {
                WebClient client = new WebClient();
                string apiLink = $"https://api.irail.be/connections/?to={ToStation.Text}&from={FromStation.Text}&time={DepartHour.Text}{DepartMinute.Text}";
                string webRoutes = client.DownloadString(apiLink);
                document.LoadXml(webRoutes);
            }
            catch
            {
                DelayNotification.Text = $"Failed to fetch API. Will try again in a minute.";
                DelayNotification.Visible = true;
                DelayNotification.BalloonTipTitle = "Error";
                DelayNotification.BalloonTipText = DelayNotification.Text;
                DelayNotification.ShowBalloonTip(100);
                return 0;
            }

            XmlNodeList xmlConnections = document.GetElementsByTagName("connection");
            int intDelay = 0;
            foreach (XmlNode xmlConnection in xmlConnections)
            {
                XmlNode xmlDepart = xmlConnection.SelectSingleNode("departure");
                XmlNode xmlArrive = xmlConnection.SelectSingleNode("arrival");

                _canceled = xmlDepart.Attributes["canceled"].InnerText == "1";
                if (!_canceled) _canceled = xmlArrive.Attributes["canceled"].InnerText == "1";

                string delay = xmlDepart.Attributes["delay"].InnerText;
                int.TryParse(delay, out intDelay);
                intDelay /= 60;

                XmlNode stationNode = xmlDepart.SelectSingleNode("station");
                _from.Name = stationNode.InnerText;
                XmlNode timeNode = xmlDepart.SelectSingleNode("time");
                _from.ArrivalTime = DateTime.ParseExact(timeNode.Attributes["formatted"].Value, "yyyy-MM-ddTHH:mm:ss", null);

                stationNode = xmlArrive.SelectSingleNode("station");
                _to.Name = stationNode.InnerText;
                timeNode = xmlArrive.SelectSingleNode("time");
                _to.ArrivalTime = DateTime.ParseExact(timeNode.Attributes["formatted"].Value, "yyyy-MM-ddTHH:mm:ss", null);

                break;
            }

            return intDelay;
        }

        private string GetDelayText(int delay)
        {
            string delayText;
            if (delay == 0)
            {
                delayText = $"Your train has currently no delay.";
            }
            else if (delay == 1)
            {
                delayText = $"Your train has {delay} minute delay.";
            }
            else
            {
                delayText = $"Your train has {delay} minutes delay.";
            }
            return delayText;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            XmlDocument document = new XmlDocument();
            XmlElement root = document.CreateElement("Root");

            XmlElement element = document.CreateElement("FromStation");
            element.InnerText = FromStation.Text;
            root.AppendChild(element);

            element = document.CreateElement("ToStation");
            element.InnerText = ToStation.Text;
            root.AppendChild(element);

            element = document.CreateElement("DepartHour");
            element.InnerText = DepartHour.Text;
            root.AppendChild(element);

            element = document.CreateElement("DepartMinute");
            element.InnerText = DepartMinute.Text;
            root.AppendChild(element);

            element = document.CreateElement("Interval");
            element.InnerText = Intervals.Text;
            root.AppendChild(element);

            document.AppendChild(root);
            document.Save("settings.xml");
        }

        private void LoadSettings()
        {
            if (!File.Exists("settings.xml")) return;

            XmlDocument document = new XmlDocument();
            try
            {
                document.Load("settings.xml");
            }
            catch
            {
                MessageBox.Show("Failed to load settings file.", "NMBSTracker");
                return;
            }

            XmlNode root = document.DocumentElement;
            string fromStation = root.SelectSingleNode("FromStation")?.InnerText;
            string toStation = root.SelectSingleNode("ToStation")?.InnerText;
            string departHour = root.SelectSingleNode("DepartHour")?.InnerText;
            string departMinute = root.SelectSingleNode("DepartMinute")?.InnerText;
            string interval = root.SelectSingleNode("Interval")?.InnerText;

            if (fromStation != null) FromStation.SelectedItem = fromStation;
            if (toStation != null) ToStation.SelectedItem = toStation;
            if (departHour != null) DepartHour.SelectedItem = departHour;
            if (departMinute != null) DepartMinute.SelectedItem = departMinute;
            if (interval != null) Intervals.SelectedItem = interval;
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            UpdateTimer.Stop();
            _lastDelay = -1;
            RefreshAPI(false);
            UpdateTimer.Start();
        }

        private void Intervals_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strNumber = Intervals.Text.Replace(" minutes", "").Replace(" minute", "");
            if (int.TryParse(strNumber, out int output))
            {
                UpdateTimer.Interval = output * 60000;
            }
            else
            {
                MessageBox.Show("Failed to parse interval text");
            }
        }
    }
}