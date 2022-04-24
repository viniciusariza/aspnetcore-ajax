using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAO;

namespace PetShop.Controllers
{
    public class UsuarioController : _base
    {
        public IActionResult Logar()
        {
            return View();
        }

        public IActionResult Deslogar()
        {
            LimparSessao();
            return RedirectToRoute(new { controller = "Usuario", action = "Logar" });
        }

        public IActionResult ValidarAcesso(string email, string senha)
        {
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(senha))
            {
                ViewBag.Ret = 0;
            }
            else
            {
                int cod = new UsuarioDAO().ValidarAcesso(email, senha);
                if (cod == -1)
                {
                    ViewBag.Ret = -2;
                }
                else
                {
                    CodigoLogado = cod;
                    return RedirectToAction("ConsultarCliente", "Cliente");
                }

            }

            return View("Logar");
        }
    }
}
