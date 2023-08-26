using Microsoft.EntityFrameworkCore;

namespace TPINTEGRADOR.Models.Sistema
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions<DBContext> options) : base(options)
        {

        }

        public DbSet<Equipo> Equipos { get; set; }
        public DbSet<Equipo> Vehiculos { get; set; }
        public DbSet<Equipo> Modelos { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
