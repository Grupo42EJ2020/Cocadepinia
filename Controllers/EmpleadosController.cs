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
    public class EmpleadosController : Controller
    {
        RepositorioEmpleado repoEmpleado = new RepositorioEmpleado();

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult EmpleadosVer()
        {
            return View(repoEmpleado.obtenerEmpleado());
        }
        public ActionResult EmpleadoDelete(int id)
        {

            return View(repoEmpleado.obtenerEmpleado(id));
        }

        [HttpPost]
        public ActionResult EmpleadoDelete(int id, FormCollection datos)
        {
            repoEmpleado.eliminarEmpleado(id);

            return RedirectToAction("Index");
        }

        public ActionResult EmpleadoDetails(int id)
        {
            return View(repoEmpleado.obtenerEmpleado(id));
        }

        public ActionResult EmpleadoEdit(int id)
        {
            return View(repoEmpleado.obtenerEmpleado(id));
        }


        [HttpPost]
        public ActionResult EmpleadoEdit(int id, Empleado datosEmpleado)
        {
            datosEmpleado.IdEmpleado = id;
            repoEmpleado.actualizarEmpleado(datosEmpleado);

            return RedirectToAction("Index");
        }

        public ActionResult EmpleadoCreate()
        {

            return View();
        }

        [HttpPost]
        public ActionResult EmpleadoCreate(Empleado datos)
        {
            repoEmpleado.insertarEmpleado(datos);
            return RedirectToAction("Index");
        }
    }
}
