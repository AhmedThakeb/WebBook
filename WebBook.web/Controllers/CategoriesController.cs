using Microsoft.AspNetCore.Mvc;
using Microsoft.Graph.Models;
using WebBook.web.Core.Models;
using WebBook.web.Core.ViewModels;

namespace WebBook.web.Controllers
{
	public class CategoriesController : Controller
	{
		private readonly ApplicationDbContext db;
       

        public string Name { get; private set; }

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
		[HttpGet]
		public IActionResult Create()
		{
           
            
            return View();
        }
		[HttpPost]
        public IActionResult Create(CategoryFormVM model)
        {
			if (!ModelState.IsValid) return View(model);
			var category = new Category { Name = model.Name };
			db.Categories.Add(category);
			db.SaveChanges();

				return RedirectToAction(nameof(Index));
        }
		
		[HttpGet]
        public IActionResult Edit(int Id)
        {
			var category = db.Categories.Find(Id);
			
            return View(category);
        }
		[HttpPost]
		public IActionResult Edit(CategoryFormVM model)
		{
			if (!ModelState.IsValid)
				return View(model);
			var category = db.Categories.Find(model.Id);
			if (category == null)
				return NotFound();
			category.Name = model.Name;
			category.UpdateOn = DateTime.Now;
			db.SaveChanges();
			return RedirectToAction(nameof(Index));
		}
	}	
}
