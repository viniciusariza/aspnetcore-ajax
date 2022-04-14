using System;
using System.Collections.Generic;
using System.Text;

namespace DAO
{
    public class AtendimentoVO
    {
        public string DataAtendimento { get; set; }
        public string Valor { get; set; }
        public string Cliente { get; set; }
        public string Animal { get; set; }
        public string Funcionario { get; set; }
        public string Descricao { get; set; }

        public int IdAtendimento { get; set; }
        public int IdCliente { get; set; }
        public int IdAnimal { get; set; }
        public int IdFuncionario { get; set; }

    }
}
