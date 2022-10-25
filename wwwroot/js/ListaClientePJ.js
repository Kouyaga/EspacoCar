
$(document).ready(function () {
    $("#listaClientesPJ").DataTable({
        buttons: [
            'excel', 'pdf', 'colvis'
        ], columnDefs: [{
            targets: -1,
        }
        ],
        "language": {
            "search": ""
        }
    });
});

