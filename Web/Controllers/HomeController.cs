using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View();

        public IActionResult Containers() => View();

        public IActionResult QuebraAutomatica() => View();

        public IActionResult AlinhamentoVertical() => View();

        public IActionResult AlinhamentoHorizontal() => View();

        public IActionResult Aninhamento() => View();
    }
}