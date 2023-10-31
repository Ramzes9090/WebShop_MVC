using Microsoft.AspNetCore.Mvc;
using WebShop.Data;

namespace WebShop.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var objCatergoryList = _db.Categories.ToList();
            return View(objCatergoryList);
        }
    }
}
