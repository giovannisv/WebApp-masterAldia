"use strict";
var IdentificacionGrid;
(function (IdentificacionGrid) {
    if (MensajeApp != "") {
        Toast.fire({
            icon: "success", title: MensajeApp
        });
    }
    function OnClickEliminar(id) {
        ComfirmAlert("Desea eliminar el registro?", "Eliminar", "warning", "#3085d6", "d33")
            .then(function (result) {
            if (result.isConfirmed) {
                window.location.href = "Identificacion/Grid?handler=Eliminar&id=" + id;
            }
        });
    }
    IdentificacionGrid.OnClickEliminar = OnClickEliminar;
    $("#GridView").DataTable();
})(IdentificacionGrid || (IdentificacionGrid = {}));
//# sourceMappingURL=Grid.js.map