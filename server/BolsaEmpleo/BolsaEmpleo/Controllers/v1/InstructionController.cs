using BolsaEmpleo.BIL.LANDING;
using Microsoft.AspNetCore.Mvc;

namespace BolsaEmpleo.Controllers.v1
{
    [Route("api/[controller]")]
    [ApiController]
    public class InstructionController : Controller
    {

        private readonly InstructionService service;

        public InstructionController(InstructionService service)
        {
            this.service = service;
        }

        [HttpGet, Route("get-active")]
        public IActionResult Get()
        {
            return Ok(this.service.GetActive());
        }
    }
}
