function LimparCampos() {
    $("#nome").val('');
    $("#tel").val('');
    $("#cep").val('');
    $("#rua").val('');
    $("#bairro").val('');
    $("#complemento").val('');
    $("#cidade").val('');
}

function CadastrarCliente() {

    if (Check(1)) {

        var nome = $("#nome").val().trim();
        var tel = $("#tel").val().trim();
        var cep = $("#cep").val().trim();
        var rua = $("#rua").val().trim();
        var bairro = $("#bairro").val().trim();
        var complemento = $("#complemento").val().trim();
        var cidade = $("#cidade").val().trim();

        //Dados do cliente
        var dadosCliente =
        {
            Nome: nome,
            Telefone: tel

        };

        //Dados do endereço
        var dadosEndereco =
        {
            Rua: rua,
            Bairro: bairro,
            Complemento: complemento,
            Cep: cep,
            CidadeId: cidade
        };

        //Prepara as informações para serem enviadas em JSON
        var dadosClienteJ = JSON.stringify(dadosCliente);
        var dadosEnderecoJ = JSON.stringify(dadosEndereco);

        $.ajax({
            url: "/Cliente/CadastrarCliente",
            data: {
                dadosClienteJson: dadosClienteJ,
                dadosEnderecoJson: dadosEnderecoJ
            },
            success: function (ret) {
                if (ret == 1) {
                    toastr.success(RetornaMsg(1));
                    LimparCampos();
                } else {
                    toastr.error(RetornaMsg(-1));
                }

            }

        })

    }
}

function AlteraCliente() {

    if (Check(2)) {

        var id = $("#cod").val().trim();
        var nome = $("#nome").val().trim();
        var tel = $("#tel").val().trim();
        var cep = $("#cep").val().trim();
        var rua = $("#rua").val().trim();
        var bairro = $("#bairro").val().trim();
        var complemento = $("#complemento").val().trim();
        var cidade = $("#cidade").val().trim();

        //Dados do cliente
        var dadosCliente =
        {
            IdCliente: id,
            Nome: nome,
            Telefone: tel

        };

        //Dados do endereço
        var dadosEndereco =
        {
            Rua: rua,
            Bairro: bairro,
            Complemento: complemento,
            Cep: cep,
            CidadeId: cidade
        };

        //Prepara as informações para serem enviadas em JSON
        var dadosClienteJ = JSON.stringify(dadosCliente);
        var dadosEnderecoJ = JSON.stringify(dadosEndereco);
        $.ajax({
            url: "/Cliente/AlteraCliente",
            data: {
                dadosClienteJson: dadosClienteJ,
                dadosEnderecoJson: dadosEnderecoJ
            },
            success: function (ret) {
                if (ret == 1) {
                    toastr.success(RetornaMsg(1));
                } else {
                    toastr.error(RetornaMsg(-1));
                }

            }

        })
    }
}

function FiltrarCliente() {
    var filtro = $("#filtro").val().trim();

    $.ajax({
        url: '/Cliente/FiltrarCliente',
        data: {
            filtro: filtro
        },
        success: function (clientes) {
            var tabelaInicial = '<table class="table table-hover">';
            var colunas = '<thead><tr><th>Ação</th><th>Cliente</th><th>Telefone</th></tr></thead><tbody>';
            var linha = '';

            $(clientes).each(function () {
                linha += '<tr>';
                linha += '<td>';
                linha += '<a href="/Cliente/AlterarCliente?id=' + this.idCliente + '" class="btn btn-warning btn-xs">Alterar</a> '
                linha += '<a href="/Animal/GerenciarAnimal?id=' + this.idCliente + '&nome=' + this.nome + '" class="btn btn-warning btn-xs">Gerenciar Animal</a> '
                linha += '<a href="/Atendimento/NovoAtendimento?idNome=' + this.idCliente + '-' + this.nome + '" class="btn btn-warning btn-xs">Atendimento</a>'
                linha += '</td>';
                linha += '<td>';
                linha += this.nome;
                linha += '</td>';
                linha += '<td>';
                linha += this.telefone;
                linha += '</td>';
                linha += '</tr>';
            });

            var tabelaFinal = '</tbody></table>';
            var tabelaCompleta = tabelaInicial + colunas + linha + tabelaFinal;
            $("#tabelaCliente").html(tabelaCompleta);
        }
    })
}
