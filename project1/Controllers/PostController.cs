using Microsoft.AspNetCore.Mvc;

namespace project1.Controllers
{
    [ApiController]
    public class PostController : ControllerBase
    {
        [HttpPost]
        [Route("/PostMethod/name")]
        public string PostMethod(string name) {
            return name;

        }

    }
}
