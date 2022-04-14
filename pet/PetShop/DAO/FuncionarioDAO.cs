using DAO.model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAO
{
    public class FuncionarioDAO : _baseDAO
    {
        public int CadastrarFuncionario(TbFuncionario objFuncionario)
        {
            try
            {
                banco.Add(objFuncionario);
                banco.SaveChanges();
                return 1;
            }
            catch
            {
                return -1;
            }
        }
        public int AlterarFuncionario(TbFuncionario objFuncionario)
        {
            try
            {
                TbFuncionario objResgate = banco.TbFuncionario.Include("TbEndereco").Where(f => f.IdFuncionario == objFuncionario.IdFuncionario).FirstOrDefault();


                using (var tran = banco.Database.BeginTransaction())
                {
                    objResgate.Nome = objFuncionario.Nome;
                    objResgate.Telefone = objFuncionario.Telefone;
                    objResgate.Cpf = objFuncionario.Cpf;

                    banco.SaveChanges();

                    objResgate.TbEndereco.FirstOrDefault().Cep = objFuncionario.TbEndereco.FirstOrDefault().Cep;
                    objResgate.TbEndereco.FirstOrDefault().CidadeId = objFuncionario.TbEndereco.FirstOrDefault().CidadeId;
                    objResgate.TbEndereco.FirstOrDefault().Rua = objFuncionario.TbEndereco.FirstOrDefault().Rua;
                    objResgate.TbEndereco.FirstOrDefault().Bairro = objFuncionario.TbEndereco.FirstOrDefault().Bairro;
                    objResgate.TbEndereco.FirstOrDefault().Complemento = objFuncionario.TbEndereco.FirstOrDefault().Complemento;

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

        public List<TbFuncionario> ConsultarFuncionario(int codLogado)
        {
            return banco.TbFuncionario.Where(p => p.IdPetshop == codLogado).ToList();
        }
        public TbFuncionario DetalharFuncionario(int idFuncionario)
        {
            return banco.TbFuncionario.Include("TbEndereco.Cidade").Where(p => p.IdFuncionario == idFuncionario).FirstOrDefault();
        }
    }
}
