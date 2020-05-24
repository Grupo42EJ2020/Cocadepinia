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
            return View();
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
        public ActionResult CursosCreate(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

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
            return View();
        }

        //
        // POST: /Cursos/Edit/5

        [HttpPost]
        public ActionResult CursosEdit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
 
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
            return View();
        }

        //
        // POST: /Cursos/Delete/5

        [HttpPost]
        public ActionResult CursosDelete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
