using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HeroesLoungeMatchHandler
{
    public class Match
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
    }
}
