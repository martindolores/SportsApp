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
    class sportsOdds
    {
        const string APIKey = "3c8ba40f35c547b0a67a7286aa7538e3";
        

        public List<sportsOdds.Root> GetOdds(string SPORT_KEY)
        {
            string url = $"https://api.the-odds-api.com/v4/sports/{SPORT_KEY}/odds/?apiKey={APIKey}&regions=au&markets=h2h,spreads,totals";
            using (WebClient web = new WebClient())
            {
                try
                {
                    var json = web.DownloadString(url);
                    List<sportsOdds.Root> info = JsonConvert.DeserializeObject<List<sportsOdds.Root>>(json);
                    return info;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR: " + ex);
                    return null;
                }
            }
        }

        public class Bookmaker
        {
            public string key { get; set; }
            public string title { get; set; }
            public DateTime last_update { get; set; }
            public List<Market> markets { get; set; }
        }

        public class Market
        {
            public string key { get; set; }
            public List<Outcome> outcomes { get; set; }
        }

        public class Outcome
        {
            public string name { get; set; }
            public double price { get; set; }
            public double? point { get; set; }
        }

        public class Root
        {
            public string id { get; set; }
            public string sport_key { get; set; }
            public string sport_title { get; set; }
            public DateTime commence_time { get; set; }
            public string home_team { get; set; }
            public string away_team { get; set; }
            public List<Bookmaker> bookmakers { get; set; }
        }
    }
}
