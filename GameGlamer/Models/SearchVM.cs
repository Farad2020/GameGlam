using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameGlamer.Models
{
    public class SearchVM
    {
        public IEnumerable<GameDeal> searchedGames { get; set; }
        public IEnumerable<DLCorLootDeal> searchedLoot { get; set; }
        public string search_str { get; set; }
    }
}
