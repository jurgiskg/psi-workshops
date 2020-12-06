using System.Collections.Generic;
using WebServiceDemo.Entities;
using WebServiceDemo.Helpers;

namespace WebServiceDemo.Repositories
{
    public class DummyTeamRepository : ITeamRepository
    {

        public IEnumerable<Team> GetTeams()
        {
            return DummyDataStore.Teams;
        }
    }
}
