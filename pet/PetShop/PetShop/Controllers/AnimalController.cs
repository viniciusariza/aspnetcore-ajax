using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop.Controllers
{
    public class AnimalController : _base
    {
        public IActionResult GerenciarAnimal()
        {
            PaginaAtual(Paginas.GerenciarAnimal);
            return View();
        }
    }
}
