using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net;
using System.Windows.Forms;


namespace SportsApp.classes
{
    class sportsApi
    {
        const string APIKey = "######";
        string url = $"https://api.the-odds-api.com/v4/sports/?apiKey={APIKey}";

        public List<sportsApi.Root> getSports()
        {
            using (WebClient web = new WebClient())
            {
                try
                {
                    var json = web.DownloadString(url);
                    List<sportsApi.Root> info = JsonConvert.DeserializeObject<List<sportsApi.Root>>(json);
                    return info;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR: " + ex);
                    return null;
                }
            }
        }

        public class Root
        {
            public string key { get; set; }
            public string group { get; set; }
            public string title { get; set; }
            public string description { get; set; }
            public bool active { get; set; }
            public bool has_outrights { get; set; }

            internal void getSports()
            {
                throw new NotImplementedException();
            }
        }
    }
}
