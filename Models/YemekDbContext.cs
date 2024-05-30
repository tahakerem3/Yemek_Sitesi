using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Ahtapot_Recipe.Models;

public class YemekDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=.;Database=Ahtapot_Recipe;Trusted_Connection=True; TrustServerCertificate=true");
    }
    public DbSet<KullaniciModel> Kullanici { get; set; }
    public DbSet<TarifModel> Tarif { get; set; }
}