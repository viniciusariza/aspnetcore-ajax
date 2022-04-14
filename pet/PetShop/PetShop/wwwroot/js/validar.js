function Check(tela) {

    var ret = true;

    switch (tela) {

        case 1://Novo Cliente

            if (
                $("#nome").val().trim() == "" ||
                $("#tel").val().trim() == "" ||
                $("#rua").val().trim() == "" ||
                $("#bairro").val().trim() == "" ||
                $("#cidade").val().trim() == "" ||
                $("#estado").val().trim() == ""
            ) {

                ret = false;
            }
            break;

        case 2://Alterar Cliente
            if ($("#nome").val().trim() == "" || $("#tel").val().trim() == "" || $("#rua").val().trim() == ""
                || $("#cidade").val().trim() == "" || $("#estado").val().trim() == "") {
                ret = false;
            }
            break;

        case 3://Novo Funcionário
            if ($("#nome").val().trim() == "" || $("#tel").val().trim() == "" || $("#rua").val().trim() == ""
                || $("#cpf").val().trim() == "" || $("#cidade").val().trim() == "" || $("#estado").val().trim() == "") {
                ret = false;
            }
            break;

        case 4://Alterar Funcionário
            if ($("#nome").val().trim() == "" || $("#tel").val().trim() == "" || $("#rua").val().trim() == ""
                || $("#cpf").val().trim() == "" || $("#cidade").val().trim() == "" || $("#estado").val().trim() == "") {
                ret = false;
            }
            break;

        case 5://Gerenciar Animal
            if ($("#animal").val().trim() == "" || $("#tipo").val().trim() == "") {
                ret = false;
            }
            break;

        case 6://Novo Atendimento
            if ($("#data").val().trim() == "" || $("#animal").val().trim() == "" || $("#funcionario").val().trim() == "" || $("#valor").val().trim() == "") {
                ret = false;
            }
            break;

        case 7://Alterar Atendimento
            if ($("#data").val().trim() == "" || $("#funcionario").val().trim() == "" || $("#valor").val().trim() == "") {
                ret = false;
            }
            break;
    }

    if (!ret) {
        toastr.warning(RetornaMsg(0));
    }

    return ret;
}