using System.Net;
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

            int tagIndex = githubJson.IndexOf("\"tag_name\"");
            int quoteIndex = githubJson.IndexOf('"', tagIndex + "\"tag_name\"".Length + 1);
            int endQuoteIndex = githubJson.IndexOf('"', quoteIndex + 1);
            string tagName = githubJson.Substring(quoteIndex + 1, endQuoteIndex - quoteIndex - 1);

            return tagName;
        }
    }
}