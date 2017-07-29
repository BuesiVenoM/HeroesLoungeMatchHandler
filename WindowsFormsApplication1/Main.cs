using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Net;
using System.Windows.Forms;

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
        private string teamLeft = "";
        private string teamRight = "";
        private string streamTitle = "";

        
        conf

        public Main()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Writes the txt-files
        /// </summary>
        private void btn_refresh_Click(object sender, EventArgs e)
        {
            return String.(ConfigurationSettings.AppSettings["Output"]);

            get_meta_data(matchId);
            streamTitle = teamLeft + " vs. " + teamRight;
            System.IO.File.WriteAllText("scoreLeft.txt", Convert.ToString(this.scoreLeft));
            System.IO.File.WriteAllText("scoreRight.txt", Convert.ToString(this.scoreRight));
            System.IO.File.WriteAllText("teamLeft.txt", Convert.ToString(this.teamLeft));
            System.IO.File.WriteAllText("teamRight.txt", Convert.ToString(this.teamRight));
            System.IO.File.WriteAllText("streamTitle.txt", Convert.ToString(this.streamTitle));
            
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

            string specteamdatal;
            string specteampicdata;

            WebClient wc = new WebClient();

            var settings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                MissingMemberHandling = MissingMemberHandling.Ignore
            };

            String matchurl = "https://heroeslounge.gg/api/v1/matches/" + matchId;
            String matchteamsurl = matchurl + "/teams";
            
            var matchdata = JsonConvert.DeserializeObject<HeroesLoungeMatchHandler.Match>(wc.DownloadString(matchurl), settings);
            var test = wc.DownloadString(matchteamsurl);
            var matchteamsdata = JsonConvert.DeserializeObject<List<HeroesLoungeMatchHandler.Team>>(test, settings);

            teamLeft = matchteamsdata[0].title;
            teamRight = matchteamsdata[1].title;

            String urlTeamPicLeft = "https://heroeslounge.gg/api/v1/teams/" + matchteamsdata[0].id + "/logo";
            String urlTeamPicRight = "https://heroeslounge.gg/api/v1/teams/" + matchteamsdata[1].id + "/logo";

            var teamPicLeft = JsonConvert.DeserializeObject<HeroesLoungeMatchHandler.Picture>(wc.DownloadString(urlTeamPicLeft), settings);
            var teamPicRight = JsonConvert.DeserializeObject<HeroesLoungeMatchHandler.Picture>(wc.DownloadString(urlTeamPicRight), settings);
            wc.DownloadFile(new Uri(teamPicLeft.path), @"C:/teamLeft.png");
            wc.DownloadFile(new Uri(teamPicRight.path), @"teamRight.png");
        }
    }
}
