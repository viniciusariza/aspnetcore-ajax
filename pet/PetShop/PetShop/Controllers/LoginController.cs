using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop.Controllers
{
    public class LoginController : _base
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
