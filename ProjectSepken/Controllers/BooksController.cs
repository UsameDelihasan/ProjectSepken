using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ProjectSepken.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BooksController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _bookService.ReadAll();


            return Ok(result);

        }

        [HttpPost("add")]
        public IActionResult Add([FromBody] Book book)
        {
            _bookService.Add(book);

          
            return Created("","veri başarılı bir şekilde eklendi");
            
        }
      
    }
}
