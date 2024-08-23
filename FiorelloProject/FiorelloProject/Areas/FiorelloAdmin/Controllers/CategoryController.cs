using Microsoft.AspNetCore.Mvc;
using MVC_Pronia_Template.DAL;

namespace FiorelloProject.Areas.FiorelloAdmin.Controllers
{
    public class CategoryController : Controller
    {
        private readonly AppDbContext _context;

        public CategoryController(AppDbContext context)
        {
            _context = context;
        }
        //public async Task<IActionResult> Index()
        //{
        //    List<Category> categories = await _context.Categories.Where(c => !c.IsDeleted);
        //    return View(categories);
        //}
    }
}
