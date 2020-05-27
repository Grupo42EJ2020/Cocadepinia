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
    public class TemaController : Controller
    {
       RepositorioTema repoTema = new RepositorioTema();

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult EmpleadosVer(int IdTema)
        {
            return View(repoTema.obtenerTema(IdTema));
        }
        public ActionResult TemaDelete(int IdTema)
        {

            return View(repoTema.obtenerTema(IdTema));
        }

        [HttpPost]
        public ActionResult TemaDelete(int IdTema, FormCollection datos)
        {
            repoTema.eliminarTema(IdTema);

            return RedirectToAction("Index");
        }

        public ActionResult TemaDetails(int IdTema)
        {
            return View(repoTema.obtenerTema(IdTema));
        }

        public ActionResult TemaEdit(int IdTema)
        {
            return View(repoTema.obtenerTema(IdTema));
        }


        [HttpPost]
        public ActionResult TemaEdit(int idTema, Tema datosTema)
        {
            datosTema.IdTema = idTema;
            repoTema.actualizarTema(datosTema);

            return RedirectToAction("Index");
        }

        public ActionResult TemaCreate()
        {

            return View();
        }

        [HttpPost]
        public ActionResult TemaCreate(Tema datos)
        {
            repoTema.insertarTema(datos);
            return RedirectToAction("Index");
        }
    }
}
