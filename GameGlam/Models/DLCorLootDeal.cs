using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameGlam.Models
{
    public class DLCorLootDeal
    {
        public int id { get; set; }
        public string title { get; set; }
        public string worth { get; set; }
        public string thumbnail { get; set; }
        public string image { get; set; }
        public string description { get; set; }
        public string instructions { get; set; }
        public string open_giveaway_url { get; set; }
        public string published_date { get; set; }
        public string type { get; set; }
        public string platforms { get; set; }
        public string end_date { get; set; }
        public int users { get; set; }
        public string status { get; set; }
        public string gamerpower_url { get; set; }
        public string open_giveaway { get; set; }
    }
}
