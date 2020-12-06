using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebServiceDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AsyncController : Controller
    {
        [HttpGet]
        [Route("await")]
        public async Task<int> TaskGet()
        {
            var res1 = await DoHardWork();
            var res2 = await DoHarderWork();

            return res1 + res2;
        }

        [HttpGet]
        [Route("result")]
        public int ThreadGet()
        {
            var res1Task = DoHardWork();
            var res1 = res1Task.Result;

            var res2Task = DoHardWork();
            var res2 = res2Task.Result;

            return res1 + res2;
        }

        private async Task<int> DoHardWork()
        {
            await Task.Delay(1000);
            return 21;
        }

        private async Task<int> DoHarderWork()
        {
            await Task.Delay(1001);
            return 21;
        }
    }
}
