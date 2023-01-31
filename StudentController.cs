using Microsoft.AspNetCore.Mvc;

namespace Tutorial_1_How_to_add_Controller_.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult StudentBio()
        {
            return View();
        }
    }
}
