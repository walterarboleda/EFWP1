using System.Diagnostics;
using System.Threading.Tasks;
using EFWP1.Data;
using EFWP1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace EFWP1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly SampleDbContext _context;

        public HomeController(ILogger<HomeController> logger, SampleDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task<IActionResult> Index(int catPage = 1, int prodPage = 1, int catPageSize = 5, int prodPageSize = 10)
        {
            if (catPage < 1) catPage = 1;
            if (prodPage < 1) prodPage = 1;

            // Totales
            var totalCategories = await _context.Categories.CountAsync();
            var totalProducts = await _context.Products.CountAsync();

            // Paginado de categorías (incluye sus productos para mostrar la lista dentro de cada categoría)
            var categories = await _context.Categories
                .Include(c => c.Products)
                .OrderBy(c => c.CategoryId)
                .Skip((catPage - 1) * catPageSize)
                .Take(catPageSize)
                .ToListAsync();

            // Paginado de productos (incluye la categoría)
            var products = await _context.Products
                .Include(p => p.Category)
                .OrderBy(p => p.ProductId)
                .Skip((prodPage - 1) * prodPageSize)
                .Take(prodPageSize)
                .ToListAsync();

            var model = new HomeModel
            {
                Categories = categories,
                Products = products,
                CategoryPageInfo = new PageInfo
                {
                    TotalItems = totalCategories,
                    CurrentPage = catPage,
                    ItemsPerPage = catPageSize
                },
                ProductPageInfo = new PageInfo
                {
                    TotalItems = totalProducts,
                    CurrentPage = prodPage,
                    ItemsPerPage = prodPageSize
                }
            };

            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
