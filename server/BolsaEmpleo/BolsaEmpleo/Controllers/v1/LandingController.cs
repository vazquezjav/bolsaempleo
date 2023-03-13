using BolsaEmpleo.BIL.LANDING;
using BolsaEmpleo.MODELS.DTO;
using Microsoft.AspNetCore.Mvc;

namespace BolsaEmpleo.Controllers.v1
{
    [Route("api/[controller]")]
    [ApiController]
    public class LandingController : Controller
    {
        private readonly LandingService service;

        public LandingController(LandingService service)
        {
            this.service = service;
        }

        [HttpPost, Route("save")]
        public IActionResult Save([FromBody]FormLandingDTO dto)
        {
            try
            {
                this.service.PorcessLanding(dto);
                return Ok(new {message= "Registrado Correctamente"});
            }
            catch(Exception ex)
            {
                return Conflict(new {message ="Error: "+ex.Message});
            }
            
        }
    }
}
