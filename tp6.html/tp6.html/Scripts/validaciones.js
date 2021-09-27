function validacion()
{
    if ($("#Nombre").val() == "") {
        // Si no se cumple la condicion...
        alert('[ERROR] El campo Nombre es Requerido');
        return false;
    }
    else if ($("#Apellido").val() == "") {
        // Si no se cumple la condicion...
        alert('[ERROR] El campo Apellido es Requerido');
        return false;
    }   
    return true;

}
function LimpiarCampos() {
    $("#formulario")[0].reset();
}
function soloNumeros(evt)
{

    // code is the decimal ASCII representation of the pressed key.
    var code = (evt.which) ? evt.which : evt.keyCode;

    if (code == 8) { // backspace.
        return true;
    } else if (code >= 48 && code <= 57) { // is a number.
        return true;
    } else { // other keys.
        return false;
    }
}