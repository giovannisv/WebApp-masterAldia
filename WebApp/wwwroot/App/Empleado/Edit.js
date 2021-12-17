"use strict";
var EmpleadoEdit;
(function (EmpleadoEdit) {
    var Entity = $("#AppEdit").data("entity");
    var Formulario = new Vue({
        data: {
            Formulario: "#FormEdit",
            Entity: Entity
        },
        methods: {
            PedidoServicio: function (entity) {
                console.log(entity);
                if (entity.IdEmpleado == null) {
                    return App.AxiosProvider.EmpleadoGuardar(entity);
                }
                else {
                    return App.AxiosProvider.EmpleadoActualizar(entity);
                }
            },
            Save: function () {
                if (BValidateData(this.Formulario)) {
                    Loading.fire("Guardando");
                    this.PedidoServicio(this.Entity).then(function (data) {
                        Loading.close();
                        if (data.CodeError == 0) {
                            Toast.fire({ title: "Se guardo correctamente", icon: "success" })
                                .then(function () { return window.location.href = "Empleado/Grid"; });
                        }
                        else {
                            Toast.fire({ title: data.MsgError, icon: "error" });
                        }
                    }).catch(function (c) { return console.log(c); });
                }
                else {
                    Toast.fire({ title: "Por favor complete los campos requeridos" });
                }
            }
        },
        mounted: function () {
            CreateValidator(this.Formulario);
        }
    });
    Formulario.$mount("#AppEdit");
})(EmpleadoEdit || (EmpleadoEdit = {}));
//# sourceMappingURL=Edit.js.map