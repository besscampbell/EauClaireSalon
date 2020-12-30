using MicrosoftEntityFramworkCore;

namespace HairSalon.Models
{
  public class HairSalonContext : DbContext
  {
    public virtual DbSet<Stylist> Stylists { get; set; }
    public DbSet<Client> Clients { get; set; }
    public HairSalonContext(DbContextOptions options) : base(options) {}
    protected override void OnConfigureing(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}