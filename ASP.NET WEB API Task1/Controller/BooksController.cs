using ASP.NET_WEB_API_Task1.Entities;
using ASP.NET_WEB_API_Task1.Entities.Dtos.Books;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ASP.NET_WEB_API_Task1.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {private readonly DAL.APIDbContext _context;
        public BooksController(DAL.APIDbContext context)
        {
            _context = context;
        }
        //[HttpGet]
        //public async Task<IActionResult> GetAll()
        //{
        //   return Ok(await _context.Books.ToListAsync());

        //}

        [HttpPost]
        public async Task<IActionResult> CreateBook(CreateBookDto bookdto)
        {
            Book book = new Book()
            {
                Name = bookdto.Name,
                Desc = bookdto.Desc,
                Price = bookdto.Price,
                CreatedAt = DateTime.UtcNow,
            };
            await _context.Books.AddAsync(book);
            await _context.SaveChangesAsync();
            return NoContent();

        }
    }
}
