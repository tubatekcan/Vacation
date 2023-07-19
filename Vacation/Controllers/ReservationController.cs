using Microsoft.AspNetCore.Mvc;
using Vacation.Data;
using Vacation.Models;

namespace Vacation.Controllers
{
    public class ReservationController : Controller
    {
        VacationDBContext db;
        public ReservationController(VacationDBContext _db)
        {
            db = _db;
        }

        
        [Route("/Rezervasyon"),HttpGet]
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost,ValidateAntiForgeryToken]
        public IActionResult Index(Reservation model)
        {
            ViewBag.MenuIndex = 3;

            db.Reservation.Add(model);
            db.SaveChanges();
            TempData["Success"] = "Rezervasyonunuz başarıyla oluşturulmuştur. İyi bir tatil geçirmenizi dileriz.";
            return View();  
        }

    }
}
