using Microsoft.AspNetCore.Mvc;

namespace Northwind.Controllers
{
    public class HomeController(DataContext db) : Controller
    {
        // this controller depends on the DataContext
        private readonly DataContext _dataContext = db;
        public ActionResult Index() => View(_dataContext.Discounts);
    }
}