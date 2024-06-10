using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using YeniProje.Data;
using YeniProje.Models;

namespace YeniProje.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;


       

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Detay(int id)
        {
            var sorgu=_context.Products.Where(x=>x.ProductId == id).FirstOrDefault();
            return View(sorgu);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
