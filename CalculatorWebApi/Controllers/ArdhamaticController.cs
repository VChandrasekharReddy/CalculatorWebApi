using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CalculatorWebApi.model.Entity;
using CalculatorWebApi.Repo;
namespace CalculatorWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArdhamaticController : ControllerBase
    {
        private readonly ArthamaticRepo _Ardhamaticrepo;
        
        public ArdhamaticController(ArthamaticRepo Ardhamaticrepo)
        {
            _Ardhamaticrepo = Ardhamaticrepo;
        }


        [HttpGet("add")]
        public async Task<IActionResult> Add([FromQuery] double a, [FromQuery] double b)
        {
            var result = a + b;
            var arthamatic = new Arthamatic
            {
                oprand1 = a,
                oprand2 = b,
                symbol = '+',
                result = result
            };
            await _Ardhamaticrepo.SaveAndReturn(arthamatic);
            return Ok(result);
        }
        [HttpPost("Subtract")]
        public async Task<IActionResult> Subtract([FromQuery] double a, [FromQuery] double b)
        {
            var result = a - b;
            var ardhametic = new Arthamatic
            {
                oprand1 = a,
                oprand2 = b,
                symbol = '-',
                result = result
            };
            await _Ardhamaticrepo.SaveAndReturn(ardhametic);
            return Ok(result);
        }
        [HttpPost("Multiplicatoin")]
        public async Task<IActionResult> Multiplication([FromQuery] double a, [FromQuery] double b)
        {
            var result = a * b;
            var obj = new Arthamatic
            {
                oprand1 = a,
                oprand2 = b,
                symbol = '*',
                result = result
            };
            await _Ardhamaticrepo.SaveAndReturn(obj);
            return Ok(result);
        }
        [HttpPost("Division")]
        public async Task<IActionResult> Divide([FromQuery] double a, [FromQuery]double b)
        {
            var result = a / b;
            var obj = new Arthamatic
            {
                oprand1 = a,
                oprand2 = b,
                symbol = '/',
                result = result
            };
            await _Ardhamaticrepo.SaveAndReturn(obj);
            return Ok(result);
        }

        [HttpGet("GetHistory")]
        public async Task<IActionResult> GetAllData()
        {
            return Ok(await _Ardhamaticrepo.GetAllOperationsAsync());
        }
        [HttpGet("GetHistoryString")]
        public async Task<IActionResult> GetAllDataString()
        {
            return Ok(await _Ardhamaticrepo.GetAllOperationsSymbolsAsyncString());
        }
    }
}
