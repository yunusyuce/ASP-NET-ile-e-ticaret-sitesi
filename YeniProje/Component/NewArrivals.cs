using Microsoft.AspNetCore.Mvc;
using YeniProje.Data;


namespace YeniProje.Component
{
    public class NewArrivals: ViewComponent
    {

        private ApplicationDbContext _context;

        public NewArrivals(ApplicationDbContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            var result = _context.Products.ToList();
            return View(result);
        }
    }
}
