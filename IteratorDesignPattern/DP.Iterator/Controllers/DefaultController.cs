using DP.Iterator.Iterator;
using Microsoft.AspNetCore.Mvc;

namespace DP.Iterator.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            VisitRouteMover visitRouteMover = new VisitRouteMover();
            List<string> strings = new List<string>();

            visitRouteMover.AddVisitRoute(new VisitRoute { CountryName = "Almanya", CityName = "Berlin", VistPlaceName = "Berlin Kapısı" });
            visitRouteMover.AddVisitRoute(new VisitRoute { CountryName = "Fransa", CityName = "Paris", VistPlaceName = "Eyfel Kulesi" });
            visitRouteMover.AddVisitRoute(new VisitRoute { CountryName = "İtalya", CityName = "Venedik", VistPlaceName = "Gondol" });
            visitRouteMover.AddVisitRoute(new VisitRoute { CountryName = "İtalya", CityName = "Roma", VistPlaceName = "Kolezyum" });
            visitRouteMover.AddVisitRoute(new VisitRoute { CountryName = "Çekya", CityName = "Prag", VistPlaceName = "Meydan" });

            var iterator = visitRouteMover.CreateIterator();

            while (iterator.NextLocation())
            {
                strings.Add(iterator.CurrentItem.CountryName + " - " + iterator.CurrentItem.CityName + " - " + iterator.CurrentItem.VistPlaceName);
            }
            ViewBag.v = strings;

            return View();
        }
    }
}
