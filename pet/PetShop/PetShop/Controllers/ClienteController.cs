using Microsoft.AspNetCore.Mvc;
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
            return View();
        }
        public IActionResult AlterarCliente()
        {
            PaginaAtual(Paginas.AlterarCliente);
            CarregarEstados();
            return View();
        }

        #endregion

        #region Funções que o Ajax chama

        #endregion

        #region Funções que criam ViewBags

        #endregion

        #region Funções privadas

        #endregion

    }
}
