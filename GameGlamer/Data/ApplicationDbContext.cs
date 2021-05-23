using GameGlamer.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameGlamer.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }


        public DbSet<GameDeal> GameDeals { get; set; }
        public DbSet<DLCorLootDeal> DLCorLootDeals { get; set; }
        public DbSet<UserGame> UserGames { get; set; }
        public DbSet<UserLoot> UserLoots { get; set; }
    }
}
// Login test@mail.ru Password: Test1234!