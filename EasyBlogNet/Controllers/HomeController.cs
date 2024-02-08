using EasyBlogNet.Data;
using EasyBlogNet.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace EasyBlogNet.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _db;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext db)
        {
            _logger = logger;
            _db = db;
        }

        //public IActionResult Index()
        //{
        //    return View(_db.Posts.OrderByDescending(x => x.Id).ToList());
        //}

        public IActionResult Index(int? cid)
        {
            IQueryable<Post> posts = _db.Posts;


            if (cid != null)
            {
                posts = posts.Where(p => p.CategoryId == cid);
                ViewBag.CategoryName = _db.Categories.Find(cid)?.Name;
            }

           

            return View(posts.OrderByDescending(x => x.Id).ToList());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [Route("Post/{id:int}")]
        public IActionResult ShowPost(int id)
        {
            // id ile gelen postu bul
            var post = _db.Posts.Include(x => x.Category).FirstOrDefault(x => x.Id == id);
            if (post == null) { return NotFound(); }

            return View(post);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
