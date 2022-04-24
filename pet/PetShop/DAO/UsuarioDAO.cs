using DAO.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAO
{
    public class UsuarioDAO : _baseDAO
    {
        public int ValidarAcesso(string email, string senha)
        {
            TbPetshop p = banco.TbPetshop.FirstOrDefault(p => p.Senha == senha && p.Login == email && p.Status == true);
            return p == null ? -1 : p.IdPetshop;
        }
    }
}
