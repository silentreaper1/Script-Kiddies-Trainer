using System.IO;
using System.Net;

namespace Script_Kiddies_Trainer.CS
{
    class Httprequests
    {
        private string gamelistlink = "https://pastebin.com/raw/GTBSUGqJ";
        private string codeslink = "https://pastebin.com/raw/3XbKJRtv";

        public string getgamelist() { return webclient(gamelistlink); }

        public string gethacklist() { return webclient(codeslink); }

        private string webclient(string link)
        {
            WebClient web = new WebClient();
            Stream stream = web.OpenRead(link);
            using (StreamReader reader = new StreamReader(stream)) { return reader.ReadToEnd(); }
        }
    }
}
