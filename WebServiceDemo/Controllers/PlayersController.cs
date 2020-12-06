using Microsoft.AspNetCore.Mvc;
using WebServiceDemo.Entities;

namespace WebServiceDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PlayersController : Controller
    {
        [Route("{id}")]
        public Player GetPlayer()
        {
            return new Player { FirstName = "Vaclovas" };
        }
    }
}
