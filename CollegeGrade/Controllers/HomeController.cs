using CollegeGrade.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeGrade.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        private static IList<Disciplina> disciplinas =
            new List<Disciplina>()
            {
                new Disciplina()
                {
                    ID = 1,
                    Nome = "Cálculo I",
                    Carga = 60
                },
                new Disciplina()
                {
                    ID = 2,
                    Nome = "Física I",
                    Carga = 60
                },
                new Disciplina()
                {
                    ID = 3,
                    Nome = "Química I",
                    Carga = 60
                },
                new Disciplina()
                {
                    ID = 4,
                    Nome = "Fundamentos da ProgramaçãoI",
                    Carga = 60
                },
            };

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Grade()
        {
            return View(disciplinas);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
