using DAO.model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAO
{
    public class _baseDAO
    {
        public ContextBanco banco;

        public int Inserir<T>(T model)
        {
            try
            {
                banco.Add(model);
                banco.SaveChanges();
                return 1;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public _baseDAO()
        {
            banco = new ContextBanco();
        }

    }
}
