using System.Data.Entity;


namespace Deneme11.Models.Siniflar
{
    public class Context : DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<AnaSayfa> AnaSayfas { get; set; }
        public DbSet<İkonlar> İkonlars { get; set; }
    }
}