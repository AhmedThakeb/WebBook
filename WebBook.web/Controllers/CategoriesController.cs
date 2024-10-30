using Microsoft.AspNetCore.Mvc;

namespace WebBook.web.Controllers
{
	public class CategoriesController : Controller
	{
		private readonly ApplicationDbContext db;

		public CategoriesController(ApplicationDbContext db)
        {
			this.db = db;
		}
        public IActionResult Index()
		{
			//TODO: use VM
			var categories = db.Categories;
			return View(categories);
		}
	}
}
