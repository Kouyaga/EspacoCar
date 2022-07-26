function verificarLogin() {
    usuarioAuth = "admin";
    login = $('#login').val();
    
    if (login == usuarioAuth) {
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
            background: 'gray',
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
   
}

function verificarSenha() {
    senhaAuth = "admin";
    senha = $('#senha').val();
     if (senha == senhaAuth) {
        Swal.fire({
            title: 'Senha Correta',
            backdrop: false,
            toast: true,
            position: 'top',
            text: '',
            icon: 'success',
            iconColor: 'lightgreen',
            cancelButtonColor: 'darkred',
            confirmButtonColor: 'lightgreen',
            confirmButtonText: 'Confirmar',
            background: 'gray',
            timer: 5000,
            timerProgressBar: true,
            customClass: {
                popup: 'font-family'
            }
        })
         $('#realizarLogin').click();
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
            background: 'gray',
            timer: 5000,
            timerProgressBar: true,
            customClass: {
                popup: 'font-family'
            }
        })
    }

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
