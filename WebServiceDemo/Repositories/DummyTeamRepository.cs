using System.Collections.Generic;
using System.Linq;
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

        public Team GetTeam(int id)
        {
            var team = DummyDataStore.Teams.FirstOrDefault(t => t.TeamId == id);

            return team;
        }
    }
}
