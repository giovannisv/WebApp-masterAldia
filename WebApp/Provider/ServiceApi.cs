using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entity;
using System.Net.Http;




namespace WebApp
{
    public class ServiceApi
    {
        private readonly HttpClient client;

        public ServiceApi(HttpClient client)
        {
            this.client = client;
        }


        public async Task<IEnumerable<EmpleadoEntity>> EmpleadoGet()
        {

            var result = await client.ServicioGetAsync<IEnumerable<EmpleadoEntity>>("api/Empleado");
            return result;

        }


        public async Task<EmpleadoEntity> EmpleadoGetById(int id)
        {
            var result = await client.ServicioGetAsync<EmpleadoEntity>("api/Empleado/" + id);

            if (result.CodeError is not 0) throw new Exception(result.MsgError);

            return result;

        }

        public async Task<IEnumerable<TipoIdentificacionEntity>> TipoIdentificacionGetLista()
        {

            var result = await client.ServicioGetAsync<IEnumerable<TipoIdentificacionEntity>>("api/TipoIdentificacion/Lista");
            return result;

        }


    }
}
