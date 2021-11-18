using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BD;
using Entity;

namespace WBL
{
    public interface IEmpleadoService
    {
        Task<DBEntity> Create(EmpleadoEntity entity);
        Task<DBEntity> Delete(EmpleadoEntity entity);
        Task<IEnumerable<EmpleadoEntity>> Get();
        Task<EmpleadoEntity> GetById(EmpleadoEntity entity);
        Task<DBEntity> Update(EmpleadoEntity entity);
    }

    public class EmpleadoService : IEmpleadoService
    {
        private readonly IDataAccess sql;

        public EmpleadoService(IDataAccess _sql)
        {
            sql = _sql;
        }

        #region MetodosCrud

        //Metodo Get


        public async Task<IEnumerable<EmpleadoEntity>> Get()
        {
            try
            {
                var result = sql.QueryAsync<EmpleadoEntity,TipoIdentificacionEntity>("dbo.EmpleadoObtener","IdEmpleado,IdTipoIdentificacion");

                return await result;
            }
            catch (Exception)
            {

                throw;
            }


        }

        //Metodo GetById
        public async Task<EmpleadoEntity> GetById(EmpleadoEntity entity)
        {
            try
            {
                var result = sql.QueryFirstAsync<EmpleadoEntity>("dbo.EmpleadoObtener", new
                { entity.IdEmpleado });

                return await result;
            }
            catch (Exception)
            {

                throw;
            }

        }

        //Metodo Create

        public async Task<DBEntity> Create(EmpleadoEntity entity)
        {
            try
            {
                var result = sql.ExecuteAsync("dbo.EmpleadoInsertar", new
                {
                    entity.Nombre,
                    entity.PrimerApellido,
                    entity.SegundoApellido,
                    entity.Edad,
                    entity.FechaNacimiento,
                    entity.TipoIdentificacion,
                    entity.Identificacion



                });

                return await result;
            }
            catch (Exception)
            {

                throw;
            }

        }

        //Metodo Update
        public async Task<DBEntity> Update(EmpleadoEntity entity)
        {
            try
            {
                var result = sql.ExecuteAsync("dbo.EmpleadoActualizar", new
                {
                    entity.IdEmpleado,
                    entity.Nombre,
                    entity.PrimerApellido,
                    entity.SegundoApellido,
                    entity.Edad,
                    entity.FechaNacimiento,
                    entity.TipoIdentificacion,
                    entity.Identificacion


                });

                return await result;
            }
            catch (Exception)
            {

                throw;
            }

        }

        //Metodo Delete
        public async Task<DBEntity> Delete(EmpleadoEntity entity)
        {
            try
            {
                var result = sql.ExecuteAsync("dbo.EmpleadoEliminar", new
                {
                    entity.IdEmpleado,



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


