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
    public class ClienteController : _base
    {
        #region Chamar Páginas
        public IActionResult NovoCliente()
        {
            PaginaAtual(Paginas.NovoCliente);
            CarregarEstados();
            return View();
        }
        public IActionResult ConsultarCliente()
        {
            PaginaAtual(Paginas.ConsultarCliente);
            CarregarClientes();
            return View();
        }
        public IActionResult AlterarCliente(int id)
        {
            PaginaAtual(Paginas.AlterarCliente);
            TbCliente objCliente = new ClienteDAO().DetalharCliente(id);
            CarregarEstados();
            CarregarCidades(objCliente.TbEndereco.FirstOrDefault().Cidade.EstadoId);
            return View(objCliente);
        }

        #endregion

        #region Funções que o Ajax chama
        public int CadastrarCliente(string dadosClienteJson, string dadosEnderecoJson)
        {
            TbCliente objCliente = JsonConvert.DeserializeObject<TbCliente>(dadosClienteJson);
            TbEndereco objEndereco = JsonConvert.DeserializeObject<TbEndereco>(dadosEnderecoJson);

            //Seta o logado
            objCliente.IdPetshop = CodigoLogado;

            //Add endereço do cliente
            objCliente.TbEndereco.Add(objEndereco);

            //Gravar no banco
            ClienteDAO objDao = new ClienteDAO();
            return objDao.CadastrarCliente(objCliente);

        }

        public int AlteraCliente(string dadosClienteJson, string dadosEnderecoJson)
        {
            TbCliente objCliente = JsonConvert.DeserializeObject<TbCliente>(dadosClienteJson);
            TbEndereco objEndereco = JsonConvert.DeserializeObject<TbEndereco>(dadosEnderecoJson);

            //Add endereço do cliente
            objCliente.TbEndereco.Add(objEndereco);

            //Alterar no banco
            ClienteDAO objDao = new ClienteDAO();
            return objDao.AlterarCliente(objCliente);

        }

        public List<TbCliente> FiltrarCliente(string filtro)
        {
            ClienteDAO objDao = new ClienteDAO();
            return objDao.FiltrarCliente(CodigoLogado, filtro);
        }

        #endregion

        #region Funções que criam ViewBags
        private void CarregarClientes()
        {
            ViewBag.ListarClientes = new ClienteDAO().ConsultarCliente(CodigoLogado);
        }

        private void CarregarCidades(int idEstado)
        {
            ViewBag.ListaCidades = new GeralDAO().FiltrarCidades(idEstado);
        }
        #endregion

        #region Funções privadas

        #endregion

    }
}
