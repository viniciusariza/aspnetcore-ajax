using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DAO.model
{
    public partial class TbAnimal
    {
        public TbAnimal()
        {
            TbAtendimento = new HashSet<TbAtendimento>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public short Tipo { get; set; }
        public int IdPetshop { get; set; }
        public int IdCliente { get; set; }

        public virtual TbCliente IdClienteNavigation { get; set; }
        public virtual TbPetshop IdPetshopNavigation { get; set; }
        public virtual ICollection<TbAtendimento> TbAtendimento { get; set; }
    }
}
