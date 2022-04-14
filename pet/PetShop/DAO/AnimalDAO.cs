using DAO.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAO
{
    public class AnimalDAO : _baseDAO
    {
        public List<TbAnimal> FiltrarAnimalCliente(int idCliente)
        {
            return banco.TbAnimal.Where(a => a.IdCliente == idCliente).ToList();
        }

        public int CadastrarAnimal(TbAnimal objAnimal)
        {
            try
            {
                banco.Add(objAnimal);
                banco.SaveChanges();

                return 1;
            }
            catch
            {

                return -1;
            }
        }

        public int AlterarAnimal(TbAnimal objAnimal)
        {
            try
            {
                TbAnimal objResgate = banco.TbAnimal.Where(a => a.Id == objAnimal.Id).FirstOrDefault();

                objResgate.Nome = objAnimal.Nome;
                objResgate.Tipo = objAnimal.Tipo;

                banco.SaveChanges();

                return 1;
            }
            catch
            {

                return -1;
            }
        }
    }
}
