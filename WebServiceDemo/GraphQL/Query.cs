using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using HotChocolate;
using HotChocolate.Data;
using HotChocolate.Types;
using WebServiceDemo.Entities;
using WebServiceDemo.Repositories;

namespace WebServiceDemo.GraphQL
{
    public class Query
    {
        [UsePaging]
        [UseFiltering]
        public IEnumerable<Player> GetPlayers([Service] IPlayerRepository playerRepo) => playerRepo.GetPlayers(null, null, -1, -1); //for demo purposes only
        [UsePaging]
        [UseFiltering]
        public IEnumerable<Team> GetTeams([Service] ITeamRepository teamRepo) => teamRepo.GetTeams();
    }
}