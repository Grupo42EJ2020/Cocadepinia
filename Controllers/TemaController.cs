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
        public ActionResult TemaVer()
        {
            return View(repoTema.obtenerTema());
        }
        public ActionResult TemaDelete(int id)
        {

            return View(repoTema.obtenerTema(id));
        }

        [HttpPost]
        public ActionResult TemaDelete(int id, FormCollection datos)
        {
            repoTema.eliminarTema(id);

            return RedirectToAction("TemaVer");
        }

        public ActionResult TemaDetails(int id)
        {
            return View(repoTema.obtenerTema(id));
        }

        public ActionResult TemaEdit(int id)
        {
            return View(repoTema.obtenerTema(id));
        }


        [HttpPost]
        public ActionResult TemaEdit(int id, Tema datosTema)
        {
            datosTema.IdTema = id;
            repoTema.actualizarTema(datosTema);

            return RedirectToAction("TemaVer");
        }

        public ActionResult TemaCreate()
        {

            return View();
        }

        [HttpPost]
        public ActionResult TemaCreate(Tema datos)
        {
            repoTema.insertarTema(datos);
            return RedirectToAction("TemaVer");
        }
    }
}
