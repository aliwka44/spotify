using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol.Core.Types;
using Prk1.Dal;
using Prk1.Models;
using Prk1.ViewModels;

namespace Prk1.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;
        public ProductController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public async Task<ActionResult> Index()
        {

            var products = await _context.Products.Include(p => p.Category).ToListAsync();
            return View(products);
        }
        public async Task<IActionResult> Create()
        {
            //ViewBag.Categories = await _context.Categories.ToListAsync();
            //return View();
            CreateProductVM productVM = new CreateProductVM
            {
                Categories = await _context.Categories.ToListAsync()
            };
            return View(productVM);
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateProductVM productVM)
        {
            if (!ModelState.IsValid)
            {
                productVM.Categories = await _context.Categories.ToListAsync();
                return View(productVM);
            }
            string filename = Guid.NewGuid().ToString() + productVM.Photo.FileName;

            string path = Path.Combine(_env.WebRootPath, "admin", "images", "products", filename);
            using (FileStream file = new FileStream(path, FileMode.Create))
            {
                await productVM.Photo.CopyToAsync(file);

            };


            _context.Products.AddAsync(new Product
            {
                CategoryId = productVM.CategoryId,
                Image = filename,
                Name = productVM.Name 
            });

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }
    }

}
