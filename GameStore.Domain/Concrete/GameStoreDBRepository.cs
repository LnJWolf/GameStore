using System.Collections.Generic;
using GameStore.Domain.Entities;
using GameStore.Domain.Abstract;

namespace GameStore.Domain.Concrete
{
    public class GameStoreDBRepository : IGameRepository
    {
        GameStoreDBContext context = new GameStoreDBContext();

        public IEnumerable<Game> Games
        {
            get { return context.Games; }
        }
    }
}
