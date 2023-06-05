using DemoContentNegotiation.Models;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata;

namespace DemoContentNegotiation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfileController : ControllerBase{

        [HttpGet]
        public IActionResult GetAll()
        {
            List<Profile> profiles = new List<Profile>();
            var profile = new Profile
            {
                StudentID = Guid.NewGuid(),
                Name = "long 1",
                Age = 1
            };
            profiles.Add(profile);

            profile = new Profile
            {
                StudentID = Guid.NewGuid(),
                Name = "Long 2",
                Age = 2
            };
            profiles.Add(profile);

            profile = new Profile
            {
                StudentID = Guid.NewGuid(),
                Name = "Long 3",
                Age = 3
            };
            profiles.Add(profile);

            return Ok(profiles);
        }
    }
}
