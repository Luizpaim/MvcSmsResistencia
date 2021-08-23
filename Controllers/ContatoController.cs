using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MvcSmsResistencia.Models;


namespace MvcSmsResistencia.Controllers
{
    public class ContatoController : Controller
    {
      
        public IActionResult FaleConosco()
        {
            return View();
        }
        [HttpPost]
        public IActionResult FaleConosco(FaleConosco m)
        {
            faleConoscoMetodos msg = new faleConoscoMetodos(); 
            msg.FaleConosco(m);

            ViewBag.Mensagem = "Mensagem Enviada com Sucesso, Entraremos em contato Obrigado !";
            return View();

        }
        public IActionResult Carreira()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Carreira(Carreira c)
        {
            CarreiraMetodos msg = new CarreiraMetodos(); 
            msg.Carreira(c);

            ViewBag.Curriculo = "Seus dados foram enviados com Sucesso, aquarde nosso contato";
            return View();

        }
        
        public IActionResult Localizacao()
        {
            return View();
        }
        public IActionResult Ouvidoria()
        {
            return View();
        }

    }
}