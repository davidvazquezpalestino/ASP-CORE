var Contacto = {
    IdContacto: 0,
    Nombre: '',
    CorreoElectronico: '',
    Telefono:''
};

//JQuery
//Contacto.Nombre = $("#nombre").val();

//Javascript
//Contacto.Nombre = document.getElementById('nombre').value;

function Add() {
    Contacto.IdContacto = 10;
    Contacto.Nombre = $("#nombre").val();
    Contacto.CorreoElectronico = $("#mail").val();
    Contacto.Telefono = $("#telefono").val();

    $.ajax({
        url: "ContactoController/Add",
        type: "POST",
        data: JSON.parse(Contacto),
        dataType: "json",
        contentType: "application/json",
        success: function (response) {

        },
        error: function (response) {

        },
        complete: function () {

        }
    });
}

function Delete() {
    $.ajax({
        url: "ContactoController/Delete",
        type: "DELETE",
        data: { pIdContacto: 1 },
        dataType: "json",
        contentType: "application/json",
        success: function(response) {
            
        },
        error: function(response) {

        },
        complete: function() {

        }
    });
}

function GetContactos()
{
    $.ajax({
        url: "ContactoController/GetContactos",
        type: "GET",
        dataType: "json",
        contentType: "application/json",
        success: function (response) {

        },
        error: function (response) {

        },
        complete: function () {

        }
    });
}