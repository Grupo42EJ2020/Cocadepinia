using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCLaboratorio.Models;

namespace MVCLaboratorio.Controllers
{
    public class CursosController : Controller
    {

        RepositorioCursos repoCurso = new RepositorioCursos();
        //
        // GET: /Cursos/

        public ActionResult Index()
        {
            return View(repoCurso.obtenerCurso());
        }

        //
        // GET: /Cursos/Details/5

        public ActionResult CursosDetails(int id)
        {
            return View(repoCurso.obtenerCurso(id));
        }

        //
        // GET: /Cursos/Create

        public ActionResult CursosCreate()
        {
            return View();
        } 

        //
        // POST: /Cursos/Create

        [HttpPost]
        public ActionResult CursosCreate(Cursos datos)
        {
            try
            {
                repoCurso.insertarCurso(datos);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        
        //
        // GET: /Cursos/Edit/5
 
        public ActionResult CursosEdit(int id)
        {
            
            return View(repoCurso.obtenerCurso(id));
        }

        //
        // POST: /Cursos/Edit/5

        [HttpPost]
        public ActionResult CursosEdit(int id, Cursos datosCursos)
        {
            try
            {
                datosCursos.IdCursos = id;
                repoCurso.actualizarCurso(datosCursos);
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Cursos/Delete/5
 
        public ActionResult CursosDelete(int id)
        {
            return View(repoCurso.obtenerCurso(id));
        }

        //
        // POST: /Cursos/Delete/5

        [HttpPost]
        public ActionResult CursosDelete(int id, FormCollection collection)
        {
            try
            {
                repoCurso.eliminarCurso(id);
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
