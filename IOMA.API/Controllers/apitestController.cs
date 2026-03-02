using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IOMA.API.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class apitestController : ControllerBase {
        [HttpGet]
        public async Task<IActionResult> Test() {
            return Ok("Api running");
        }
    }
}
