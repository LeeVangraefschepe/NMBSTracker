using System.Net;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace NMBSTracker
{
    public class VersionChecker
    {
        private static string _githubUrl = "https://api.github.com/repos/LeeVangraefschepe/NMBSTracker/releases/latest";

        public static bool IsLatest()
        {
            string currentVersion = $"V{Application.ProductVersion}";
            return currentVersion == GetLatest();
        }

        private static string GetLatest()
        {
            WebClient client = new WebClient();
            client.Headers.Add("User-Agent", "C# HttpClient");
            string githubJson = client.DownloadString(_githubUrl);

            dynamic jsonObj = JsonConvert.DeserializeObject(githubJson);

            return jsonObj.tag_name;
        }
    }
}
