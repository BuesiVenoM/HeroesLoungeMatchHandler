using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HeroesLoungeMatchHandler
{
    public class Pivot
    {
        public int match_id { get; set; }
        public int team_id { get; set; }
        public int team_score { get; set; }
    }

    public class Team
    {
        public int id { get; set; }
        public string title { get; set; }
        public string short_description { get; set; }
        public string slug { get; set; }
        public int is_active { get; set; }
        public int slothrating { get; set; }
        public string created_at { get; set; }
        public string updated_at { get; set; }
        public object deleted_at { get; set; }
        public string facebook_url { get; set; }
        public string twitch_url { get; set; }
        public string twitter_url { get; set; }
        public string youtube_url { get; set; }
        public string website_url { get; set; }
        public int accepting_apps { get; set; }
        public Pivot pivot { get; set; }
    }
}