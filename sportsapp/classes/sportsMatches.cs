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
    class sportsMatches
    {
        const string APIKey = "3c8ba40f35c547b0a67a7286aa7538e3";


        public List<sportsMatches.Root> GetMatches(string SPORT_KEY)
        {
            string url = $"https://api.the-odds-api.com/v4/sports/{SPORT_KEY}/scores/?daysFrom=1&apiKey={APIKey}";
            using (WebClient web = new WebClient())
            {
                try
                {
                    var json = web.DownloadString(url);
                    List<sportsMatches.Root> info = JsonConvert.DeserializeObject<List<sportsMatches.Root>>(json);
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
            public string id { get; set; }
            public string sport_key { get; set; }
            public string sport_title { get; set; }
            public DateTime commence_time { get; set; }
            public bool completed { get; set; }
            public string home_team { get; set; }
            public string away_team { get; set; }
            public object scores { get; set; }
            public object last_update { get; set; }
        }



    }
}
