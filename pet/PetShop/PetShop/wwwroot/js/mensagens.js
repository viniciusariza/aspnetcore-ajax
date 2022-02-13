function RetornaMsg(n) {

    var msg = '';

    switch (n) {
        case 0:
            msg = "Preencher todos os campos!";
            break;
        case -1:
            msg = "Ação relaizada com sucesso!";
            break;
        case 1:
            msg = "Ocorreu um erro, tente mais tarde!";
            break;
    }
    
    return msg;
}