using DAO.model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAO
{
    public class ClienteDAO : _baseDAO
    {
        public int CadastrarCliente(TbCliente objCliente)
        {
            try
            {
                banco.Add(objCliente);
                banco.SaveChanges();

                return 1;
            }
            catch
            {

                return -1;
            }
        }

        public int AlterarCliente(TbCliente objCliente)
        {
            try
            {
                TbCliente objResgate = banco.TbCliente.Include("TbEndereco").Where(cliente => cliente.IdCliente == objCliente.IdCliente).FirstOrDefault();


                using (var tran = banco.Database.BeginTransaction())
                {
                    objResgate.Nome = objCliente.Nome;
                    objResgate.Telefone = objCliente.Telefone;

                    banco.SaveChanges();

                    objResgate.TbEndereco.FirstOrDefault().Cep = objCliente.TbEndereco.FirstOrDefault().Cep;
                    objResgate.TbEndereco.FirstOrDefault().CidadeId = objCliente.TbEndereco.FirstOrDefault().CidadeId;
                    objResgate.TbEndereco.FirstOrDefault().Rua = objCliente.TbEndereco.FirstOrDefault().Rua;
                    objResgate.TbEndereco.FirstOrDefault().Bairro = objCliente.TbEndereco.FirstOrDefault().Bairro;
                    objResgate.TbEndereco.FirstOrDefault().Complemento = objCliente.TbEndereco.FirstOrDefault().Complemento;

                    banco.SaveChanges();

                    tran.Commit();
                }
                return 1;
            }
            catch
            {
                return -1;
            }
        }
        public List<TbCliente> ConsultarCliente(int codLogado)
        {
            return banco.TbCliente.Where(p => p.IdPetshop == codLogado).Take(20).ToList();
        }

        public List<TbCliente> ConsultarClienteLinq(int codLogado)
        {
            List<TbCliente> lst = (from clientes in banco.TbCliente where clientes.IdPetshop == codLogado select clientes).ToList();
            return lst;
        }

        public TbCliente DetalharCliente(int idCliente)
        {
            return banco.TbCliente.Include("TbEndereco.Cidade").Where(p => p.IdCliente == idCliente).FirstOrDefault();
        }

        public List<TbCliente> FiltrarCliente(int codLogado, string filtro)
        {
            List<TbCliente> lstCliente;
            if (filtro == null)
            {
                lstCliente = banco.TbCliente.Where(c => c.IdPetshop == codLogado).Take(20).ToList();
            }
            else
            {
                lstCliente = banco.TbCliente.Where(c => c.IdPetshop == codLogado && c.Nome.Contains(filtro)).ToList();
            }

            return lstCliente;
        }
    }
}
