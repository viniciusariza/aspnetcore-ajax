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
    public class AnimalController : _base
    {

        #region Chama as Páginas
        public IActionResult GerenciarAnimal(string nome, int id)
        {
            PaginaAtual(Paginas.GerenciarAnimal);
            InformacoesCliente(nome, id);
            CarregarAnimaisCliente(id);
            return View();
        }
        #endregion

        #region Funções que criam ViewBags
        private void InformacoesCliente(string nome, int id)
        {
            ViewBag.Cod = id;
            ViewBag.Nome = nome;
        }

        private void CarregarAnimaisCliente(int idCliente)
        {
            ViewBag.Animais = new AnimalDAO().FiltrarAnimalCliente(idCliente);
        }
        #endregion


        #region Funções que o Ajax chama

        public JsonResult ConsultarAnimal(int idCliente)
        {
            return Json(new AnimalDAO().FiltrarAnimalCliente(idCliente));
        }

        public int CadastrarAnimal(string dadosAnimalJson)
        {
            TbAnimal objAnimal = JsonConvert.DeserializeObject<TbAnimal>(dadosAnimalJson);

            //Seta o logado
            objAnimal.IdPetshop = CodigoLogado;

            //Gravar no banco
            AnimalDAO objDao = new AnimalDAO();
            return objDao.CadastrarAnimal(objAnimal);

        }

        public int AlteraAnimal(string dadosAnimalJson)
        {
            TbAnimal objAnimal = JsonConvert.DeserializeObject<TbAnimal>(dadosAnimalJson);

            AnimalDAO objDao = new AnimalDAO();
            return objDao.AlterarAnimal(objAnimal);
        }

        #endregion
    }
}
