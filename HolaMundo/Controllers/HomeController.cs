using HolaMundo.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HolaMundo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            ViewBag.TituloPeli = "Pelicula Estrenada";

            var peliculasServices = new PeliculasServices();
            var model = peliculasServices.ObtenerPeliculas();

            return View(model);
        }

        [HttpGet]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            ViewBag.unInt = 45;
            ViewBag.unaFecha = new DateTime(2021, 03, 24);
            ViewData["Mensaje"] = "Esto es una prueba de viewdata";

            return View();
        }
        [HttpPost]
        public ActionResult Contact(int edad)
        {
            ViewBag.Message = "Your contact page." + "tu edad post: " + edad;
            ViewBag.unInt = 45;
            ViewBag.unaFecha = new DateTime(2021, 03, 24);
            ViewData["Mensaje"] = "Esto es una prueba de viewdata post";

            return View();
        }
    }
}