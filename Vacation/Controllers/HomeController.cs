using Microsoft.AspNetCore.Mvc;
using Vacation.Data;
using Vacation.Models;
using Vacation.ViewModel;

namespace Vacation.Controllers
{
    public class HomeController : Controller
    {

        VacationDBContext db;
        public HomeController(VacationDBContext _db)
        {
            db = _db;
        }



        [Route("/AnaSayfa")]
        public IActionResult Index()
        {

            ViewBag.MenuIndex = 0;
            return View(db.Slide.ToList());

        }

        //int y = DateTime.Now.Year > 2023 ? 1 : 0;


        [Route("/Hakkımızda")]
        public IActionResult AboutUs()
        {
            ViewBag.MenuIndex = 1;

            
            AboutVM aboutVM = new AboutVM
            {
                City = db.City,
                Deals = db.Deals,
                Best = db.Best
            };
            return View(aboutVM);
        }

        [Route("/İletişim")]
        public IActionResult Contact()
        {
            ViewBag.MenuIndex = 2;

            return View();
        }
        [Route("/Keşfet")]
        public IActionResult Deals()
        {
            ViewBag.MenuIndex = 4;

            return View();
        }
    }
}
