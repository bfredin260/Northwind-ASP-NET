using Microsoft.AspNetCore.Mvc;

namespace Northwind.Controllers
{
    public class HomeController(DataContext db) : Controller
    {
        // this controller depends on the DataContext
        private readonly DataContext _dataContext = db;
        public ActionResult Index() => View(_dataContext.Discounts.Where(d => d.StartTime <= DateTime.Now && d.EndTime > DateTime.Now).Take(3));
    }
}