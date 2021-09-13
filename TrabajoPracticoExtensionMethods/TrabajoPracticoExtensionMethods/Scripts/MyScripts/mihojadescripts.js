function DividirConCero()
{
    var numeroIngresado = $('#numero').val();
    $.ajax({
        type: "POST",
        url: "Home/DividirConCero",
        data: { dividendo: numeroIngresado },
        success: function (data) {
            alert("La dvisión a Finalizado su resulado es: " + data);

        }
    });

}
function Dividir()
{

    var dividendo = $('#dividendo').val();
    var divisor = $('#divisor').val();    
    if (divisor == null)
    {
        divisor = 0;
        dividendo = numeroIngresado;
    }

    $.ajax({
        type: "POST",
        url: "Home/Dividir",
        data: { dividendo: dividendo, divisor: divisor },
        success: function (data) {
            alert(data);
        }

    });


}
function CapturarExcepcion(id) {
   
    $.ajax({
        type: "POST",
        url: "Home/ControlDeExcepciones",
        data: {accion: id},
        success: function (data)
        {
            alert(data);
        }

    });
}