using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Kamil
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=GABY-PC\\SQLEXPRESS;Database=KAMIL;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}