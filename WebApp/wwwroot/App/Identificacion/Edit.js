"use strict";
var IdentificacionEdit;
(function (IdentificacionEdit) {
    var Formulario = new Vue({
        data: {
            Formulario: "#FormEdit"
        },
        mounted: function () {
            CreateValidator(this.Formulario);
        }
    });
    Formulario.$mount("#AppEdit");
})(IdentificacionEdit || (IdentificacionEdit = {}));
//# sourceMappingURL=Edit.js.map