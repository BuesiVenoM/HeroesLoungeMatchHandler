using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesLoungeMatchHandler
{
    class Seasons
    {
        public string id { get; set; }
        public string title { get; set; }
        public string round_length { get; set; }
        public string slug { get; set; }
        public string current_round { get; set; }
        public string is_active { get; set; }
        public string created_at { get; set; }
        public string updated_at { get; set; }
        public string deleted_at { get; set; }
        public string reg_open { get; set; }
        public string mm_active { get; set; }
    }
}
