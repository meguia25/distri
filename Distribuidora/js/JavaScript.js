$(document).ready(function () {
    console.log("ready!");

    $("#ContentPlaceHolder1_TxtTiempo").hide();
    $("#ContentPlaceHolder1_TxtPaisOrigen").hide();
    $("#ContentPlaceHolder1_TxtCantMinima").hide();

    var fabricado = $("#ContentPlaceHolder1_RdbFabricado");
    var importado = $("#ContentPlaceHolder1_RdbImportado");

    fabricado.change(function(){
        $("#ContentPlaceHolder1_TxtTiempo").show();
        $("#ContentPlaceHolder1_TxtPaisOrigen").hide();
        $("#ContentPlaceHolder1_TxtCantMinima").hide();
    })
    importado.change(function () {
        $("#ContentPlaceHolder1_TxtTiempo").hide();
        $("#ContentPlaceHolder1_TxtPaisOrigen").show();
        $("#ContentPlaceHolder1_TxtCantMinima").show();
    })

    var botonEmpleado = ContentPlaceHolder1_BtnAlta;

    botonEmpleado.onClick = function () {
        $("#ContentPlaceHolder1_TxtNombre").value = "";
        $("#ContentPlaceHolder1_TxtContrasenia").value = "";
        $("#ContentPlaceHolder1_TxtEmail").value = "";
    };


});