using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HeroesLoungeMatchHandler
{
    class Matchteams
    {
        public int id { get; set; }
        public DateTime wbp { get; set; }
        public int div_id { get; set; }
        public int round { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public int deleted_at { get; set; }
        public int channel_id { get; set; }
        public int is_played { get; set; }
        public int winner_id { get; set; }
        public DateTime tbp { get; set; }
        public DateTime schedule_date { get; set; }

        	{
		public int "id": 74,
		public string "title": "Dionysus",
		public string "short_description": "<p>Master players trying out some competative</p>",
		public string "slug": "Dio",
		public int "is_active": 1,
		public int "slothrating": 3220,
		public DateTime "created_at": "2017-06-18 14:49:57",
		public DateTime "updated_at": "2017-07-12 12:18:44",
		"deleted_at": null,
		"facebook_url": "",
		"twitch_url": "",
		"twitter_url": "",
		"youtube_url": "",
		"website_url": "",
		"accepting_apps": 0,
		"pivot": {
			public int "match_id": 1,
			public int "team_id": 74,
			public int "team_score": 2
		}
	},
	{
		"id": 107,
		"title": "-Insert Name-",
		"short_description": "",
		"slug": "IN",
		"is_active": 1,
		"slothrating": 3191,
		"created_at": "2017-06-22 23:16:22",
		"updated_at": "2017-07-11 23:32:14",
		"deleted_at": null,
		"facebook_url": "",
		"twitch_url": "",
		"twitter_url": "",
		"youtube_url": "",
		"website_url": "",
		"accepting_apps": 0,
		"pivot": {
			"match_id": 1,
			"team_id": 107,
			"team_score": 0
		}
	}
    }
}