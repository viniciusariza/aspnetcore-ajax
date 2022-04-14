using DAO;
using DAO.model;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop.Controllers
{
    public class AtendimentoController : _base
    {

        #region Chama as Páginas
        public IActionResult NovoAtendimento(string idNome)
        {
            PaginaAtual(Paginas.NovoAtendimento);
            ClienteSelecionado(idNome);
            CarregarAnimais(Convert.ToInt32(idNome.Split('-')[0]));
            CarregarFuncionarios(CodigoLogado);
            return View();
        }
        public IActionResult ConsultarAtendimento()
        {
            PaginaAtual(Paginas.ConsultarAtendimento);
            return View();
        }
        public IActionResult AlterarAtendimento()
        {
            PaginaAtual(Paginas.AlterarAtendimento);
            return View();
        }
        #endregion

        #region Funções que o AJAX chama

        public int FinalizarAtendimento(string dadosAtendimentoJson)
        {
            TbAtendimento atendimento = JsonConvert.DeserializeObject<TbAtendimento>(dadosAtendimentoJson);
            atendimento.IdPetshop = CodigoLogado;

            return new AtendimentoDAO().Inserir(atendimento);

        }

        public List<AtendimentoVO> RetornaListaAtendimento(DateTime Ini, DateTime Fim)
        {
            AtendimentoDAO objDao = new AtendimentoDAO();
            return objDao.RetornaAtendimento(Ini, Fim, CodigoLogado);

        }

        public JsonResult DetalharAtendimento(int id)
        {
            return Json(new AtendimentoDAO().DetalharAtendimento(id));
        }

        #endregion

        #region Funções que criam ViewBags
        private void CarregarAnimais(int idCliente)
        {
            ViewBag.Animais = new AnimalDAO().FiltrarAnimalCliente(idCliente);
        }

        private void CarregarFuncionarios(int cod)
        {
            ViewBag.Funcionarios = new FuncionarioDAO().ConsultarFuncionario(cod);
        }

        private void ClienteSelecionado(string idNome)
        {
            ViewBag.Id = Convert.ToInt32(idNome.Split('-')[0]);
            ViewBag.NomeCliente = idNome.Split('-')[1];
        }

        #endregion
    }
}
