using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace NMBSTracker
{
    public partial class Form1 : Form
    {
        private int _lastDelay = -1;
        private string _default = "None";
        public Form1()
        {
            InitializeComponent();

            // Apply version text
            LblVersion.Text = $"V{Application.ProductVersion}";

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
            if (_lastDelay != delay)
            {
                DelayNotification.Text = GetDelayText(delay);
                DelayNotification.Visible = true;
                DelayNotification.BalloonTipTitle = "Update";
                DelayNotification.BalloonTipText = DelayNotification.Text;
                DelayNotification.ShowBalloonTip(100);
            }
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

            // Call API async
            Task<int> refreshTask = RefreshAPITask();
            refreshTask.ContinueWith(task =>
            {
                int delay = task.Result;
                HandleDelay(delay);
            });
        }

        private Task<int> RefreshAPITask()
        {
            if (FromStation.Text == _default || ToStation.Text == _default) return Task.FromResult(0);

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
                return Task.FromResult(0);
            }

            XmlNodeList xmlRoutes = document.GetElementsByTagName("departure");
            int intDelay = 0;
            foreach (XmlNode xmlRoute in xmlRoutes)
            {
                string delay = xmlRoute.Attributes["delay"].InnerText;
                int.TryParse(delay, out intDelay);
                intDelay /= 60;
                break;
            }

            return Task.FromResult(intDelay);
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