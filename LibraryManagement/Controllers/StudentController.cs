using LibraryManagement.Models;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagement.Controllers
{
    public class StudentController : Controller
    {
        private readonly DataDbContext context;

        public StudentController(DataDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult StudentDashboard()
        {
            return View();
        }
    }
}
