using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop.Controllers
{
    public class FuncionarioController : _base
    {
        public IActionResult NovoFuncionario()
        {
            PaginaAtual(Paginas.NovoFuncionario);
            return View();
        }
        public IActionResult ConsultarFuncionario()
        {
            PaginaAtual(Paginas.ConsultarFuncionario);
            return View();
        }
        public IActionResult AlterarFuncionario()
        {
            PaginaAtual(Paginas.AlterarFuncionario);
            return View();
        }
    }
}
