using System;
using System.IO;
using System.Net;
using SplatInk.Utilities;
using System.Diagnostics;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace SplatInk.UpdateSystem
{
    internal static class Updater
    {
        #region Update Information

        private const byte CURRENT_VERSION = 1;

        private const string LATEST_VERSION_ENDPOINT = 
            "https://pastebin.com/raw/QuK6vkJm";

        #endregion

        internal static async void CheckForUpdates()
        {
            byte latestVersion = 
                await GetLatestVersionNumberAsync();

            if (UpdateAvailable(latestVersion))
            {
                DialogResult dialogResult = 
                    MessageBoxes.ShowInformationConfirmation
                    ("Update Available!", "SplatInk v" 
                    + latestVersion + " is available! Would you like to download it?");

                switch (dialogResult)
                {
                    case DialogResult.Yes:
                        Process.
                            Start("https://github.com/Dan-Banfield/SplatInk");
                        break;
                }
            }
            else if (UpToDate(latestVersion))
                MessageBoxes.
                    ShowInformationMessage("Information", "Up to date!");
            else
                MessageBoxes.
                    ShowErrorMessage("Error!", "Failed to check for updates!");
        }

        internal static async Task<byte>GetLatestVersionNumberAsync()
        {
            WebResponse webResponse = await WebRequest.
                Create(LATEST_VERSION_ENDPOINT)
                .GetResponseAsync();

            byte result;

            using (StreamReader streamReader = new
                StreamReader(webResponse.GetResponseStream()))
            {
                result = Convert.
                    ToByte(await streamReader.ReadToEndAsync());
            }

            webResponse.Dispose();

            return result;
        }

        internal static bool UpdateAvailable(byte latestVersion)
        {
            return CURRENT_VERSION < latestVersion;
        }

        internal static bool UpToDate(byte latestVersion)
        {
            return CURRENT_VERSION == latestVersion;
        }
    }
}