using Grpc.Core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using vonOeder.Data;
using vonOeder.Models;

namespace vonOeder.Controllers
{
    public class HomeController : Controller
    {
        private readonly vonOederContext _context;

        public HomeController(vonOederContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            //HttpContext.Session.SetString("mysession", "mySessionValue");
            //string sessionId = HttpContext.Session.Id;

            //_context.User.Add(new User
            //{
            //    UserId = sessionId,
            //    DT=DateTime.Now
            //});
            //await _context.SaveChangesAsync();
            return View();
        }
        public IActionResult Bio()
        {
            ViewBag.mælk = Reader(@"wwwroot/bio/mælkebøtte.txt");

            return View();
        }

        public IActionResult Andenken()
        {
            ViewBag.del1 = Reader(@"wwwroot/txt/andenken/del1.txt");
            ViewBag.del2 = Reader(@"wwwroot/txt/andenken/del2.txt");
            ViewBag.del3 = Reader(@"wwwroot/txt/andenken/del3.txt");
            ViewBag.del4 = Reader(@"wwwroot/txt/andenken/del4.txt");
            ViewBag.del5 = Reader(@"wwwroot/txt/andenken/del5.txt");
            ViewBag.del6 = Reader(@"wwwroot/txt/andenken/del6.txt");
            ViewBag.del7 = Reader(@"wwwroot/txt/andenken/del7.txt");
            ViewBag.del8 = Reader(@"wwwroot/txt/andenken/del8.txt");
            ViewBag.del9 = Reader(@"wwwroot/txt/andenken/del9.txt");
            ViewBag.del10 = Reader(@"wwwroot/txt/andenken/del10.txt");
            ViewBag.del11 = Reader(@"wwwroot/txt/andenken/del11.txt");
            ViewBag.del12 = Reader(@"wwwroot/txt/andenken/del12.txt");
            ViewBag.del13 = Reader(@"wwwroot/txt/andenken/del13.txt");
            ViewBag.halem = Reader(@"wwwroot/bio/halem.txt");
            ViewBag.jhe = Reader(@"wwwroot/bio/jhebernstorff.txt");

            return View();
        }
        public IActionResult etLiv()
        {
            ViewBag.del1 = Reader(@"wwwroot/txt/etLiv/del1.txt");
            ViewBag.del2 = Reader(@"wwwroot/txt/etLiv/del2.txt");
            ViewBag.del3 = Reader(@"wwwroot/txt/etLiv/del3.txt");
            ViewBag.del4 = Reader(@"wwwroot/txt/etLiv/del4.txt");
            ViewBag.del5 = Reader(@"wwwroot/txt/etLiv/del5.txt");
            ViewBag.del6 = Reader(@"wwwroot/txt/etLiv/del6.txt");
            ViewBag.wiede = Reader(@"wwwroot/bio/wiedewelt.txt");
            ViewBag.jhe = Reader(@"wwwroot/bio/jhebernstorff.txt");
            ViewBag.zu = Reader(@"wwwroot/bio/zuslag.txt");
            ViewBag.rat = Reader(@"wwwroot/bio/rathlou.txt");
            ViewBag.stru = Reader(@"wwwroot/bio/struensee.txt");
            ViewBag.fv = Reader(@"wwwroot/bio/fredrikv.txt");
            ViewBag.jm = Reader(@"wwwroot/bio/julianemarie.txt");
            ViewBag.apb = Reader(@"wwwroot/bio/apbernstorff.txt");
            ViewBag.halem = Reader(@"wwwroot/bio/halem.txt");
            ViewBag.wes = Reader(@"wwwroot/bio/wessel.txt");
            ViewBag.rev = Reader(@"wwwroot/bio/reventlow.txt");
            ViewBag.urt = Reader(@"wwwroot/bio/troldurt.txt");
            ViewBag.ludwig = Reader(@"wwwroot/bio/ludwig.txt");
            ViewBag.cm = Reader(@"wwwroot/bio/carolin.txt");
            ViewBag.be = Reader(@"wwwroot/bio/betænkning.txt");
            ViewBag.mul = Reader(@"wwwroot/bio/multebær.txt");
            ViewBag.mol = Reader(@"wwwroot/bio/moltke.txt");
            ViewBag.lod = Reader(@"wwwroot/bio/lodde.txt");
            return View();
        }
        public IActionResult Breve()
        {
            return View();
        }
        public IActionResult Linne_da()
        {
            ViewBag.lin_da = Reader(@"wwwroot/txt//breve/linda.txt");
            ViewBag.linne = Reader(@"wwwroot/bio/linne.txt");
            return View();
        }
        public IActionResult Bugge()
        {
            ViewBag.bioBugge  = Reader(@"wwwroot/bio/Bugge.txt");
            ViewBag.Bugge = Reader(@"wwwroot/txt/breve/bugge.txt");
            return View();
        }
        public IActionResult Ancestor()
        {
            return View();
        }
        public IActionResult Linne()
        {
            return View();
        }
        public IActionResult ukendt()
        {
            return View();
        }


        public IActionResult BrevCHE()
        {
            ViewBag.Files = Reader(@"wwwroot/txt/breve/CHE.txt");
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public List<string> Reader(string path)
        {
            var root = AppDomain.CurrentDomain.BaseDirectory;
            string line;
            System.IO.StreamReader file = new System.IO.StreamReader(root + path);
            var fileLines = new List<string>();
            while ((line = file.ReadLine()) != null)
            {
                fileLines.Add(line);
            }
            return fileLines;
        }
    }
}
