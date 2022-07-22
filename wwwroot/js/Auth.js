function verificarLogin() {
    usuarioAuth = "admin";
    login = $('#login').val();
    
    if (login == usuarioAuth) {
        $("#senha").show('slow');
        $("#login").hide('slow');
        $("#botaoLogin").hide('slow');
        $("#botaoCancelar").show('slow');
        $("#botaoSenha").show('slow');
        
    } else {
        Swal.fire({
            title: 'Usuário Inválido!',
            backdrop: false,
            toast: true,
            position: 'top-end',
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
        $("#senha").hide('slow');
        $("#login").show('slow');
        $("#botaoLogin").show('slow');
        $("#botaoCancelar").hide('slow');
        $("#botaoSenha").hide('slow');
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
            position: 'top-end',
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
    } else {
        Swal.fire({
            title: 'Senha Inválida!',
            backdrop: false,
            toast: true,
            position: 'top-end',
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
    $("#senha").hide('slow');
    $("#login").show('slow');
    $("#botaoLogin").show('slow');
    $("#botaoCancelar").hide('slow');
    $("#botaoSenha").hide('slow');
}