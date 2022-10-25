$(document).ready(function () {
    $("#listaClientesPF").DataTable({
        buttons: [
            'excel', 'pdf', 'colvis'
        ], columnDefs: [{
            targets: -1,
        }
        ],
        "language": {
            "emptyTable": "Nenhum cliente encontrado",
            "search": "",
            "sInfo": "Mostrando clientes de _START_ a _END_ de um total de _TOTAL_ clientes",
            "sInfoEmpty": "Mostrando 0 a 0 de um total de 0 clientes",
            "sInfoFiltered": "(filtrando _MAX_ clientes)",
            "sInfoPostFix": "",
            "paginate": {
                "previous": '<i class="bi bi-arrow-left"></i>',
                "next": '<i class="bi bi-arrow-right"></i>'
            }
        }
    });
});

function ExibirDadosClientePF(CPF) {
    $.ajax({
        type: 'POST',
        url: document.location.origin + "/ClientePF/ExibirDadosClientePF",
        data: {
            CPF
        },
        success: function (response) {
            $.magnificPopup.open({
                items: {
                    src: response
                },
                type: 'inline',
                modal: true,
                closeOnBgClick: false
            });
        },
        error: function (xhr, ajaxOptions, thrownError) {
        }
    });
        }

function FecharModal() {
    var magnificPopup = $.magnificPopup.instanse;
    magnificPopup.close();
}
