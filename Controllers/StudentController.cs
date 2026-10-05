using Microsoft.AspNetCore.Mvc;
using StudentManagement.Models;

namespace StudentManagement.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Info()
        {
            // Name dùng ViewBag
            ViewBag.Name = "Nguyễn Văn A";

            // Age dùng ViewData
            ViewData["Age"] = 20;

            // Major dùng Model
            Student student = new Student();
            student.Major = "CNTT";

            return View(student);
        }
    }
}