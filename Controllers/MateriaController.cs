using simulador_periodos_academicos.Models;
using simulador_periodos_academicos.Repositories;
using System.Web.Mvc;

namespace simulador_periodos_academicos.Controllers
{
    public class MateriaController : Controller
    {
        public readonly MateriaRepositorio _repositorio;

        public MateriaController(MateriaRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public ActionResult Index()
        {
            ViewBag.Titulo = "Listagem de Matérias";
            return View();
        }

        public ActionResult Cadastro(int id)
        {
            ViewBag.Titulo = "Cadastro de Matéria";
            Materia materia = new Materia();
            if (id != 0)
                materia = _repositorio.Get(id);
            return View(materia);
        }
    }
}