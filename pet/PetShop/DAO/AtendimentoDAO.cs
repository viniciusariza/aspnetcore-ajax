using DAO.model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAO
{
    public class AtendimentoDAO : _baseDAO
    {
        public AtendimentoVO DetalharAtendimento(int id)
        {
            TbAtendimento atendimento = banco.TbAtendimento.Include("Animal").Include("IdClienteNavigation").Include("IdFuncionarioNavigation").Where(a => a.IdAtendimento == id).FirstOrDefault();

            AtendimentoVO vo = new AtendimentoVO();
            vo.Animal = atendimento.Animal.Nome;
            vo.Cliente = atendimento.IdClienteNavigation.Nome;
            vo.Funcionario = atendimento.IdFuncionarioNavigation.Nome;
            vo.DataAtendimento = atendimento.DataAtendimento.ToShortDateString();
            vo.Valor = atendimento.Valor.ToString();
            vo.Descricao = atendimento.Descricao;
            vo.IdAtendimento = atendimento.IdAtendimento;
            vo.IdFuncionario = atendimento.IdFuncionarioNavigation.IdFuncionario;
            vo.IdAnimal = atendimento.Animal.Id;
            vo.IdCliente = atendimento.IdCliente;
            return vo;
        }

        public List<AtendimentoVO> RetornaAtendimento(DateTime inicio, DateTime fim, int IdPetshop)
        {
            List<AtendimentoVO> Ret = new List<AtendimentoVO>();
            List<TbAtendimento> lst = banco.TbAtendimento.Include("Animal").Include("IdClienteNavigation").Include("IdFuncionarioNavigation").Where(l => l.IdPetshop == IdPetshop && l.DataAtendimento >= inicio && l.DataAtendimento <= fim).ToList();

            for (int i = 0; i < lst.Count; i++)
            {
                AtendimentoVO vo = new AtendimentoVO();
                vo.Animal = lst[i].Animal.Nome;
                vo.Cliente = lst[i].IdClienteNavigation.Nome;
                vo.Funcionario = lst[i].IdFuncionarioNavigation.Nome;
                vo.DataAtendimento = lst[i].DataAtendimento.ToShortDateString();
                vo.Valor = lst[i].Valor.ToString("C2");
                vo.Descricao = lst[i].Descricao;
                vo.IdAtendimento = lst[i].IdAtendimento;

                Ret.Add(vo);
            }
            return Ret;
        }

        public int AlterarAtendimento(TbAtendimento objAtendimento)
        {
            try
            {
                TbAtendimento objResgate = banco.TbAtendimento.Where(a => a.IdAtendimento == objAtendimento.IdAtendimento).FirstOrDefault();

                objResgate.DataAtendimento = objAtendimento.DataAtendimento;
                objResgate.AnimalId = objAtendimento.AnimalId;
                objResgate.IdFuncionario = objAtendimento.IdFuncionario;
                objResgate.Valor = objAtendimento.Valor;
                objResgate.Descricao = objAtendimento.Descricao;

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
