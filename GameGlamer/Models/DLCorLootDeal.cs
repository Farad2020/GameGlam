using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameGlamer.Models
{
    public class DLCorLootDeal
    {
        public int id { get; set; }

        [System.ComponentModel.DisplayName("Title")]
        public string title { get; set; }

        [System.ComponentModel.DisplayName("Worth")]
        public string worth { get; set; }
        public string thumbnail { get; set; }
        public string image { get; set; }

        [System.ComponentModel.DisplayName("Description")]
        public string description { get; set; }
        public string instructions { get; set; }

        [System.ComponentModel.DisplayName("Giveaway Source")]
        public string open_giveaway_url { get; set; }

        [System.ComponentModel.DisplayName("Published Date")]
        public string published_date { get; set; }

        [System.ComponentModel.DisplayName("Type")]
        public string type { get; set; }

        [System.ComponentModel.DisplayName("Platforms")]
        public string platforms { get; set; }

        [System.ComponentModel.DisplayName("End Date")]
        public string end_date { get; set; }

        [System.ComponentModel.DisplayName("Users")]
        public int users { get; set; }

        [System.ComponentModel.DisplayName("Status")]
        public string status { get; set; }
        public string gamerpower_url { get; set; }
        public string open_giveaway { get; set; }
    }
}
