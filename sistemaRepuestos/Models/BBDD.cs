using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sistemaRepuestos.Models
{
    public class BBDD
    {

        // esta es la base de datos 
        private static List<Producto> tablaProductos = new List<Producto> {
            new Producto("descripcion", 2),
            new Producto("otra descripcion",14),
            new Producto("siguiente",25)
        };


        // este metodo lista los productos 
        public static List<Producto> ListarProductos()
        {
            var listado = from p in tablaProductos
                          orderby p.id, p.descripcion, p.stock
                          select p;

            return listado.ToList();

        }

        // este metodo ingresa un producto
        public static String ingresarProducto(Producto p)
        {

            try
            {
                tablaProductos.Add(p); 
                return "Producto insertado";
            }
            catch (Exception e)
            {
                return e.Message;
            }

        }


        // este metodo busca un producto en base a su id
        public static Producto buscarProducto(int id) {
            //Producto producto = (from p in tablaProductos select p.id == id).First(); 

            
            Producto producto = (from p in tablaProductos where p.id == id select p).First();

            return producto; 
        }

        // este metodo elimina productos
        public static String eliminarProductos(Producto p) {

            try
            {

                tablaProductos.Remove(p);

                return "registro eliminado"; 
            }
            catch (Exception e)
            {
                return e.Message; 
            }

        }

        // este metodo recibe los datos de un producto y los modifica
        public static String modificarProducto(int id, string descripcion, int stock) {

            Producto p = buscarProducto(id);

            // valida que el producto no este nulo
            if (p != null) {

                p.descripcion = descripcion;
                p.stock = stock;

                return "Producto modificado";


            }

            return "No se pudo modificar el producto";
        }

    }
}