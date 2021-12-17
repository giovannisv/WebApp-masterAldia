
namespace App.AxiosProvider   {

    //export const GuardarEmpleado = () => axios.get<Entity.DBEntity>("aplicacion").then(({data})=>data );

    export const ContratoEliminar = (id) => axios.delete<DBEntity>("Contrato/Grid?handler=Eliminar&id=" + id).then(({ data }) => data);
    export const ContratoGuardar = (entity) => axios.post<DBEntity>("Contrato/Edit", entity).then(({ data }) => data);

    export const EmpleadoEliminar = (id) => ServiceApi.delete<DBEntity>("api/Empleado/" + id).then(({ data }) => data);
    export const EmpleadoGuardar = (entity) => ServiceApi.post<DBEntity>("api/Empleado", entity).then(({ data }) => data);
    export const EmpleadoActualizar = (entity) => ServiceApi.put<DBEntity>("api/Empleado", entity).then(({ data }) => data);
}




