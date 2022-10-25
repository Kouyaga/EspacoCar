
function ExibirPJ() {
    $("#informacoesNovoClientePF").hide();
    $("#informacoesNovoClientePJ").show();
}

function ExibirPF() {
    $("#informacoesNovoClientePJ").hide();
    $("#informacoesNovoClientePF").show();
}

$("#BotaoAdicionarPF").on('click', function (event) {
    event.preventDefault();
    if ($("#CPF").val() != "" && $("#nome").val() != "") {
        Swal.fire({
            position: 'top-end',
            icon: 'success',
            title: 'Cliente Adicionado',
            showConfirmButton: false,
            timer: 1500
        }).then((result) => {
            $("#adicionarClientePFForm").submit();
        });
    } else {
        Swal.fire({
            position: 'center',
            icon: 'error',
            title: 'Preencha o NOME e o CPF!',
            showCancelButton: true,
            showConfirmButton: false,
            timer: 2500,
            width: '30%'
        });
    }
});

$("#BotaoAdicionarPJ").on('click', function (event) {
    event.preventDefault();
    if ($("#CPNJ").val() != "" && $("#razaoSocial").val() != "") {
        Swal.fire({
            position: 'top-end',
            icon: 'success',
            title: 'Cliente Adicionado',
            showConfirmButton: false,
            timer: 1500
        }).then((result) => {
            $("#adicionarClientePJForm").submit();
        });
    } else {
        Swal.fire({
            position: 'center',
            icon: 'error',
            title: 'Preencha o CPNJ e a Razao Social!',
            showCancelButton: true,
            showConfirmButton: false,
            timer: 2500,
            width: '30%'
        });
    }
});

$(document).ready(function ($) {
    $('.date').mask('00/00/0000');
    $('.date_time').mask('00/00/0000 00:00:00');
    $('.cep').mask('00000-000');
    $('.phone').mask('0000-0000');
    $('.phone_with_ddd').mask('(00) 00000-0000');
    $('.phone_us').mask('(000) 000-0000');
    $('.rg').mask('00.000.000-A');
    $('.cpf').mask('000.000.000-00', { reverse: false });
    $('.cnpj').mask('00.000.000/0000-00', { reverse: false });
    $('.money').mask('000.000.000.000.000,00', { reverse: true });
    $('.money2').mask("#.##0,00", { reverse: true });
    $('.ip_address').mask('0ZZ.0ZZ.0ZZ.0ZZ', {
        translation: {
            'Z': {
                pattern: /[0-9]/, optional: true
            }
        }
    });
    $('.ip_address').mask('099.099.099.099');
    $('.percent').mask('##0,00%', { reverse: true });
    $('.clear-if-not-match').mask("00/00/0000", { clearIfNotMatch: true });
    $('.placeholder').mask("00/00/0000", { placeholder: "__/__/____" });
    $('.fallback').mask("00r00r0000", {
        translation: {
            'r': {
                pattern: /[\/]/,
                fallback: '/'
            },
            placeholder: "__/__/____"
        }
    });
    $('.selectonfocus').mask("00/00/0000", { selectOnFocus: true });
});
