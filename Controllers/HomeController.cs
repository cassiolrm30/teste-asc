using simulador_periodos_academicos.Models;
using simulador_periodos_academicos.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace simulador_periodos_academicos.Controllers
{
    public class HomeController : Controller
    {
        public MateriaRepositorio _materiaRepositorio;

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

        [HttpGet]
        public ActionResult ListarAlunos()
        {
            List<string> resultado = new List<string>();
            resultado.Add("1|ALUNO 1");
            resultado.Add("2|ALUNO 2");
            return new JsonResult { Data = resultado, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }

        [HttpGet]
        public ActionResult ListarMateriasPesosNotas(string alunoId)
        {
            _materiaRepositorio = new MateriaRepositorio(new Contexto());
            IList<Materia> lista = _materiaRepositorio.GetAll();
            List<string> resultado = new List<string>();
            resultado.Add("1|MATÉRIA 1|1|1.5|2");
            resultado.Add("2|MATÉRIA 2|1|2|1");
            resultado.Add("3|MATÉRIA 3|1|1|2");
            return new JsonResult { Data = resultado, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }

        [HttpGet]
        public ActionResult ListarDetalhesNotasAluno(string alunoId)
        {
            List<string> resultado = new List<string>();
            resultado.Add("ALUNO 1");
            resultado.Add("101");
            resultado.Add("MATEMÁTICA|1|10|1|10|1|10|1|10|blue|APROVADO");
            resultado.Add("PORTUGUÊS|1|10|1|10|1|10|1|10|blue|APROVADO");
            resultado.Add("FÍSICA|1|10|1|10|1|10|1|10|blue|APROVADO");
            resultado.Add("QUÍMICA|1|10|1|10|1|10|1|10|blue|APROVADO");
            resultado.Add("HISTÓRIA|1|10|1|10|1|10|1|10|red|REPROVADO");
            resultado.Add("RELIGIÃO|1|10|1|10|1|10|1|10|blue|APROVADO");
            resultado.Add("EDUCAÇÃO FÍSICA|1|10|1|10|1|10|1|10|blue|APROVADO");
            return new JsonResult { Data = resultado, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }
    }
}