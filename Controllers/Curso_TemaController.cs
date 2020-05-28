using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using System.Data;
using MVCLaboratorio.Utilerias;
using MVCLaboratorio.Models;

namespace MVCLaboratorio.Controllers
{
    public class Curso_TemaController : Controller
    {
        //
        // GET: /Curso_Tema/
        RepositorioCurso_Tema repoCurso_Tema = new RepositorioCurso_Tema();


        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Curso_TemaDetails()
        {
            return View(repoCurso_Tema.obtenerCurso_Temas());
        }
        public ActionResult Curso_TemaDelete(int id)
        {

            return View(repoCurso_Tema.obtenerCurso_Tema(id));
        }

        [HttpPost]
        public ActionResult Curso_TemaDelete(int id, FormCollection datos)
        {
            repoCurso_Tema.eliminarCurso_Tema(id);

            return RedirectToAction("Curso_TemaDetails");
        }

        public ActionResult Curso_TemaDetail(int id)
        {
            return View(repoCurso_Tema.obtenerCurso_Tema(id));
        }

        public ActionResult Curso_TemaEdit(int id)
        {
            return View(repoCurso_Tema.obtenerCurso_Tema(id));
        }


        [HttpPost]
        public ActionResult Curso_TemaEdit(int id, Curso_Tema datosCurso_Tema)
        {
            datosCurso_Tema.IdCT = id;
            repoCurso_Tema.actualizarCurso_Tema(datosCurso_Tema);

            return RedirectToAction("Curso_TemaDetails");
        }

        public ActionResult Curso_TemaCreate()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Curso_TemaCreate(Curso_Tema datos)
        {
            repoCurso_Tema.insertarCurso_Tema(datos);
            return RedirectToAction("Curso_TemaDetails");
        }
    }
}
