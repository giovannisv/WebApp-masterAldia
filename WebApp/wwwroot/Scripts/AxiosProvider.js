"use strict";
var App;
(function (App) {
    var AxiosProvider;
    (function (AxiosProvider) {
        //export const GuardarEmpleado = () => axios.get<Entity.DBEntity>("aplicacion").then(({data})=>data );
        AxiosProvider.ContratoEliminar = function (id) { return axios.delete("Contrato/Grid?handler=Eliminar&id=" + id).then(function (_a) {
            var data = _a.data;
            return data;
        }); };
        AxiosProvider.ContratoGuardar = function (entity) { return axios.post("Contrato/Edit", entity).then(function (_a) {
            var data = _a.data;
            return data;
        }); };
        AxiosProvider.EmpleadoEliminar = function (id) { return ServiceApi.delete("api/Empleado/" + id).then(function (_a) {
            var data = _a.data;
            return data;
        }); };
        AxiosProvider.EmpleadoGuardar = function (entity) { return ServiceApi.post("api/Empleado", entity).then(function (_a) {
            var data = _a.data;
            return data;
        }); };
        AxiosProvider.EmpleadoActualizar = function (entity) { return ServiceApi.put("api/Empleado", entity).then(function (_a) {
            var data = _a.data;
            return data;
        }); };
    })(AxiosProvider = App.AxiosProvider || (App.AxiosProvider = {}));
})(App || (App = {}));
//# sourceMappingURL=AxiosProvider.js.map