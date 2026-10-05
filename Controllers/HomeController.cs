using Microsoft.AspNetCore.Mvc;

namespace StudentManagement.Controllers
{
    public class HomeController : Controller
    {
        // Trang chủ
        public IActionResult Index()
        {
            return Content("Welcome to ASP.NET MVC");
        }

        // Trang giới thiệu
        public IActionResult About()
        {
            return Content("Sinh viên: Nguyễn Huy Nhật Minh");
        }

        // Trang liên hệ
        public IActionResult Contact()
        {
            return Content("Email: bit240159@st.cmcu.edu.vn");
        }
    }
}