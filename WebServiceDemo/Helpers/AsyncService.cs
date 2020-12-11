using System;
using System.Threading;
using System.Threading.Tasks;

namespace WebServiceDemo.Helpers
{
    public class AsyncService
    {
        public async Task<string> GetCalculation1()
        {
            var result = DoHardCalculationAsync().Result;
            DoWorkNotDependantOnResult();

            return result;
        }

        public async Task<string> GetCalculation2()
        {
            var result = await DoHardCalculationAsync();
            DoWorkNotDependantOnResult();

            return result;
        }


        private async Task<string> DoHardCalculationAsync()
        {
            await Task.Delay(2000);
            return "A delicious sandwich";
        }

        private void DoWorkNotDependantOnResult()
        {
            Console.WriteLine("Off to make somea tea while result is fetched, brb");
        }
    }

}
