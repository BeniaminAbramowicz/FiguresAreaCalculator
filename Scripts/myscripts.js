$(document).ready(function () {
    $("#calculateArea").click(function () {
        var inputData = $('#calcData').val();
        var chosenFigure = $('#select').val();
        var calculationData = { InputData: inputData, ChosenFigure: chosenFigure }
        $.ajax({
            type: "POST",
            contentType: "application/json; charset=utf-8",
            data: JSON.stringify(calculationData),
            url: "/Home/Count",
            dataType: "json",
            success: function (data) {
                $('#figureArea').text('Pole powierzchni wybranej figury - ' + $('#select option:selected').text() + ' wynosi: ' + data);
            },
            error: function (result) {
                alert("Wystąpił błąd");
            }
        });
        
    });
});

$("#select").change(function () {
    $('.invi').css('visibility', 'visible');
    switch ($('#select').val()) {
        case 'square':
            $('#instructions').text("Wprowadź pojedynczą wartość - długość boku kwadratu. Jeśli długość jest liczbą dziesiętną jako separatora dziesiętnego należy użyć przecinka.")
            $('#figureArea').text("");
            $('#calcData').val('');
            break;
        case 'rectangle':
            $('#instructions').text("Wprowadź długość pierwszego i drugiego boku kwadratu oddzielając wartości pojedynczym znakiem spacji. Jeśli długość jest liczbą dziesiętną jako separatora dziesiętnego należy użyć przecinka.")
            $('#figureArea').text("");
            $('#calcData').val('');
            break;
        case 'triangle':
            $('#instructions').text("Wprowadź długość podstawy trójkąta i jego wysokość oddzielając wartości pojedynczym znakiem spacji. Jeśli długość lub wysokość jest liczbą dziesiętną jako separatora dziesiętnego należy użyć przecinka.")
            $('#figureArea').text("");
            $('#calcData').val('');
            break;
        case 'circle':
            $('#instructions').text("Wprowadź pojedynczą wartość - promień koła. Jeśli promień jest liczbą dziesiętną jako separatora dziesiętnego należy użyć przecinka.")
            $('#figureArea').text("");
            $('#calcData').val('');
            break;
        case 'trapezoid':
            $('#instructions').text("Wprowadź długość pierwszej podstawy trapzu, drugiej podstawy trapezu oraz jego wysokość oddzielając wartości pojedynczym znakiem spacji. Jeśli długości podstaw lub wyokość są liczbami dzisiętnymi jako separatora dziesiętnego należy użyć przecinka.")
            $('#figureArea').text("");
            $('#calcData').val('');
            break;
        case 'rhombus':
            $('#instructions').text("Wprowadź długość boku rombu i jego wysokość oddzielając wartości pojedynczym znakiem spacji. Jeśli długość boku lub wysokość jest liczbą dziesiętną jako separatora dziesiętnego należy użyć przecinka")
            $('#figureArea').text("");
            $('#calcData').val('');
            break;
    }
});