using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebServiceDemo.Entities;
using WebServiceDemo.Repositories;

namespace WebServiceDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TeamsController : Controller
    {
        private readonly ITeamRepository _teamRepo;

        public TeamsController(ITeamRepository teamRepo)
        {
            _teamRepo = teamRepo;
        }

        public IEnumerable<Team> GetTeams()
        {
            return _teamRepo.GetTeams();
        }

        [Route("{id}")]
        public IActionResult GetTeam(int id)
        {
            var team = _teamRepo.GetTeam(id);

            return team != null ? Ok(team) : NotFound();
        }
    }
}
