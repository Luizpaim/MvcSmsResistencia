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
    public class IndustriasController  : Controller
    {
        public IActionResult Tratamento()
        {
            return View();
        }
         public IActionResult Cozinha()
        {
            return View();
        }
         public IActionResult Biomedico()
        {
            return View();
        }
         public IActionResult Refrigeracao()
        {
            return View();
        }
         public IActionResult Panificacao()
        {
            return View();
        }
         public IActionResult Embalagem()
        {
            return View();
        }
         public IActionResult Plastico()
        {
            return View();
        }
         public IActionResult Lavanderia()
        {
            return View();
        }
         public IActionResult OleoGas()
        {
            return View();
        }
         public IActionResult Processos()
        {
            return View();
        }
    }
}