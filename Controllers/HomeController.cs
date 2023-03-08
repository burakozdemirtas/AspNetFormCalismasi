using denemesql.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace denemesql.Controllers
{
    public class HomeController : Controller
    {
        private readonly MyDbContext _context;
        private readonly ILogger<HomeController> _logger;

        public object Session { get; private set; }

        public HomeController(MyDbContext context, ILogger<HomeController> logger)
        {
            _context = context;
            _logger = logger;

        }

        public IActionResult List()
        {
          var values = _context.Set<Kullanici>().ToList();
          return View(values);
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Kullanici kullanici, Fiyatlar fiyatlar)
        {
            var context = _context;
            

            int sayi = 0;
            if (kullanici.KatilimTuru1==1 )
            {
                sayi = fiyatlar.IeeeStudentMember;

            }
            else if(kullanici.KatilimTuru1 == 2)
            {
                sayi = 100;
            }
            else if (kullanici.KatilimTuru1 == 3)
            {
                sayi = 150;
            }
            else if (kullanici.KatilimTuru1 == 4)
            {
                sayi = 200;
            }
            kullanici.Toplam = sayi;
            context.Kullanici.Add(kullanici);
            context.SaveChanges();
            return View("Thanks");
        }



        public IActionResult Thanks()
        {

            return View();
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            return View();
        }
        [HttpPost]
        public IActionResult Update(Kullanici kullanici)
        {
           
            _context.Update(kullanici);
            _context.SaveChanges();
            return RedirectToAction("List");
        }
        public IActionResult Delete(int id)
        {
            var values = _context.Set<Kullanici>().Find(id);
            _context.Remove(values);
            _context.SaveChanges();
            return RedirectToAction("List");
        }
    }
}
