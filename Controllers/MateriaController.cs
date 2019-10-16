using System.Web.Mvc;

namespace simulador_periodos_academicos.Controllers
{
    public class MateriaController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Titulo = "Listagem de Matérias";
            return Json(new { resultado = "" });
        }

        public ActionResult Cadastro(int? id)
        {
            ViewBag.Titulo = "Cadastro de Matéria";
            ViewBag.Id = id;
            return Json(new { nome = "" });
        }
    }
}