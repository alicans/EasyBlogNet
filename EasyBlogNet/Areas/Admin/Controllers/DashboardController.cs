using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EasyBlogNet.Areas.Admin.Controllers
{
    
    public class DashboardController : AdminBaseController
    {
        public IActionResult Index()
        {
            return View();
        }


    }
}
