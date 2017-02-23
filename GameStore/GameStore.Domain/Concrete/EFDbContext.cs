using GameStore.Domain.Entities;
using System.Data.Entity;

namespace GameStore.Domain.Concrete
{
    public class EFDbContext : DbContext
    {
        public EFDbContext() : base ("DefaultConnection")
        {

        }

        public DbSet<Game> Games { get; set; }
    }
}
