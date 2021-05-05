using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameGlamer.Models
{
    public class HomeMainVM
    {
        public IEnumerable<GameDeal> topGames { get; set; }
        public IEnumerable<DLCorLootDeal> top16Loot { get; set; }
        public IEnumerable<GameDeal> top16Games { get; set; }
    }
}
