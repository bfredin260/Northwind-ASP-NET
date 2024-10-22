using Microsoft.AspNetCore.Mvc;

public class CustomerController(DataContext db) : Controller
{
  // this controller depends on the DataContext
  private readonly DataContext _dataContext = db;

  public IActionResult Register() => View();
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Register(Customer customer)
    {
      if (ModelState.IsValid)
      {
        _dataContext.AddCustomer(customer);
        return RedirectToAction("Index", "Home");
      }
      return View();
    }
}