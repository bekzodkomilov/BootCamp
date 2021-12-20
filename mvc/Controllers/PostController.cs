using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using mvc.ViewModels;

namespace mvc.Controllers
{
    [Route("[controller]")]
    public class PostController : Controller
    {
        private readonly ILogger<PostController> _logger;

        public PostController(ILogger<PostController> logger)
        {   
            _logger = logger;
        }

        [HttpGet("write")]
        public IActionResult WritePost()
        {
            return View();
        }

        [HttpPost("write")]
        public IActionResult WritePost([FromForm]ViewPostModel model)
        {
            return Ok(model);
        }
    }
}