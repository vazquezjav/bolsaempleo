using BolsaEmpleo.BIL.LANDING;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BolsaEmpleo.Controllers.v1
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class StateCivilController : Controller
    {
        private readonly StateCivilService service;

        public StateCivilController(StateCivilService service)
        {
            this.service = service;
        }

        [HttpGet, Route("get-active")]
        public IActionResult Get()
        {
            return Ok(this.service.GetAllActive());
        }

    }
}
