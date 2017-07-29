using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HeroesLoungeMatchHandler
{
    public class Picture
    {
        public int id { get; set; }
        public string disk_name { get; set; }
        public string file_name { get; set; }
        public int file_size { get; set; }
        public string content_type { get; set; }
        public object title { get; set; }
        public object description { get; set; }
        public string field { get; set; }
        public int sort_order { get; set; }
        public string created_at { get; set; }
        public string updated_at { get; set; }
        public string path { get; set; }
        public string extension { get; set; }
    }
}
