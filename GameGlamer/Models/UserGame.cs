using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameGlamer.Models
{
    public class UserGame
    {
        public int id { get; set; }
        public String userId { get; set; }
        public long gameId { get; set; }

        public UserGame()
        {
        }

        public UserGame(string userId, long gameId)
        {
            this.userId = userId;
            this.gameId = gameId;
        }

        public UserGame(int id, string userId, long gameId)
        {
            this.id = id;
            this.userId = userId;
            this.gameId = gameId;
        }
    }
}
