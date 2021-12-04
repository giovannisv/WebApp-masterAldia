using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WBL;
using BD;
using Entity;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoIdentificacionController : ControllerBase
    {
        private readonly IIdenticicacionServicio identicicacionServicio;

        public TipoIdentificacionController(IIdenticicacionServicio identicicacionServicio)
        {
            this.identicicacionServicio = identicicacionServicio;
        }

        [HttpGet("Lista")]
        public async Task<IEnumerable<TipoIdentificacionEntity>> GetLista()
        {
            try
            {

                return await identicicacionServicio.GetLista();
            }
            catch (Exception ex)
            {

                return new List<TipoIdentificacionEntity>();
            }



        }


    }
}
