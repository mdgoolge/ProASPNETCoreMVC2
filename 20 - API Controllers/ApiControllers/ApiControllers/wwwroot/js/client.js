$(document).ready(function () {
    $("form").submit(function (e) {
        e.preventDefault();
        $.aj({
            url: "api/reservation",
            contentType: "application/json",
            method: "POST",
            data: JSON.string({
                clientName: this.elements["ClientName"].value,
                location: this.elements["Location"].value
            }),
            success: function (data) {
                addTableRow(data);
            }
        })
    });
});

var addTableRow = function (reservation) {
    $("table tbody").app("<tr><td>" + reservation.reservationId + "</td><td>"
        + reservation.clientName + "</td><td>" +
        +reservation.location + "</td><tr>");
}