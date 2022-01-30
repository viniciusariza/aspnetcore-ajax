using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DAO.model
{
    public partial class TbEndereco
    {
        public int Id { get; set; }
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public string Complemento { get; set; }
        public string Cep { get; set; }
        public int CidadeId { get; set; }
        public int? IdFuncionario { get; set; }
        public int? IdCliente { get; set; }

        public virtual TbCidade Cidade { get; set; }
        public virtual TbCliente IdClienteNavigation { get; set; }
        public virtual TbFuncionario IdFuncionarioNavigation { get; set; }
    }
}
