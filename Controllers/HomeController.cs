using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace simulador_periodos_academicos.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SimulacaoMedias()
        {
            ViewBag.Titulo = "Simulação de Médias no Período";
            return View();
        }

        [HttpGet]
        public ActionResult DetalhesNotasAluno(string alunoId)
        {
            ViewBag.Titulo = "Detalhes de Notas do Aluno";
            return View();
        }
    }
}