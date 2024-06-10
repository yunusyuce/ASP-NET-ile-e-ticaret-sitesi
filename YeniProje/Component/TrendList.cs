using Microsoft.AspNetCore.Mvc;
using YeniProje.Data;

namespace YeniProje.Component
{
    public class TrendList:ViewComponent
    {
        private ApplicationDbContext _context;

        public TrendList(ApplicationDbContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke ()
        {
            var result =_context.Products.ToList();
            return View(result);
        }
    }
}
