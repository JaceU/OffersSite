using Microsoft.Extensions.DependencyInjection;
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations.Internal;

namespace OffersSite;

public class OffersContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Offer> Offers { get; set; }

    public OffersContext(DbContextOptions<OffersContext> options)
        : base(options)
    {
        
    }

    // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    // {
    //     optionsBuilder.UseSqlite("DataSource=/database/test.db");
    // }

}