using GameStore.Domain.Entities;
using System.Data.Entity;

namespace GameStore.Domain.Concrete
{
    public class GameStoreDBContext : DbContext
    {
        public DbSet<Game> Games { get; set; }
    }
}
