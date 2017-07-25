using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json;

/*
 * Programmed with love for HeroesLounge. By VenoM
 * */
namespace WindowsFormsApplication1
{
    public partial class Main : Form
    {
        private int scoreLeft;
        private int scoreRight;
        private int matchId;

        public Main()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Writes the txt-files
        /// </summary>
        private void btn_refresh_Click(object sender, EventArgs e)
        {
            System.IO.File.WriteAllText("scoreLeft.txt", Convert.ToString(this.scoreLeft));
            System.IO.File.WriteAllText("scoreRight.txt", Convert.ToString(this.scoreRight));

            get_meta_data(matchId);
        }

        /// <summary>
        /// sets the score to 0. Text files aren't automatic generated.
        /// </summary>
        private void btn_setNull_Click(object sender, EventArgs e)
        {
            nud_leftScore.Value = 0;
            nud_rightScore.Value = 0;
        }

        /// <summary>
        /// Setter-method for left score
        /// </summary>
        /// <param name="scoreLeft">the left score</param>
        private void setScoreLeft(int scoreLeft) {
            this.scoreLeft = scoreLeft;
        }

        /// <summary>
        /// Setter-method for right score
        /// </summary>
        /// <param name="scoreRight">the right score</param>
        private void setScoreRight(int scoreRight)
        {
            this.scoreRight = scoreRight;
        }

        /// <summary>
        /// Setter-method for the match-id
        /// </summary>
        /// <param name="matchId">the match-ID</param>
        private void setMatchId(int matchId)
        {
            this.matchId = matchId;
        }

        private void nud_leftScore_ValueChanged(object sender, EventArgs e)
        {
             setScoreLeft(Convert.ToInt32(nud_leftScore.Value));
        }

        private void nud_rightScore_ValueChanged(object sender, EventArgs e)
        {
            setScoreRight(Convert.ToInt32(nud_rightScore.Value));
        }

        private void nud_matchId_ValueChanged(object sender, EventArgs e)
        {
            setMatchId(Convert.ToInt32(nud_matchId.Value));
        }

        private void get_meta_data(int matchId)
        {

            /*
             * paths: 
             * matches https://heroeslounge.gg/api/v1/matches
             * spec. m https://heroeslounge.gg/api/v1/matches/7
             * teams to match: https://heroeslounge.gg/api/v1/matches/7/teams
             * teams https://heroeslounge.gg/api/v1/teams/
             * spec team: https://heroeslounge.gg/api/v1/team/1
             * team-pic: https://heroeslounge.gg/api/v1/team/1/logo
             * */
            string matchdata;
            string matchteamsdata;
            string specteamdatal;
            string specteampicdata;

            WebClient wc = new WebClient();

            var settings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                MissingMemberHandling = MissingMemberHandling.Ignore
            };

            String matchurl = "https://heroeslounge.gg/api/v1/matches/" + matchId;
            matchdata = wc.DownloadString(matchurl);
            String matchteamsurl = matchurl + "/teams";
            String specteamurl = "https://heroeslounge.gg/api/v1/team/1";
            String specteampicurl = "https://heroeslounge.gg/api/v1/team/1/logo";
            
            
            
            
            matchteamsdata = wc.DownloadString(matchteamsurl);
            //specteamdatal = wc.DownloadString(specteamurl);
            //specteampicdata = wc.DownloadString(specteampicurl);


            

            //var match = JsonConvert.DeserializeObject<HeroesLoungeMatchHandler.Match>(data, settings);
            var match = JsonConvert.DeserializeObject(matchdata);
            var matchteams = JsonConvert.DeserializeObject(matchteamsdata);
            //var specteam = JsonConvert.DeserializeObject(specteamdatal);
            //var specteampic = JsonConvert.DeserializeObject(specteampicdata);
            
        }
    }
}
