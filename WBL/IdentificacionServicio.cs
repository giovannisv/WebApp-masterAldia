using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BD;
using Entity;

namespace WBL
{
           public interface IIdentificacionService
        {
            Task<DBEntity> Create(IdentificacionEntity entity);
            Task<DBEntity> Delete(IdentificacionEntity entity);
            Task<IEnumerable<IdentificacionEntity>> Get();
            Task<IdentificacionEntity> GetById(IdentificacionEntity entity);
            Task<DBEntity> Update(IdentificacionEntity entity);
        }

        public class IdentificacionService : IIdentificacionService
            
        {
            private readonly IDataAccess sql;

            public IdentificacionService(IDataAccess _sql)
            {
                sql = _sql;
            }

            #region MetodosCrud

            //Metodo Get


            public async Task<IEnumerable<IdentificacionEntity>> Get()
            {
                try
                {
                    var result = sql.QueryAsync<IdentificacionEntity>("dbo.IdentificacionObtener");

                    return await result;
                }
                catch (Exception)
                {

                    throw;
                }


            }

            //Metodo GetById
            public async Task<IdentificacionEntity> GetById(IdentificacionEntity entity)
            {
                try
                {
                    var result = sql.QueryFirstAsync<IdentificacionEntity>("dbo.IdentificacionObtener", new
                    { entity.IdCedula });

                    return await result;
                }
                catch (Exception)
                {

                    throw;
                }
            }

            //Metodo Create

            public async Task<DBEntity> Create(IdentificacionEntity entity)
            {
                try
                {
                    var result = sql.ExecuteAsync("dbo.IdentificacionInsertar", new
                    {
                        entity.IdTipoIdentificacion,
                        entity.Pasaporte,
                        entity.CedulaJuridica,
                        entity.Descripcion
                       
                    });

                    return await result;
                }
                catch (Exception)
                {

                    throw;
                }
            }

            //Metodo Update
            public async Task<DBEntity> Update(IdentificacionEntity entity)
            {
                try
                {
                    var result = sql.ExecuteAsync("dbo.IdentificacionActualizar", new
                    {
                        entity.IdCedula,
                        entity.IdTipoIdentificacion,
                        entity.Pasaporte,
                        entity.CedulaJuridica,
                        entity.Descripcion                    

                    });

                    return await result;
                }
                catch (Exception)
                {
                    throw;
                }
            }

            //Metodo Delete
            public async Task<DBEntity> Delete(IdentificacionEntity entity)
            {
                try
                {
                    var result = sql.ExecuteAsync("dbo.IdentificacionEliminar", new
                    {
                        entity.IdCedula,

                    });

                    return await result;
                }
                catch (Exception)
                {

                    throw;
                }

            }
            #endregion
        }
    }

