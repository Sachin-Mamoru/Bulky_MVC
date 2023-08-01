using CW2.Data;
using CW2.Models;
using Microsoft.AspNetCore.Mvc;

namespace CW2.Controllers
{
    public class WorkoutController : Controller
    {
        private readonly ApplicationDbContext _db;
        public WorkoutController(ApplicationDbContext db)
        {
            _db= db;
        }
        public IActionResult Index()
        {
            List<Workout> objWorkputList = _db.Workouts.ToList();
            return View(objWorkputList);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Workout obj)
        {
            if (obj.WorkoutDuration > 50)
            {
                ModelState.AddModelError("WorkoutDuration", "The Workou tDuration cannot be more than 50 minutes.");
            }

            if (ModelState.IsValid)
            {
                _db.Workouts.Add(obj);
                _db.SaveChanges();
                TempData["success"] = "Workout created successfully";
                return RedirectToAction("Index");
            }
            return View();
            
        }

        public IActionResult Edit(int? id)
        {
            if(id==null || id == 0)
            {
                return NotFound();
            }
            Workout? workoutFromDb = _db.Workouts.Find(id);
            //Category? categoryFromDb1 = _db.Categories.FirstOrDefault(u=>u.Id==id);
            //Category? categoryFromDb2 = _db.Categories.Where(u=>u.Id==id).FirstOrDefault();

            if (workoutFromDb == null)
            {
                return NotFound();
            }
            return View(workoutFromDb);
        }
        [HttpPost]
        public IActionResult Edit(Workout obj)
        {
            if (ModelState.IsValid)
            {
                _db.Workouts.Update(obj);
                _db.SaveChanges();
                TempData["success"] = "Workout updated successfully";
                return RedirectToAction("Index");
            }
            return View();

        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Workout? categoryFromDb = _db.Workouts.Find(id);
          
            if (categoryFromDb == null)
            {
                return NotFound();
            }
            return View(categoryFromDb);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePOST(int? id)
        {
            Workout? obj = _db.Workouts.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            _db.Workouts.Remove(obj);
            _db.SaveChanges();
            TempData["success"] = "Workout deleted successfully";
            return RedirectToAction("Index");
        }
    }
}
