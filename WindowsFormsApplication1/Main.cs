using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;
using HeroesLoungeMatchHandler;
using HeroesLoungeMatchHandler.Properties;
using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Tables;
using MigraDoc.Rendering;
using Newtonsoft.Json.Serialization;
using PdfSharp.Pdf;
using Orientation = MigraDoc.DocumentObjectModel.Orientation;

/*
 * Programmed with love for HeroesLounge. By VenoM
 * */
namespace WindowsFormsApplication1
{
    public partial class Main : Form
    {
        private bool isSwitched = false;
        private int scoreLeft;
        private int scoreRight;
        private int matchId;
        private string teamLeft = "";
        private string teamRight = "";
        private string streamTitle = "";
        private string path = "";
        private string url = "";
        private int maxTeamNameLength = 0;
        private List<HeroesLoungeMatchHandler.Team> matchTeamsData;
        private Match matchData;
        private Division divData;
        private Seasons seasonData;

        public Main()
        {
            path = Settings.Default.Output;
            maxTeamNameLength = Settings.Default.MaxTeamTitleLength;
            InitializeComponent();
        }

        /// <summary>
        /// Writes the txt-files
        /// </summary>
        private void btn_initiate_data_Click(object sender, EventArgs e)
        {
            System.IO.Directory.CreateDirectory(path);
            get_meta_data(matchId);
            streamTitle = teamLeft + " vs. " + teamRight;
            write_sources();
        }

        private void write_sources() {
            System.IO.Directory.CreateDirectory(path);
            System.IO.File.WriteAllText(path + "teamLeft.txt", Convert.ToString(this.teamLeft));
            System.IO.File.WriteAllText(path + "teamRight.txt", Convert.ToString(this.teamRight));
            System.IO.File.WriteAllText(path + "streamTitle.txt", Convert.ToString(this.streamTitle));
            System.IO.File.WriteAllText(path + "scoreLeft.txt", Convert.ToString(this.scoreLeft));
            System.IO.File.WriteAllText(path + "scoreRight.txt", Convert.ToString(this.scoreRight));
            if (cB1_statsOnOff.Checked == true)
            {
                try
                {
                    webBrowser_div.Navigate(new Uri(url));
                    webBrowser_teamLeft.Navigate(new Uri("https://heroeslounge.gg/team/view/" + matchTeamsData[0].slug));
                    webBrowser_teamRight.Navigate(new Uri("https://heroeslounge.gg/team/view/" + matchTeamsData[1].slug));
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
            }
        }

        private void btn_writeSources_Click(object sender, EventArgs e)
        {
            write_sources();
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
        /// Setter-method for matchTeamsData
        /// </summary>
        /// <param name="scoreLeft">the left score</param>
        private void setMatchTeamsData(List<HeroesLoungeMatchHandler.Team> matchTeamsData)
        {
            this.matchTeamsData = matchTeamsData;
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
        /// Setter-method for right score
        /// </summary>
        /// <param name="scoreRight">the right score</param>
        private void setTeamRight(string teamRight)
        {
            this.teamRight = teamRight;
        }

        /// <summary>
        /// Setter-method for right score
        /// </summary>
        /// <param name="scoreRight">the right score</param>
        private void setTeamLeft(string teamLeft)
        {
            this.teamLeft = teamLeft;
        }

        /// <summary>
        /// Setter-method for isSwitched
        /// </summary>
        /// <param name="isSwitched">Value if every param is switched</param>
        private void setIsSwitched(bool isSwitched) {
            this.isSwitched = isSwitched;
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
             * spec team: https://heroeslounge.gg/api/v1/teams/1
             * team-pic: https://heroeslounge.gg/api/v1/teams/1/logo
             * */

            /* creating a Webclient for Web-downloads */
            WebClient wc = new WebClient();
            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;

            /* settings for the JSON-Serializer */
            var settings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                MissingMemberHandling = MissingMemberHandling.Ignore
            };

            /* creating the urls based on the given match-id */
            String matchurl = "https://heroeslounge.gg/api/v1/matches/" + matchId;
            String matchteamsurl = matchurl + "/teams";

            try
            {
                matchData = JsonConvert.DeserializeObject<HeroesLoungeMatchHandler.Match>(wc.DownloadString(matchurl), settings);
                var matchteamsdataraw = wc.DownloadString(matchteamsurl);
                List<HeroesLoungeMatchHandler.Team> matchTeamsData = JsonConvert.DeserializeObject<List<HeroesLoungeMatchHandler.Team>>(matchteamsdataraw, settings);
                setMatchTeamsData(matchTeamsData);

                /* setting the Teams*/
                teamLeft = matchTeamsData[0].title;
                teamRight = matchTeamsData[1].title;

                /* Check teamTitle-length and saving the Short-Version if its longer than in config */
                if (teamLeft.Length > maxTeamNameLength || teamRight.Length > maxTeamNameLength)
                {
                    teamLeft = matchTeamsData[0].slug;
                    teamRight = matchTeamsData[1].slug;
                }

                /* generate team-logos */
                String teamPicDefaultURL = "https://heroeslounge.gg/plugins/rikki/heroeslounge/assets/img/profile-icon.png";
                String urlTeamPicLeft = "https://heroeslounge.gg/api/v1/teams/" + matchTeamsData[0].id + "/logo";
                String urlTeamPicRight = "https://heroeslounge.gg/api/v1/teams/" + matchTeamsData[1].id + "/logo";

                /* download and convert team-logos */
                var teamPicLeft = JsonConvert.DeserializeObject<HeroesLoungeMatchHandler.Picture>(wc.DownloadString(urlTeamPicLeft), settings);
                var teamPicRight = JsonConvert.DeserializeObject<HeroesLoungeMatchHandler.Picture>(wc.DownloadString(urlTeamPicRight), settings);
                if (teamPicLeft != null)
                {
                    wc.DownloadFile(new Uri(teamPicLeft.path), path + @"teamLeft.png");
                }
                else
                {
                    wc.DownloadFile(new Uri(teamPicDefaultURL), path + @"teamLeft.png");
                }
                if (teamPicRight != null)
                {
                    wc.DownloadFile(new Uri(teamPicRight.path), path + @"teamRight.png");
                }
                else
                {
                    wc.DownloadFile(new Uri(teamPicDefaultURL), path + @"teamRight.png");
                }
                url = generateDivURLFromMatchID(matchData.div_id);
            }
            catch (Exception e)
            {
                MessageBox.Show("Match-ID is wrong or not typed... how should I assume which mach-ID you want to cast!?!");
            }

        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void btn_switch_Click(object sender, EventArgs e)
        {
            setIsSwitched(!isSwitched);
            // persist old data
            int scoreLeftold = this.scoreLeft;
            int scoreRightold = this.scoreRight;
            string teamLeftold = this.teamLeft;
            string teamRightold = this.teamRight;
            string lblTxtRightold = this.lbl_stat_teamRight.Text;
            string lblTxtLeftold = this.lbl_stat_teamLeft.Text;


            // switch data
            setScoreLeft(scoreRightold);
            setScoreRight(scoreLeftold);
            setTeamLeft(teamRightold);
            setTeamRight(teamLeftold);

            nud_leftScore.Value = scoreRightold;
            nud_rightScore.Value = scoreLeftold;

            lbl_stat_teamLeft.Text = lblTxtRightold;
            lbl_stat_teamRight.Text = lblTxtLeftold;
        }

        private string generateDivURLFromMatchID(int divID)
        {
            String divURL;
            /* creating a Webclient for Web-downloads */
            WebClient wc = new WebClient();
            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;

            /* settings for the JSON-Serializer */
            var settings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                MissingMemberHandling = MissingMemberHandling.Ignore
            };

            /* creating the urls based on the given match-id */
            String divurl = "https://heroeslounge.gg/api/v1/divisions/" + divID;
            divData = JsonConvert.DeserializeObject<HeroesLoungeMatchHandler.Division>(wc.DownloadString(divurl), settings);

            String seasonurl = "https://heroeslounge.gg/api/v1/seasons/" + divData.season_id;
            seasonData = JsonConvert.DeserializeObject<HeroesLoungeMatchHandler.Seasons>(wc.DownloadString(seasonurl), settings);

            divURL = "https://heroeslounge.gg/" + seasonData.slug + "/" + divData.slug;
            return divURL;
        }

        private void webBrowser_teamLeft_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            webBrowser_teamLeft.Document.Body.Style = "zoom:80%;";
        }

        private void webBrowser_div_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            webBrowser_div.Document.Body.Style = "zoom:80%;";
        }

        private void webBrowser_teamRight_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            webBrowser_teamRight.Document.Body.Style = "zoom:80%;";
        }

        private void btn_printCasterHelpSheet_Click(object sender, EventArgs e)
        {
            Document document = new Document();

            var section = document.AddSection();
            section.PageSetup.Orientation = Orientation.Landscape;
            section.AddParagraph(seasonData.slug + " / " + divData.slug + " / " + teamLeft + " VS. " + teamRight + " " + matchData.tbp);
            Table table = section.AddTable();
            table.Borders.Width = 0.25;
            table.Rows.LeftIndent = 0;

            Column column = table.AddColumn("2.5cm");
            Column column2 = table.AddColumn("3.5cm");
            Column column3 = table.AddColumn("1.5cm");
            Column column4 = table.AddColumn("4cm");
            Column column5 = table.AddColumn("2.5cm");
            Column column6 = table.AddColumn("3.5cm");
            Column column7 = table.AddColumn("1.5cm");
            Column column8 = table.AddColumn("4cm");
            column.Format.Alignment = ParagraphAlignment.Left;
            column2.Format.Alignment = ParagraphAlignment.Center;
            column3.Format.Alignment = ParagraphAlignment.Center;
            column4.Format.Alignment = ParagraphAlignment.Left;
            column5.Format.Alignment = ParagraphAlignment.Center;
            column6.Format.Alignment = ParagraphAlignment.Center;
            column7.Format.Alignment = ParagraphAlignment.Center;

            Row row = table.AddRow();
            row.Cells[0].AddParagraph("Team left:");
            row.Cells[1].AddParagraph(teamLeft);
            row.Cells[2].AddParagraph("");
            row.Cells[3].AddParagraph("");
            row.Cells[4].AddParagraph("Team right:");
            row.Cells[5].AddParagraph(teamRight);
            row.Cells[6].AddParagraph("");
            row.Cells[7].AddParagraph("");
            Row row2 = table.AddRow();
            row2.Cells[0].AddParagraph("Playername");
            row2.Cells[1].AddParagraph("Role");
            row2.Cells[2].AddParagraph("Plays");
            row2.Cells[3].AddParagraph("Notes");
            row2.Cells[4].AddParagraph("Playername");
            row2.Cells[5].AddParagraph("Role");
            row2.Cells[6].AddParagraph("Plays");
            row2.Cells[7].AddParagraph("Notes");
            Row row3 = table.AddRow();
            Row row4 = table.AddRow();
            Row row5 = table.AddRow();
            Row row6 = table.AddRow();
            Row row7 = table.AddRow();
            Row row8 = table.AddRow();
            Row row9 = table.AddRow();
            row3.Height = "1.5cm";
            row4.Height = "1.5cm";
            row5.Height = "1.5cm";
            row6.Height = "1.5cm";
            row7.Height = "1.5cm";
            row8.Height = "1.5cm";
            row9.Height = "1.5cm";


            var pdfRenderer = new PdfDocumentRenderer(false) { Document = document };

            pdfRenderer.RenderDocument();
            String pdfName = seasonData.slug + divData.slug + teamLeft + teamRight + matchData.tbp + ".pdf";
            String filename = pdfName.Replace(" ", string.Empty).Replace(":", string.Empty).Replace("/", string.Empty).Replace("-", string.Empty);
            pdfRenderer.PdfDocument.Save(filename);

            Process.Start(filename);
        }
    }
}
