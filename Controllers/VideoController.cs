using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCLaboratorio.Models;

namespace MVCLaboratorio.Controllers
{
    public class VideoController : Controller
    {
        Repositoriovideo repoVideo = new Repositoriovideo();
        
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult VideosVer()
        {
            return View(repoVideo.obtenerVideos());
        }

        public ActionResult VideoDelete(int id)
        {
            
            return View(repoVideo.obtenerVideo(id));
        }
        [HttpPost]
        public ActionResult VideoDelete(int id, FormCollection datos)
        {
            
            repoVideo.eliminarVideo(id);

            return RedirectToAction("VideosVer");
        }

        public ActionResult VideoDetails(int id)
        {
            return View(repoVideo.obtenerVideo(id));
        }

        public ActionResult VideoEdit(int id)
        {
            return View(repoVideo.obtenerVideo(id));
        }
        [HttpPost]
        public ActionResult VideoEdit(int id, Video datosVideo)
        {
            datosVideo.IdVideo = id;
            repoVideo.actualizarVideo(datosVideo);

            return RedirectToAction("VideosVer");
        }

        public ActionResult VideoCreate()
        {
            
            return View();
        }
        [HttpPost]
        public ActionResult VideoCreate(Video datos)
        {
            repoVideo.insertarVideo(datos);
            return RedirectToAction("VideosVer");
        }

    }
}
