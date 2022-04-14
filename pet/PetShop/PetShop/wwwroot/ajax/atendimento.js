function CarregarModalAlterar(id) {

    var comboAnimal = $("#animal");

    $.ajax({
        url: "/Atendimento/DetalharAtendimento",
        data: {
            id: id
        },
        success: function (ret) {

            function adicionaZero(numero) {
                if (numero <= 9)
                    return "0" + numero;
                else
                    return numero;
            }
            var data = (new Date(ret.dataAtendimento));
            var dataFormatada = (data.getFullYear() + "-" + adicionaZero(data.getDate()).toString() + "-" + (adicionaZero(data.getMonth() + 1).toString()));

            $("#cod").val(id);
            $("#cliente").val(ret.cliente);
            $("#data").val(dataFormatada);
            $("#funcionario").val(ret.idFuncionario);
            $("#valor").val(ret.valor.replace(',','.'));
            $("#descricao").val(ret.descricao);

            var codAnimal = ret.idAnimal;

            $.ajax({
                url: "/Atendimento/FiltrarAnimaisCliente",
                data: {
                    idCliente: ret.idCliente
                },
                success: function (retAnimais) {

                    comboAnimal.empty();
                    $(retAnimais).each(function () {

                        if (this.id == codAnimal) {
                            $("<option selected>").val(this.id).text(this.nome).appendTo(comboAnimal);
                        } else {
                            $("<option>").val(this.id).text(this.nome).appendTo(comboAnimal);
                        }
                    })
                }
            })
        }
    })
};

function AlterarAtendimento() {

    if (Check(7)) {

        var atendimento = $("#cod").val().trim();
        var data = $("#data").val().trim();
        var animal = $("#animal").val().trim();
        var funcionario = $("#funcionario").val().trim();
        var valor = $("#valor").val().trim();
        var descricao = $("#descricao").val().trim();

        var dadosAtendimento =
        {
            IdAtendimento: atendimento,
            DataAtendimento: data,
            AnimalId: animal,
            IdFuncionario: funcionario,
            Valor: valor,
            Descricao: descricao
        };


        var dadosAtendimentoJ = JSON.stringify(dadosAtendimento);

        $.ajax({
            url: "/Atendimento/AlteraAtedimento",
            data: {
                dadosAtendimentoJson: dadosAtendimentoJ
            },
            success: function (ret) {
                if (ret == 1) {
                    toastr.success(RetornaMsg(1));
                    ListarAtendimentos();
                    $('#modal-alterar').modal('hide');
                } else {
                    toastr.error(RetornaMsg(-1));
                }

            }
        })
    }
}

function NovoAtendimento() {

    if (Check(6)) {

        var data = $("#data").val().trim();
        var valor = $("#valor").val().trim();
        var animal = $("#animal").val().trim();
        var funcionario = $("#funcionario").val().trim();
        var descricao = $("#descricao").val().trim();
        var cliente = $("#cod").val().trim();

        //Dados do atendimento
        var dadosAtendimento =
        {
            DataAtendimento: data,
            Valor: valor,
            AnimalId: animal,
            IdFuncionario: funcionario,
            Descricao: descricao,
            IdCliente: cliente

        };

        //Prepara as informações para serem enviadas em JSON
        var dadosAtendimentoJ = JSON.stringify(dadosAtendimento);

        $.ajax({
            url: "/Atendimento/FinalizarAtendimento",
            data: {
                dadosAtendimentoJson: dadosAtendimentoJ
            },
            success: function (ret) {
                if (ret == 1) {
                    toastr.success(RetornaMsg(1));
                    setTimeout(function () {
                        window.location = '/Cliente/ConsultarCliente';
                    }, 2000);
                } else {
                    toastr.error(RetornaMsg(-1));
                }

            }

        })
    }
}

function ListarAtendimentos() {
    var Inicial = $('#dataInicial').val().trim();
    var Final = $('#dataFinal').val().trim();

    $.ajax({
        url: '/Atendimento/RetornaListaAtendimento',
        data: {
            Ini: Inicial,
            Fim: Final
        },
        success: function (atendimentos) {
            if (atendimentos != "") {
                var tabelaInicial = '<table class="table table-hover">';
                var colunas = '<thead><tr><th>Data</th><th>Cliente</th><th>Animal</th><th>Funcionário</th><th>Valor</th><th>Ação</th></tr></thead><tbody>';
                var linha = '';

                $(atendimentos).each(function () {
                    linha += '<tr>';
                    linha += '<td>';
                    linha += this.dataAtendimento;
                    linha += '</td>';
                    linha += '<td>';
                    linha += this.cliente;
                    linha += '</td>';
                    linha += '<td>';
                    linha += this.animal;
                    linha += '</td>';
                    linha += '<td>';
                    linha += this.funcionario;
                    linha += '</td>';
                    linha += '<td>';
                    linha += this.valor;
                    linha += '</td>';
                    linha += '<td>';
                    linha += '<a class="btn btn-warning btn-xs" data-toggle="modal" data-target="#modal-alterar" onclick="CarregarModalAlterar(' + this.idAtendimento + ')" >Alterar</a>';
                    linha += '</td>';
                    linha += '</tr>';
                });

                var tabelaFinal = '</tbody></table>';
                var tabelaCompleta = tabelaInicial + colunas + linha + tabelaFinal;
                $("#tabelaAtendimento").html(tabelaCompleta);
                $("#divResultado").show();
            } else {
                $("#divResultado").hide();
            }
        }
    })
}