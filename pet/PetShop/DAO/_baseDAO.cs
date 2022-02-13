using DAO.model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAO
{
    public class _baseDAO
    {
        public ContextBanco banco;
        public _baseDAO()
        {
            banco = new ContextBanco();
        }

    }
}
