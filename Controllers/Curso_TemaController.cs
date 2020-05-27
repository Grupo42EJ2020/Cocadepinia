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

    }
}
