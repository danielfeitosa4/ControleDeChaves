using ControleDeChaves.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ControleDeChaves.Infrastructure.Persistence
{
    public class ControleDeChavesDbContext : DbContext
    {
        public ControleDeChavesDbContext(DbContextOptions<ControleDeChavesDbContext> options) : base(options)
        {
        }

        public DbSet<Key> Keys { get; set; }
        public DbSet<Movement> Movements { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Sector> Sectors { get; set; }
    }
}
