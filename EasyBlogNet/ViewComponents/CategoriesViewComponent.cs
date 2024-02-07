using EasyBlogNet.Data;
using Microsoft.AspNetCore.Mvc;

namespace EasyBlogNet.ViewComponents
{
    public class CategoriesViewComponent : ViewComponent
    {
        private readonly ApplicationDbContext _db;

        public CategoriesViewComponent(ApplicationDbContext db)
        {
            _db = db;
        }
        public IViewComponentResult Invoke()
        {
            return View(_db.Categories.ToList());
        }
    }
}
