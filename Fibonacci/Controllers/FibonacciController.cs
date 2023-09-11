using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Fibonacci.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FibonacciController : ControllerBase
    {
        public FibonacciController() { }
    }
}
