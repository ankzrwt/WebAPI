using Microsoft.AspNetCore.Mvc;
using project1.Services;


namespace project1.Controllers
{
    [ApiController]
    public class BookController: ControllerBase
    {
        public BookService bookService = new BookService();

        [HttpGet]
        [Route("/")]
        public IActionResult getAllBook()
        {
            var response = bookService.getAll();

            if (response.Count == 0) {
                return  NotFound("Book did not found");
            }
            return Ok(response);
        }

        [HttpGet]
        [Route("/getBookId/{Id}")]
        public IActionResult getBookId(int Id)
        {
            var response = bookService.getBookId(Id);
            if (response == null)
            {
                return NotFound("book not found");
            }
            return Ok(response);
        }
    }
}
