namespace ContratoEdit {
    var Entity = $("#AppEdit").data("entity");

    var Formulario = new Vue(
        {
            data:
            {
                Formulario: "#FormEdit",
                Entity: Entity
            },

            methods: {

                contratoServicio(entity) {
                    console.log(entity);
                    if (entity.IdContrato == null) {
                        return App.AxiosProvider.ContratoGuardar(entity);

                    } else {
                        return App.AxiosProvider.ContratoActualizar(entity);

                    }
                },

                Save() {

                    if (BValidateData(this.Formulario)) {
                        Loading.fire("Guardando");

                        this.contratoServicio(this.Entity).then(data => {
                            Loading.close();

                            if (data.CodeError == 0) {
                                Toast.fire({ title: "Se guardo correctamente", icon: "success" })
                                    .then(() => window.location.href = "Contrato/Grid");
                            }
                            else {
                                Toast.fire({ title: data.MsgError, icon: "error" });
                            }


                        }).catch(c => console.log(c));

                    }
                    else {
                        Toast.fire({ title: "Por favor complete los campos requeridos" });

                    }

                }
            },





            mounted() {
                CreateValidator(this.Formulario)

            }
        }

    );

    Formulario.$mount("#AppEdit")

}
   