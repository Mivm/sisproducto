using sistemaRepuestos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace sistemaRepuestos.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index(){
            ViewBag.Titulo = "SISTEMA DE REPUESTOS";

            return View();
           //return Content(BBDD.ListarProductos()[0].Descripcion);
        }
    }
}