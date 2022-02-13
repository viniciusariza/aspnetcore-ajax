function CarregarCidades(idEstadoParametro) {
    var comboCidade = $("#cidade");

    $.ajax({
        url: '/Cliente/FiltrarCidadesJS',
        data: {
            idEstado: idEstadoParametro
        },
        success: function (dados) {
            if (dados != "") {
                comboCidade.empty();
                $("<option>").val("").text("Selecione a cidade").appendTo(comboCidade);

                $(dados).each(function () {

                    $("<option>").val(this.id).text(this.nomeCidade).appendTo(comboCidade);

                })
            } else {
                comboCidade.empty();
                $("<option>").val("").text("Estado sem cidade").appendTo(comboCidade);
            }

        }

    })
}