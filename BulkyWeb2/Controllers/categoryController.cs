using BulkyWeb2.Data;
using Microsoft.AspNetCore.Mvc;

namespace BulkyWeb2.Controllers
{
    public class categoryController : Controller
    {
        private readonly ApplicationDbContext _db;
        public categoryController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
