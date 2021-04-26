using GameGlam.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameGlam.Data
{
    public class GameGlamContext : DbContext
    {

        public GameGlamContext(DbContextOptions<GameGlamContext> options) : base(options)
        {
        }

        public DbSet<GameDeal> Courses { get; set; }
        public DbSet<DLCorLootDeal> Enrollments { get; set; }

    }
}
