using Microsoft.Extensions.DependencyInjection;
using System;
using System.Configuration;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations.Internal;

namespace OffersSite;

public class OffersContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Offer> Offers { get; set; }
        

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("DataSource=test.db");
    }
    
}