using Microsoft.AspNetCore.Mvc;

namespace LibraryManagement.Controllers
{
    public class StaffController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult StaffDashboard()
        {
            return View();
        }
        
    }
}
