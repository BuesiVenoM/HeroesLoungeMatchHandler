using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HeroesLoungeMatchHandler
{
    public class Match
    {
        public int id { get; set; }
        public String wbp { get; set; }
        public int div_id { get; set; }
        public int round { get; set; }
        public String created_at { get; set; }
        public String updated_at { get; set; }
        public int deleted_at { get; set; }
        public int channel_id { get; set; }
        public int is_played { get; set; }
        public int winner_id { get; set; }
        public String tbp { get; set; }
        public String schedule_date { get; set; }
    }
}
