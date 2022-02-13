using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop.Controllers
{
    public class AtendimentoController : _base
    {
        public IActionResult NovoAtendimento()
        {
            PaginaAtual(Paginas.NovoAtendimento);
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
    }
}
