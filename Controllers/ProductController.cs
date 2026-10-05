using Microsoft.AspNetCore.Mvc;

namespace StudentManagement.Controllers
{
    public class ProductController : Controller
    {
        // Action Detail
        public IActionResult Detail(int? id)
        {
            if (id == null)
            {
                return Content("Vui lòng nhập Product ID");
            }

            return Content("Product ID = " + id);
        }
    }
}