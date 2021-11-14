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
            Task<DBEntity> Create(TipoIdentificacionEntity entity);
            Task<DBEntity> Delete(TipoIdentificacionEntity entity);
            Task<IEnumerable<TipoIdentificacionEntity>> Get();
            Task<TipoIdentificacionEntity> GetById(TipoIdentificacionEntity entity);
            Task<DBEntity> Update(TipoIdentificacionEntity entity);
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


            public async Task<IEnumerable<TipoIdentificacionEntity>> Get()
            {
                try
                {
                    var result = sql.QueryAsync<TipoIdentificacionEntity>("dbo.IdentificacionObtener");

                    return await result;
                }
                catch (Exception)
                {

                    throw;
                }


            }

            //Metodo GetById
            public async Task<TipoIdentificacionEntity> GetById(TipoIdentificacionEntity entity)
            {
                try
                {
                    var result = sql.QueryFirstAsync<TipoIdentificacionEntity>("dbo.IdentificacionObtener", new
                    { entity.IdCedula });

                    return await result;
                }
                catch (Exception)
                {

                    throw;
                }
            }

            //Metodo Create

            public async Task<DBEntity> Create(TipoIdentificacionEntity entity)
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
            public async Task<DBEntity> Update(TipoIdentificacionEntity entity)
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
            public async Task<DBEntity> Delete(TipoIdentificacionEntity entity)
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

