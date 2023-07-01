using Buoi03.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Buoi03.Controllers
{
    public class TestController : Controller
    {
        public IActionResult SyncDemo()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            var test = new Test();
            test.A();test.B(); test.C();

            stopwatch.Stop();

            return Content($"Chạy hết {stopwatch.ElapsedMilliseconds}ms");
        }

        public async Task<IActionResult> AsyncDemo()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            var test = new Test();
            var a = test.AA();
            var b = test.BB();
            var c = test.CC();
            await a; await b; await c;

            stopwatch.Stop();

            return Content($"Chạy hết {stopwatch.ElapsedMilliseconds}ms");
        }
    }
}
