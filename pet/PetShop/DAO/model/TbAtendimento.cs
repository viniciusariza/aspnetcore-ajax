using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DAO.model
{
    public partial class TbAtendimento
    {
        public int IdAtendimento { get; set; }
        public DateTime DataAtendimento { get; set; }
        public decimal Valor { get; set; }
        public string Descricao { get; set; }
        public int IdPetshop { get; set; }
        public int IdFuncionario { get; set; }
        public int AnimalId { get; set; }
        public int IdCliente { get; set; }

        public virtual TbAnimal Animal { get; set; }
        public virtual TbCliente IdClienteNavigation { get; set; }
        public virtual TbFuncionario IdFuncionarioNavigation { get; set; }
        public virtual TbPetshop IdPetshopNavigation { get; set; }
    }
}
