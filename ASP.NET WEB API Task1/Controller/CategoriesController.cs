using ASP.NET_WEB_API_Task1.Controller;
using ASP.NET_WEB_API_Task1.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ASP.NET_WEB_API_Task1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : Controller.ControllerBase
    {
        private readonly EcommerceDbcontext _context;

        public CategoriesController(EcommerceDbcontext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCategories()
        {
            return Ok(await _context.Categories.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCategoryById(int id)
        {
            var result = await _context.Categories.FirstOrDefaultAsync(c => c.Id == id);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCategory(CreateCategoryDto dto)
        {
            var category = new Categories
            {
                Name = dto.Name,
                Desc = dto.Desc
            };

            await _context.Categories.AddAsync(category);
            await _context.SaveChangesAsync();

            return Ok(category);
        }
    }
}