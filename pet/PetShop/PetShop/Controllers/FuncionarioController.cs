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
    public class FuncionarioController : _base
    {
        #region Chamar Páginas
        public IActionResult NovoFuncionario()
        {
            PaginaAtual(Paginas.NovoFuncionario);
            CarregarEstados();
            return View();
        }
        public IActionResult ConsultarFuncionario()
        {
            PaginaAtual(Paginas.ConsultarFuncionario);
            CarregarFuncionarios();
            return View();
        }
        public IActionResult AlterarFuncionario(int id)
        {
            PaginaAtual(Paginas.AlterarFuncionario);
            TbFuncionario objFuncionario = new FuncionarioDAO().DetalharFuncionario(id);
            CarregarEstados();
            CarregarCidades(objFuncionario.TbEndereco.FirstOrDefault().Cidade.EstadoId);
            return View(objFuncionario);
        }
        #endregion

        #region Funções que o Ajax Chama
        public int CadastrarFuncionario(string dadosFuncionarioJson, string dadosEnderecoJson)
        {
            TbFuncionario objFuncionario = JsonConvert.DeserializeObject<TbFuncionario>(dadosFuncionarioJson);
            TbEndereco objEndereco = JsonConvert.DeserializeObject<TbEndereco>(dadosEnderecoJson);

            //Seta o logado
            objFuncionario.IdPetshop = CodigoLogado;

            //Add o endereço do cliente
            objFuncionario.TbEndereco.Add(objEndereco);

            FuncionarioDAO objDao = new FuncionarioDAO();

            return objDao.CadastrarFuncionario(objFuncionario);
        }

        public int AlteraFuncionario(string dadosFuncionarioJson, string dadosEnderecoJson)
        {


            TbFuncionario objFuncionario = JsonConvert.DeserializeObject<TbFuncionario>(dadosFuncionarioJson);
            TbEndereco objEndereco = JsonConvert.DeserializeObject<TbEndereco>(dadosEnderecoJson);

            //Add endereço do funcionário
            objFuncionario.TbEndereco.Add(objEndereco);

            //Alterar no banco
            FuncionarioDAO objDao = new FuncionarioDAO();
            return objDao.AlterarFuncionario(objFuncionario);

        }
        #endregion

        #region Funções que criam ViewBags
        private void CarregarFuncionarios()
        {
            ViewBag.ListarFuncionarios = new FuncionarioDAO().ConsultarFuncionario(CodigoLogado);
        }
        private void CarregarCidades(int idEstado)
        {
            ViewBag.ListaCidadesFuncionario = new GeralDAO().FiltrarCidades(idEstado);
        }
        #endregion

    }
}
