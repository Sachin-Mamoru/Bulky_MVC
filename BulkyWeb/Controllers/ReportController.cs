using CW2.Data;
using CW2.Models;
using Microsoft.AspNetCore.Mvc;

namespace CW2.Controllers
{
    public class ReportController : Controller
    {
        private readonly ApplicationDbContext _db;
        public ReportController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Workout> objWorkputList = _db.Workouts.ToList();
            return View(objWorkputList);
        }
    }
}
