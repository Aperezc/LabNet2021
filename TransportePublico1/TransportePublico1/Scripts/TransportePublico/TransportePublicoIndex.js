function AccionAgregar()
{
    var vcantidadPasajeros = document.getElementsByName("cantidadPasajeros")[0].value;
    var vtipoTransporte;
    var cantidadTaxis = 0;
    var cantidadOmnibus = 0;
    
    for (var x = 0; x < document.getElementsByTagName("td").length; x++)
    {
        if (document.getElementsByTagName("td")[x].textContent == "Taxi") {
            cantidadTaxis += 1;
        } else if (document.getElementsByTagName("td")[x].textContent == "Omnibus")
        {
            cantidadOmnibus += 1;
        }
    }
    for (var i = 0; i < document.getElementsByName("tipoTransporte").length; i++)
    {
        if (document.getElementsByName("tipoTransporte")[i].checked)
        {
            vtipoTransporte = document.getElementsByName("tipoTransporte")[i].value;
        }
    }
    var cantidadTotalRegistros = cantidadTaxis + cantidadOmnibus;
    if (cantidadTotalRegistros >= 10) {

        alert("Solo se permite el Ingreso de 10 Unidades de Transporte Público");

    } else
    {
        if (cantidadTaxis == 5 && vtipoTransporte == "Taxi" || cantidadOmnibus == 5 && vtipoTransporte == "Omnibus") {
            alert("Se ha superado el registrado máximo para transportes de tipo "+ vtipoTransporte);

        } else
        {
            $.ajax
                ({
                    type: "POST",
                    url: "TransportePublico/TransportePublicoAgregar",
                    data: { cantidadPasajeros: vcantidadPasajeros, tipoTransporte: vtipoTransporte, ultimoRegistro: cantidadTotalRegistros },
                    success: function (data) {
                        var fila = "<tr><td>" + data[0].TipoTransporte + "</td><td>" + data[0].CantidadPasajeros + "</td><td>" + data[0].NumeroUnidad + "</td></tr>";
                        var btn = document.createElement("TR");
                        btn.innerHTML = fila;
                        document.getElementById("resultado").appendChild(btn);
                    }

                });
        }
    }

    
}