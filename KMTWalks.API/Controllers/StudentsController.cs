using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KMTWalks.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAllStudents()
        {
            string[] studentNames = new string[] { "David", "Siti", "Wawan", "Bambang" };

            return Ok(studentNames);
        }
    }
}
