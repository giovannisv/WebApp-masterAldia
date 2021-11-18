using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BD;
using Entity;

namespace WBL
{
        public interface IIdenticicacionServicio

    {
        Task<IEnumerable<TipoIdentificacionEntity>> GetLista();
    }

    public class IdentificacionServicio : IIdenticicacionServicio

    {
        private readonly IDataAccess sql;

        public IdentificacionServicio(IDataAccess _sql)
        {
            sql = _sql;
        }




        public async Task<IEnumerable<TipoIdentificacionEntity>> GetLista()
        {
            try
            {
                var result = sql.QueryAsync<TipoIdentificacionEntity>("TipoIdentificacionLista");

                return await result;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
 }

           
