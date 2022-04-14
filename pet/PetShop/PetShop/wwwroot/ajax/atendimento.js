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
                var colunas = '<thead><tr><th>Ação</th><th>Data</th><th>Cliente</th><th>Animal</th><th>Funcionário</th><th>Valor</th><th>Descrição</th></tr></thead><tbody>';
                var linha = '';

                $(atendimentos).each(function () {
                    linha += '<tr>';
                    linha += '<td>';
                    linha += '<a href="/Atendimento/AlterarAtendimento?id=' + this.idAtendimento + '" class="btn btn-warning btn-xs">Alterar</a>';
                    linha += '</td>';
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
                    linha += this.descricao;
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