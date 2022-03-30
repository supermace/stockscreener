// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.

$(document).ready(function () {
    console.log("ready!");
    var rows = $('.table > tbody > tr')

    rows.each(function (index, row) {
        var price = row.cells[2].innerHTML; //  find("td:eq(2)").text();
        var targetprice = row.cells[11].innerHTML; // row.find("td:eq(11)").text();
        var offset = ((parseFloat(price) / parseFloat(targetprice)) - 1) * 100;
        //row.removeClass("priceover10 priceunder10 priceoverminus10 priceunderminus10");

        if (offset > 10) {
            $(row).addClass("priceover10");
        }

        if (offset > 0 && offset < 10) {
            $(row).addClass("priceunder10");
        }

        if (price > 0 && targetprice > 0 && offset < 0 && offset > -10) {
            $(row).addClass("priceoverminus10");
        }

        if (price > 0 && targetprice > 0 && offset < 0 && offset < -10 ) {
            $(row).addClass("priceunderminus10");
        }

    });
});

