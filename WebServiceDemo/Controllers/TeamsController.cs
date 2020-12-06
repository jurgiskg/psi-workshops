using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebServiceDemo.Entities;
using WebServiceDemo.Repositories;

namespace WebServiceDemo.Controllers
{
    [Route("[controller]")]
    public class TeamsController : Controller
    {
        private readonly ITeamRepository _teamRepo;

        public TeamsController(ITeamRepository teamRepo)
        {
            _teamRepo = teamRepo;
        }

        [HttpGet]
        public IEnumerable<Team> GetTeams()
        {
            return _teamRepo.GetTeams();
        }
    }
}
