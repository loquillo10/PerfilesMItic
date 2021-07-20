// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

const bsCustomFileInput = require("../lib/bs-custom-file-input/bs-custom-file-input");

// Write your JavaScript code.

//$(document).ready(function () {
//    bsCustomFileInput.init()
//});
//    //$(document).on("click", ".input", function () {
//    //    var file = $(this).parents().find(".file");
//    //    file.trigger("click");
//    //});

    $('.custom-file-input').change( function (e) {
        var fileName = $(this).val().split("\\").pop();
        $(this).next('.custom-file-label').html(fileName);
    });
//    $('input[type="file"]').change(function (e) {
//        var fileName = e.target.files[0].name;
//        $("#customFileLang").val(fileName);
//    });

//    var reader = new FileReader();
//    reader.onload = function (e) {
//        document.getElementById("preview").src = e.target.result;
//    };
//    reader.readAsDataURL(this.files[0]);

function previewFile() {
    var preview = document.querySelector('img');
    var file = document.querySelector('input[type="file"]').files[0];
    var reader = new FileReader();

    reader.onload = function () {
        preview.src = reader.result;
    }

    if (file) {
        reader.readAsDataURL(file);
    } else {
        preview.src = "";
    }
}

function contador() {
    var cantidadHijos = document.querySelector('input');

    document.onchange(function (e) {
       
    })
}

