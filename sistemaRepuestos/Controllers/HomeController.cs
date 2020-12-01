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
           ViewBag.productos = BBDD.ListarProductos(); 
           
           return View();
        }

        public ActionResult Nuevo() {
            return View(); 
        }

    }
}