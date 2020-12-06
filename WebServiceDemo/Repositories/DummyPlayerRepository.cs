using System;
using System.Collections.Generic;
using System.Linq;
using WebServiceDemo.Entities;
using WebServiceDemo.Helpers;

namespace WebServiceDemo.Repositories
{
    public class DummyPlayerRepository : IPlayerRepository
    {
        public Player GetPlayer(int playerId)
        {
            var player = DummyDataStore.Teams
                .SelectMany(t => t.Players)
                .FirstOrDefault(p => p.PersonId == playerId);

            return player;
        }

        public IEnumerable<Player> GetPlayers()
        {
            return DummyDataStore.Teams.SelectMany(p => p.Players);
        }
    }
}
