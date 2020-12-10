using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using HotChocolate;
using HotChocolate.Data;
using WebServiceDemo.Entities;
using WebServiceDemo.Repositories;

namespace WebServiceDemo.GraphQL
{
    public class Query
    {
        [UseFiltering]
        public IEnumerable<Player> GetPlayers([Service] IPlayerRepository playerRepo) => playerRepo.GetPlayers(null, null); //for demo purposes only
        [UseFiltering]
        public IEnumerable<Team> GetTeams([Service] ITeamRepository teamRepo) => teamRepo.GetTeams();
    }
}