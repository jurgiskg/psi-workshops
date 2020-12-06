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

        [HttpGet]
        public IEnumerable<Team> GetTeams()
        {
            return _teamRepo.GetTeams();
        }

        [HttpGet]
        [Route("{teamId}")]
        public IActionResult GetTeam(int teamId)
        {
            var team = _teamRepo.GetTeam(teamId);

            return team != null ? Ok(team) : NotFound();
        }
    }
}
