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

        public IEnumerable<Player> GetPlayers(string firstName, string lastName, int skip, int take)
        {
            Func<Player, bool> filter = (Player p) =>
            {
                var firstNameClause = firstName == null ? true : p.FirstName.Contains(firstName);
                var lastNameClause = lastName == null ? true : p.LastName.Contains(lastName);
                return firstNameClause && lastNameClause;
            };

            //dirty hack, only for demo purposes
            if (skip == -1 && take == -1)
            {
                return DummyDataStore.Teams
                    .SelectMany(p => p.Players)
                    .Where(filter);
            }

            return DummyDataStore.Teams
                .SelectMany(p => p.Players)
                .Where(filter)
                .Skip(skip)
                .Take(take);
        }
    }
}
