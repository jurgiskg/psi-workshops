using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using HotChocolate;
using WebServiceDemo.Entities;
using WebServiceDemo.Repositories;

namespace WebServiceDemo.GraphQL
{
    public class Query
    {
        public IEnumerable<Player> GetPlayers([Service] IPlayerRepository playerRepo) => playerRepo.GetPlayers();
    }
}
