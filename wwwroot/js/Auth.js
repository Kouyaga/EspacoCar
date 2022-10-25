function VerificarLogin() {
    login = $("#login").val();
    $.ajax({
        type: "POST",
        url: document.location.origin + "/Auth/VerificarLogin",
        data: { login },
        success: function (retorno) {
            if (retorno.ok) {
                $("#senha").show();
                $("#login").hide();
                $("#botaoLogin").hide('slow');
                $("#botaoCancelar").show('slow');
                $("#botaoSenha").show('slow');
                $("#fundoVerSenha").hide();
                $("#fundoEsconderSenha").show();
            } else {
                Swal.fire({
                    title: 'Usuário Inválido!',
                    backdrop: false,
                    toast: true,
                    position: 'top',
                    text: '',
                    icon: 'error',
                    iconColor: 'darkred',
                    cancelButtonColor: 'darkred',
                    confirmButtonColor: 'darkred',
                    confirmButtonText: 'Fechar',
                    background: '#517664',
                    timer: 5000,
                    timerProgressBar: true,
                    customClass: {
                        popup: 'font-family'
                    }
                })
                $("#senha").hide();
                $("#login").show();
                $("#botaoLogin").show('slow');
                $("#botaoCancelar").hide('slow');
                $("#botaoSenha").hide('slow');
                $("#fundoVerSenha").hide();
                $("#fundoEsconderSenha").show();

            }
        },
    })
}

function VerificarSenha() {
    senha = $('#senha').val();
    $.ajax({
        type: "POST",
        url: document.location.origin + "/Auth/VerificarSenha",
        data: { senha },
        success: function (retorno) {
            if (retorno.ok) {
            Swal.fire({
                title: 'Realizando Login...',
                backdrop: false,
                toast: true,
                position: 'top',
                text: '',
                icon: 'success',
                iconColor: 'lightgreen',
                cancelButtonColor: 'darkred',
                confirmButtonColor: 'lightgreen',
                confirmButtonText: 'Confirmar',
                background: '#517664',
                timer: 500,
                timerProgressBar: true,
                customClass: {
                    popup: 'font-family'
                }
            }).then(function () {
                $('#realizarLogin').click();
            });
        } else {
            Swal.fire({
                title: 'Senha Inválida!',
                backdrop: false,
                toast: true,
                position: 'top',
                text: '',
                icon: 'error',
                iconColor: 'darkred',
                cancelButtonColor: 'darkred',
                confirmButtonColor: 'darkred',
                confirmButtonText: 'Fechar',
                background: '#517664',
                timer: 2500,
                timerProgressBar: true,
                customClass: {
                    popup: 'font-family'
                }
            })
        }
    },
})
}

function trocarLogin() {
    $("#senha").hide();
    $("#login").show();
    $("#botaoLogin").show('slow');
    $("#botaoCancelar").hide('slow');
    $("#botaoSenha").hide('slow');
    $('#botaoVerSenha').hide();
    $("#fundoVerSenha").hide();
    $("#fundoEsconderSenha").show();
}

function mostrarSenha() {
    if ($('#senha').get(0).type == 'password') {
        $('#senha').get(0).type = 'text';
        $('#botaoVerSenhaImagem').hide();
        $('#botaoEsconderSenhaImagem').show();
    } else {
        $('#senha').get(0).type = 'password';
        $('#botaoEsconderSenhaImagem').hide();
        $('#botaoVerSenhaImagem').show();
    }
}

$("#senha").on('keydown', function (event) {
    if (event.which === 13) {
        event.preventDefault();
        $("#botaoSenha").click();
    }
});

$("#login").on('keydown', function (event) {
    if (event.which === 13) {
        event.preventDefault();
        $("#botaoLogin").click();
    }
});
