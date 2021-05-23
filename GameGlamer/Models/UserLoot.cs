using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameGlamer.Models
{
    public class UserLoot
    {
        public int id { get; set; }
        public String userId { get; set; }
        public long gameId { get; set; }

        UserLoot() { 
        }

        public UserLoot(string userId, long gameId)
        {
            this.userId = userId;
            this.gameId = gameId;
        }

        public UserLoot(int id, string userId, long gameId)
        {
            this.id = id;
            this.userId = userId;
            this.gameId = gameId;
        }
    }
}
