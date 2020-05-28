﻿using System;
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
    public class Curso_Tema_VideoController : Controller
    {
        RepositorioCurso_Tema_Video repoCurso_Tema_Video = new  RepositorioCurso_Tema_Video();
    
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Curso_Tema_Video()
        {
            return View(repoCurso_Tema_Video.obtenerCurso_Tema_Video());
        }

        public ActionResult Curso_Tema_VideoDelete(int id)
        {
            return View(repoCurso_Tema_Video.obtenerCurso_Tema_Video(id));
        }

        [HttpPost]
        public ActionResult Curso_Tema_VideoDelete(int id, FormCollection datos)
        {
            repoCurso_Tema_Video.eliminarCurso_Tema_Video(id);

            return RedirectToAction("Index");
        }

        public ActionResult Curso_Tema_VideoDetails(int id)
        {
            return View(repoCurso_Tema_Video.obtenerCurso_Tema_Video(id));
        }
        
        public ActionResult Curso_Tema_VideoEdit(int id)
        {
            return View(repoCurso_Tema_Video.obtenerCurso_Tema_Video(id));
        }
        [HttpPost]
        public ActionResult Curso_Tema_VideoEdit(int id, Curso_Tema_Video datosCurso_Tema_Video)
        {
            datosCurso_Tema_Video.IdCTV = id;
            repoCurso_Tema_Video.actualizarCurso_Tema_Video(datosCurso_Tema_Video);

            return RedirectToAction("Index");
        }

        public ActionResult Curso_Tema_VideoCreate()
        {

            return View();
        }


        [HttpPost]
        public ActionResult Curso_Tema_VideoCreate(Curso_Tema_Video datos)
        {
            repoCurso_Tema_Video.insertarCurso_Tema_Video(datos);
            return RedirectToAction("Index");
        }
    }
}
