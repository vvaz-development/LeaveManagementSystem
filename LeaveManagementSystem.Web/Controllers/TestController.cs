using LeaveManagementSystem.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace LeaveManagementSystem.Web.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            var data = new TestViewModel
            {
                Name = "Vincent Vaz",
                DateOfBirth = new DateTime(1971, 12, 29)
            };

            return View(data);
        }
    }
}
