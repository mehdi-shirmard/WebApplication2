using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.controllers1
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class Homecontroller : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> AddTest([FromForm] Test test)
        {
            string data = $"""
                       <form>
                       <input type="text" name="FirstName" value="{test.FirstName}"
                       <input type="text" name="{nameof(test.LastName)}" value="{test.LastName}"
                       </form>
                       """;
            return Ok(data);
        }
    }
    public record Test 
    {
        public required string FirstName {  get; set; }
        public required string LastName { get; set; }
    }
}

