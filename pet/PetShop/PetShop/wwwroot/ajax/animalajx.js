function LimparCampos() {
    $("#animal").val('');
    $("#tipo").val('');
}

function ConsultarAnimal() {
    var id = $("#cod").val();

    $.ajax({
        url: '/Animal/ConsultarAnimal',
        data: {
            idCliente: id
        },
        success: function (dados) {
            var tabelaInicial = '<table class="table table-hover">';
            var colunas = '<thead><tr><th>Ação</th><th>Animal</th><th>Tipo</th></tr></thead>';
            var linha = '';

            $(dados).each(function () {
                linha += '<tr>';

                linha += '<td>';
                linha += ' <input type="hidden" id="id_animal_' + this.id + '" value="' + this.id + '" />';
                linha += '<button class="btn btn-warning btn-xs" onclick="AlterarAnimal(' + this.id + ')" > Alterar</button >';
                linha += '</td >';

                linha += '<td>';
                linha += '<input class="form-control" id="nome_animal_' + this.id + '" value="' + this.nome + '" />';
                linha += '</td>';

                linha += '<td>';
                linha += ' <select class="form-control" id="tipo_alterar_' + this.id + '">';
                linha += '<option value="1"' + (this.tipo == 1 ? 'selected' : '') + ' >Cachorro</option >';
                linha += '<option value="2"' + (this.tipo == 2 ? 'selected' : '') + ' > Gato</option >';
                linha += '</select > ';
                linha += '</td>';

                linha += '</tr>';
            });

            var table_final = '</tbody></table>';

            var tabela_completa = tabelaInicial + colunas + linha + table_final;
            $("#tabelaAnimal").html(tabela_completa);
        }
    })
}

function CadastrarAnimal() {

    if (Check(5)) {

        var cod = $("#cod").val().trim();
        var animal = $("#animal").val().trim();
        var tipo = $("#tipo").val().trim();

        //Dados do animal
        var dadosAnimal =
        {
            Nome: animal,
            Tipo: tipo,
            IdCliente: cod
        };

        //Prepara as informações para serem enviadas em JSON
        var dadosAnimalJ = JSON.stringify(dadosAnimal);

        $.ajax({
            url: "/Animal/CadastrarAnimal",
            data: {
                dadosAnimalJson: dadosAnimalJ
            },
            success: function (ret) {
                if (ret == 1) {
                    toastr.success(RetornaMsg(1));
                    ConsultarAnimal();
                    LimparCampos();
                } else {
                    toastr.error(RetornaMsg(-1));
                }

            }

        })

    }
}

function AlterarAnimal(id) {

    var id = $("#id_animal_" + id).val();
    var nome = $("#nome_animal_" + id).val().trim();
    var tipo = $("#tipo_alterar_" + id).val();

    if (nome != "") {

        //Dados do animal
        var dadosAnimal = {
            Id: id,
            Nome: nome,
            Tipo: tipo
        };

        //Preparar informações

        var dadosAnimalJ = JSON.stringify(dadosAnimal);

        $.ajax({
            url: '/Animal/AlteraAnimal',
            data: {
                dadosAnimalJson: dadosAnimalJ
            },
            success: function (ret) {
                if (ret == 1) {
                    toastr.success(RetornaMsg(1));
                } else {
                    toastr.error(RetornaMsg(-1));
                }
            }
        })
    } else {
        toastr.warning(RetornaMsg(0));
    }
}