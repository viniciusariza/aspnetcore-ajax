function LimparCampos() {
    $("#nome").val('');
    $("#tel").val('');
    $("#cpf").val('');
    $("#rua").val('');
    $("#bairro").val('');
    $("#complemento").val('');
    $("#cidade").val('');
}

function CadastrarFuncionario() {
    if (Check(3)) {
        var nome = $("#nome").val().trim();
        var tel = $("#tel").val().trim();
        var cpf = $("#cpf").val().trim();
        var rua = $("#rua").val().trim();
        var bairro = $("#bairro").val().trim();
        var cidade = $("#cidade").val().trim();
        var complemento = $("#complemento").val().trim();

        //Dados do funcionário
        var dadosFuncionario =
        {
            Nome: nome,
            Telefone: tel,
            Cpf: cpf

        };

        //Dados do endereço
        var dadosEndereco =
        {
            Rua: rua,
            Bairro: bairro,
            Complemento: complemento,
            Cpf: cpf,
            CidadeId: cidade
        }

        //Prepara as informações para serem enviadas em JSON
        var dadosFuncionarioJ = JSON.stringify(dadosFuncionario);
        var dadosEnderecoJ = JSON.stringify(dadosEndereco);

        $.ajax({
            url: "/Funcionario/CadastrarFuncionario",
            data: {
                dadosFuncionarioJson: dadosFuncionarioJ
                ,
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

function AlteraFuncionario() {
    if (Check(4)) {
        var id = $("#cod").val().trim();
        var nome = $("#nome").val().trim();
        var tel = $("#tel").val().trim();
        var cpf = $("#cpf").val().trim();
        var rua = $("#rua").val().trim();
        var bairro = $("#bairro").val().trim();
        var cidade = $("#cidade").val().trim();
        var complemento = $("#complemento").val().trim();

        //Dados do funcionário
        var dadosFuncionario =
        {
            IdFuncionario: id,
            Nome: nome,
            Telefone: tel,
            Cpf: cpf

        };

        //Dados do endereço
        var dadosEndereco =
        {
            Rua: rua,
            Bairro: bairro,
            Complemento: complemento,
            Cpf: cpf,
            CidadeId: cidade
        }

        //Prepara as informações para serem enviadas em JSON
        var dadosFuncionarioJ = JSON.stringify(dadosFuncionario);
        var dadosEnderecoJ = JSON.stringify(dadosEndereco);

        $.ajax({
            url: "/Funcionario/AlteraFuncionario",
            data: {
                dadosFuncionarioJson: dadosFuncionarioJ
                ,
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