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

        [HttpGet]
        public ActionResult Index(){
           ViewBag.Titulo = "SISTEMA DE REPUESTOS";
           ViewBag.productos = BBDD.ListarProductos(); 
           
           return View();
        }

        [HttpPost]
        public ActionResult Index(FormCollection formulario) {

            string descripcion = formulario["descripcion"];
            int stock = int.Parse(formulario["stock"]);

            ViewBag.productos = BBDD.ListarProductos();
            ViewBag.respuesta = BBDD.ingresarProducto(new Producto(descripcion, stock));

            return View();
        }


 
        } 


    }
