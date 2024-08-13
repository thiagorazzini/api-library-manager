using LibraryManager.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManager.API.Controllers
{
    [Route("api/books")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        /// <summary>
        /// Register new book
        /// api/books
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public IActionResult PostNewBook(CreateBookInputModel model)
        {
            return Ok();
        }


        /// <summary>
        /// Return the books by search name
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        [HttpGet("/search")]
        public IActionResult GetBookByName(string search)
        {
            return Ok();
        }

        [HttpGet]
        public IActionResult GetAllBooks(BookViewModel model) 
        {
            return Ok();
        }

        /// <summary>
        /// Recover a book detail
        /// api/books/1234
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public IActionResult GetAllBooks(Guid id)
        {
            var model = new BookItemViewModel();
            return Ok(model);
        }

        /// <summary>
        /// Edit book information
        /// api/books/1234
        /// </summary>
        /// <returns></returns>
        [HttpPut("{id}")]
        public IActionResult UpdateBook(Guid id, UpdateBookInputModel model)
        {
            return NoContent();
        }

        /// <summary>
        /// Remove a book by id
        /// api/books/id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public IActionResult DeleteBook(Guid id) 
        {
            return NoContent();
        }
    }
}
