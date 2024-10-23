using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Utilidades;

namespace DemoMVC.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {

            return View();
        }

        public ActionResult About() {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact() {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Personas() {
            ViewBag.Message = "Personas page.";
            var lista = new List<Persona>();
            lista.Add(new Persona { Id = 1, Nombre = "Pepito", Apellidos = "Grillo", FechaNacimiento = new DateTime(2000, 1, 2) });
            lista.Add(new Persona { Id = 2, Nombre = "Carmelo", Apellidos = "Coton", FechaNacimiento = new DateTime(2000, 12, 31) });

            return View("Personas", lista);
        }
    }
}