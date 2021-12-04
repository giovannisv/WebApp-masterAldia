using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WBL;
using Entity;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpleadoController : ControllerBase
    {
        private readonly IEmpleadoService empleadoService;

        public EmpleadoController(IEmpleadoService empleadoService )
        {
            this.empleadoService = empleadoService;
        }
        //se construyen los metodos
        [HttpGet]
        public async Task<IEnumerable<EmpleadoEntity>> Get()
        {
            try
            {
                
                return await empleadoService.Get();
            }
            catch (Exception ex)
            {

                return new List<EmpleadoEntity>();
            }



        }
        [HttpGet("{id}")]
        public async Task<EmpleadoEntity> Get(int id)
        {
            try
            {

                return await empleadoService.GetById(new EmpleadoEntity { IdEmpleado = id });
            }
            catch (Exception ex)
            {

                return new EmpleadoEntity { CodeError = ex.HResult, MsgError = ex.Message };
            }



        }
        [HttpPost] 
        public async Task<DBEntity> Create (EmpleadoEntity entity)
        {
            try
            {

                return await empleadoService.Create(entity);
            }
            catch (Exception ex)
            {

                return new DBEntity { CodeError = ex.HResult, MsgError = ex.Message };
            }

        }
        [HttpPut]
        public async Task<DBEntity> Update(EmpleadoEntity entity)
        {
            try
            {

                return await empleadoService.Update(entity);
            }
            catch (Exception ex)
            {

                return new DBEntity { CodeError = ex.HResult, MsgError = ex.Message };
            }

        }
        [HttpDelete ("{id}")]
        public async Task<DBEntity> Delete(int id)
        {
            try
            {

                return await empleadoService.Delete(new EmpleadoEntity { IdEmpleado = id });
            }
            catch (Exception ex)
            {

                return new DBEntity { CodeError = ex.HResult, MsgError = ex.Message };
            }

        }
    }
}
