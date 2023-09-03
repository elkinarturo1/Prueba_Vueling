using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModelsGNB;
using BussinesGNB.BL;
using BussinesGNB.Interfaces;

namespace ServicesGNB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RatesController : ControllerBase
    {
        IRatesServicesBL servicioBL = new RatesServicesBL();

        [HttpGet]
        [Route("viewAllRates")]
        public List<RatesModel> viewAllRates()
        {
            return servicioBL.viewAllRates();
        }
    }
}
