using System.Collections.Generic;
using WebServiceDemo.Entities;

namespace WebServiceDemo.Repositories
{
    public interface ITeamRepository
    {
        public IEnumerable<Team> GetTeams();
    }
}
