using apiMap.Models;
using apiMap.Services;
using Microsoft.AspNetCore.Mvc;
using static apiMap.Models.MarMap;

namespace apiMap.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class apiMapController : ControllerBase
    {
        private readonly MarcService _services;
        public apiMapController(MarcService MarcService)
        {
            _services = MarcService;
        }
       
       


        [HttpGet]
        public async Task<Marcador> obMarcget()
        {
                       
            try
            {

                return await _services.listaMarca();
            }
            catch (Exception)
            {
                throw;
            }
                    }


    }
}
