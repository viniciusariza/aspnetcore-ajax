using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DAO.model
{
    public partial class TbCidade
    {
        public TbCidade()
        {
            TbEndereco = new HashSet<TbEndereco>();
        }

        public int IdCidade { get; set; }
        public string NomeCidade { get; set; }
        public int EstadoId { get; set; }

        public virtual TbEstado Estado { get; set; }
        public virtual ICollection<TbEndereco> TbEndereco { get; set; }
    }
}
