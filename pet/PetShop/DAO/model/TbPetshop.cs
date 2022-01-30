using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DAO.model
{
    public partial class TbPetshop
    {
        public TbPetshop()
        {
            TbAnimal = new HashSet<TbAnimal>();
            TbAtendimento = new HashSet<TbAtendimento>();
            TbCliente = new HashSet<TbCliente>();
            TbFuncionario = new HashSet<TbFuncionario>();
        }

        public int IdPetshop { get; set; }
        public string Nome { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public bool Status { get; set; }

        public virtual ICollection<TbAnimal> TbAnimal { get; set; }
        public virtual ICollection<TbAtendimento> TbAtendimento { get; set; }
        public virtual ICollection<TbCliente> TbCliente { get; set; }
        public virtual ICollection<TbFuncionario> TbFuncionario { get; set; }
    }
}
