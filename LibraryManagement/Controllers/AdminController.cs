using LibraryManagement.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagement.Controllers
{
    public class AdminController : Controller
    {
        private readonly DataDbContext context;

        public AdminController(DataDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult AdminDashboard()
        {
            return View();
        }   
        public IActionResult Admin()
        {
            return View();
        }

        public IActionResult AddPublication()
        {
            return View();
        }

        public IActionResult AddBook()
        {
            return View();
        }



        [HttpPost]
        public async Task<IActionResult> Index(User user)
        {
            var ab = await context.Users.FirstOrDefaultAsync(x => x.Username == user.Username && x.Password == user.Password && x.Role == user.Role);

            if (ab != null)
            {
                if (ab.Role == "Admin")
                {
                    // Redirect to the InspectionList page if it's inspector1
                    return RedirectToAction("AdminDashboard");
                }
                else if (ab.Role == "Librarian")
                {
                    // Redirect to CreateIns page for other registered users
                    return RedirectToAction("StaffDashboard", "Staff");
                }
                else
                {
                    // Redirect to the same login page if credentials are incorrect
                    return RedirectToAction("StudentDashboard", "Student");
                }
            }
            else
            {
                // Redirect to the same login page if credentials are incorrect
                return RedirectToAction("Index");
            }

        }
        
    }
}
