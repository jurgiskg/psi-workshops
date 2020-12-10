using System;
using System.Collections;
using System.Collections.Generic;
using WebServiceDemo.Entities;

namespace WebServiceDemo.Repositories
{
    public interface IPlayerRepository
    {
        public IEnumerable<Player> GetPlayers(string firstName, string lastName);
        public Player GetPlayer(int playerId);
    }
}
