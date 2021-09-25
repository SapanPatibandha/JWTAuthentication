using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebClient.Models;

namespace WebClient.Controllers
{
    public class AccountController : ControlerBase
    {
        public async Task<IActionResult> Login(LoginViewModel model, string returnUrl = null)
        {
            return View();
        }
    }
}
