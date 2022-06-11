using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SportsApp.classes;


namespace SportsApp
{
    public partial class amFoot : Form
    {

        private List<sportsApi.Root> americanFootball = new List<sportsApi.Root> { };
        private List<sportsMatches.Root> matches = new List<sportsMatches.Root> { };
        private List<sportsOdds.Root> odds = new List<sportsOdds.Root> { };
        private DataSet dataSet = new DataSet();

        private sportsOdds.Bookmaker bookmaker = new sportsOdds.Bookmaker();
        private sportsOdds.Market market = new sportsOdds.Market();
        private List<sportsOdds.Outcome> outcome = new List<sportsOdds.Outcome> { };

        private string team1;
        private string team2;
        private string matchid;
        private string sportKey;



        private void ClearAll()
        {
            comboBoxBookmaker.SelectedIndex = -1;
            comboBoxMarket.SelectedIndex = -1;
            txtTeam1.Clear();
            txtPrice1.Clear();
            txtPoint1.Clear();
            txtTeam2.Clear();
            txtPrice2.Clear();
            txtPoint2.Clear();
            panelOdds.Visible = false;
            dataSet.Tables.Clear();
            panelOdds.Visible = false;
            panelOutcomes.Visible = false;
            txtOver.Clear();
            txtUnder.Clear();
            comboBoxMarket.Items.Clear();
        }

        private void ClearOdds()
        {
            txtPrice1.Clear();
            txtPoint1.Clear();
            txtOver.Clear();
            txtPrice2.Clear();
            txtPoint2.Clear();
            txtUnder.Clear();
        }



        public amFoot()
        {
            InitializeComponent();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var DialogResult = MessageBox.Show("Are You Sure You Want to Exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.Yes)
            {
                this.Close();
                dashboard dashboard = new dashboard();
                dashboard.Show();
            }
        }


        //--------------------------------------------------------------------------------
        // Loads all american football leagues into list when American Football is clicked
        // and fills in the combobox with Leagues
        //--------------------------------------------------------------------------------
        private void amFoot_Load(object sender, EventArgs e)
        {
            dataGridMatches.Visible = false;
            panelOdds.Visible = false;
            panelOutcomes.Visible = false;




            sportsApi sports = new sportsApi();

            try
            {
                var info = sports.getSports();

                foreach (sportsApi.Root sport in info)
                {
                    if (sport.group == "American Football" && sport.title != "NFL Super Bowl Winner")
                    {
                        americanFootball.Add(sport);
                        comboBoxLeagues.Items.Add(sport.title);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex);
            }


        }

        //--------------------------------------------------------------------------------
        // dataGridMatches if filled with matches from chosen league in comboBox
        //--------------------------------------------------------------------------------

        private void comboBoxLeagues_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearAll();
            sportsMatches sportMatch = new sportsMatches();


            foreach (sportsApi.Root key in americanFootball)
            {
                if (key.title == comboBoxLeagues.Text)
                {
                    sportKey = key.key;
                }
            }

            matches = sportMatch.GetMatches(sportKey);
            try
            {

                DataTable dataTable = new DataTable();
                dataSet.Tables.Add(dataTable);

                dataTable.Columns.Add("Home Team");
                dataTable.Columns.Add("Away Team");
                dataTable.Columns.Add("Commence Time", typeof(DateTime));
                dataTable.Columns.Add("Match Id");


                foreach (sportsMatches.Root match in matches)
                {
                    if (match.sport_title == comboBoxLeagues.Text)
                    {
                        dataGridMatches.Visible = true;
                        DataRow dataRow = dataTable.Rows.Add();
                        dataRow.SetField("Home Team", match.home_team);
                        dataRow.SetField("Away Team", match.away_team);
                        dataRow.SetField("Commence Time", match.commence_time);
                        dataRow.SetField("Match Id", match.id);


                        dataGridMatches.DataSource = dataSet.Tables[0];


                    }
                    else
                    {
                        dataGridMatches.DataSource = null;
                    }
                }







            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex);
            }









        }

        private void dataGridMatches_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ClearAll();
            panelOdds.Visible = true;
            labelMarket.Visible = false;
            comboBoxMarket.Visible = false;

            this.HorizontalScroll.Maximum = 0;
            this.AutoScroll = false;
            this.VerticalScroll.Visible = false;
            this.AutoScroll = true;

            sportsOdds sportOdds = new sportsOdds();


            //--------------------------
            // Gets team names and Match Id
            //--------------------------
            if (dataGridMatches.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                int team1Col = 0;
                int team2Col = 1;
                int matchIdCol = 3;
                team1 = dataGridMatches.Rows[e.RowIndex].Cells[team1Col].Value.ToString();
                team2 = dataGridMatches.Rows[e.RowIndex].Cells[team2Col].Value.ToString();
                matchid = dataGridMatches.Rows[e.RowIndex].Cells[matchIdCol].Value.ToString();
            }





            try
            {

                //--------------------------
                // Gets odds
                //--------------------------
                odds = sportOdds.GetOdds(sportKey);




                foreach (sportsOdds.Root odd in odds)
                {
                    foreach (sportsOdds.Bookmaker bookmakers in odd.bookmakers)
                    {

                        if (comboBoxBookmaker.Items.Contains(bookmakers.title) != true)
                        {
                            comboBoxBookmaker.Items.Add(bookmakers.title);
                        }

                    }
                }






            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex);
            }


        }

        private void comboBoxBookmaker_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearOdds();
            comboBoxMarket.Items.Clear();
            comboBoxMarket.ResetText();

            labelMarket.Visible = true;
            comboBoxMarket.Visible = true;


            try
            {

                foreach (sportsOdds.Root odd in odds)
                {
                    foreach (sportsOdds.Bookmaker bookmakers in odd.bookmakers)
                    {
                        if (bookmakers.title == comboBoxBookmaker.Text && odd.id == matchid)
                        {
                            bookmaker = bookmakers;
                        }

                    }
                }

                foreach (sportsOdds.Market market in bookmaker.markets)
                {
                    if (comboBoxMarket.Items.Contains(market.key) != true)
                    {
                        comboBoxMarket.Items.Add(market.key);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex);
            }
        }

        private void comboBoxMarket_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearOdds();
            panelOutcomes.Visible = true;
            txtTeam1.Text = team1;
            txtTeam2.Text = team2;


            //--------------------------
            // Gets selected market & outcomes
            //--------------------------


            foreach (sportsOdds.Root odd in odds)
            {
                foreach (sportsOdds.Market markets in bookmaker.markets)
                {
                    if (comboBoxMarket.Text == markets.key && odd.id == matchid)
                    {
                        market = markets;
                    }
                }
            }



            outcome = market.outcomes;




            //--------------------------
            // Populates fields with odds
            //--------------------------
            foreach (sportsOdds.Root odd in odds)
            {
                if (matchid == odd.id)
                {
                    foreach (sportsOdds.Outcome results in outcome)
                    {
                        if (results.name == txtTeam1.Text || results.name == "Over")
                        {
                            if(results.name == "Over")
                            {
                                txtOver.Text = results.name;
                            }

                            txtPrice1.Text = results.price.ToString();
                            txtPoint1.Text = results.point.ToString();
                        }
                        else if (results.name == txtTeam2.Text || results.name  ==  "Under")
                        {
                            if(results.name == "Under")
                            {
                                txtUnder.Text = results.name;
                            }


                            txtPrice2.Text = results.price.ToString();
                            txtPoint2.Text = results.point.ToString();
                        }
                    }
                }

            }

          

        }


    }
}
