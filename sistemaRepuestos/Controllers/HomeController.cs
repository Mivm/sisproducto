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
      
        // este metodo carga la pagina principal con los productos
        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.Titulo = "SISTEMA DE REPUESTOS";
            ViewBag.productos = BBDD.ListarProductos();

            return View();
        }

        // este metodo inserta un producto 
        [HttpPost]
        public ActionResult Index(FormCollection formulario)
        {
            // se obtienen los datos del formulario
            string descripcion = formulario["descripcion"];
            int stock = int.Parse(formulario["stock"]);

            ViewBag.mensaje = BBDD.ingresarProducto(new Producto(descripcion, stock));
            ViewBag.productos = BBDD.ListarProductos();

            return View("index");
        }

        // este metodo elimina un producto
        public ActionResult Eliminar(int id)
        {

            try
            {
                // se busco un producto por la id enviada 
                Producto p = BBDD.buscarProducto(id);

                ViewBag.mensaje = BBDD.eliminarProductos(p);

                ViewBag.Titulo = "SISTEMA DE REPUESTOS";
                ViewBag.productos = BBDD.ListarProductos();
                return View("index");
            }
            catch (Exception e) // si existe un error se le envia al usuario
            {

                ViewBag.mensaje = "Error al eliminar el producto";
                ViewBag.Titulo = "SISTEMA DE REPUESTOS";
                ViewBag.productos = BBDD.ListarProductos();
                return View("index");
   
            }
        
        }

        // Este metodo busca un producto y te retorna a la vista de modificar
        public ActionResult Ver(int id)
        {

            Producto p = BBDD.buscarProducto(id);

            ViewBag.producto = p;

            return View("modificar");
        }

        // este metodo recibe los datos de un formulario y modifica un registro de la base de datos
        [HttpPost]
        public ActionResult Modificar(FormCollection formulario)
        {

            int id = int.Parse(formulario["id"]);
            string descripcion = formulario["descripcion"];
            int stock = int.Parse(formulario["stock"]);

            ViewBag.mensaje = BBDD.modificarProducto(id, descripcion, stock);
            ViewBag.Titulo = "SISTEMA DE REPUESTOS";
            ViewBag.productos = BBDD.ListarProductos();

            return View("index");
        }


    }


}
