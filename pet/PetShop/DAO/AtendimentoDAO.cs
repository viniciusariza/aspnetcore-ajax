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
        public TbAtendimento DetalharAtendimento(int id)
        {
            return banco.TbAtendimento.FirstOrDefault(a => a.IdAtendimento == id);
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
    }
}
