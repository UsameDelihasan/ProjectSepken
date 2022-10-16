using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProjectSepken.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private readonly IAuthorService _authorService;

        public AuthorsController(IAuthorService authorService)
        {
            _authorService = authorService;
        }

        [HttpPost("add")]
        public IActionResult Add([FromBody] Author author)
        {
            var result = _authorService.Add(author);


            return Created("",result.Message );

        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _authorService.ReadAll();


            return Ok(result);

        }


    }
}
