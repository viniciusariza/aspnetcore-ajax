using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DAO.model
{
    public partial class TbCliente
    {
        public TbCliente()
        {
            TbAnimal = new HashSet<TbAnimal>();
            TbAtendimento = new HashSet<TbAtendimento>();
            TbEndereco = new HashSet<TbEndereco>();
        }

        public int IdCliente { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public int IdPetshop { get; set; }

        public virtual TbPetshop IdPetshopNavigation { get; set; }
        public virtual ICollection<TbAnimal> TbAnimal { get; set; }
        public virtual ICollection<TbAtendimento> TbAtendimento { get; set; }
        public virtual ICollection<TbEndereco> TbEndereco { get; set; }
    }
}
