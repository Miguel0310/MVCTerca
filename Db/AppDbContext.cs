using System;
using Miguel.Models;
using Microsoft.EntityFrameworkCore;

namespace Miguel.Db
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
        }

        public DbSet<Client> Clients { get; set; }

    }
}