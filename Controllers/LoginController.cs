using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExemploLogin.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ExemploLogin.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Autenticar(Usuario usuario)
        {
            usuario.Nome = "Usuário Teste";
            HttpContext.Session.SetString("Usuario", JsonConvert.SerializeObject(usuario)); // salva objeto como json
            HttpContext.Session.Remove("notificacao"); // Limpa notificação
            return Redirect("/Home");
        }

    }
}