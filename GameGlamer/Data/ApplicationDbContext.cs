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


        public DbSet<GameDeal> Courses { get; set; }
        public DbSet<DLCorLootDeal> Enrollments { get; set; }
    }
}
// Login test@mail.ru Password: Test1234!