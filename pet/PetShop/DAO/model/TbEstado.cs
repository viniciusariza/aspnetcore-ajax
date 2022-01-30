using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DAO.model
{
    public partial class TbEstado
    {
        public TbEstado()
        {
            TbCidade = new HashSet<TbCidade>();
        }

        public int IdEstado { get; set; }
        public string NomeEstado { get; set; }
        public string SiglaEstado { get; set; }

        public virtual ICollection<TbCidade> TbCidade { get; set; }
    }
}
