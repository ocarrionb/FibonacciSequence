using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace Fibonacci.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FibonacciController : ControllerBase
    {
        private readonly IFibonacciService _fibonacciService;
        public FibonacciController(IFibonacciService fibonacciService) 
        {
            _fibonacciService = fibonacciService;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult Get(int index)
        {
            try
            {
                var res = _fibonacciService.FibonacciSequence(index);
                return Ok(res);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex}");
                return StatusCode(500, "Internal server error, please contact support");
            }
        }
    }
}
