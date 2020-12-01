using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sistemaRepuestos.Models
{
    public class BBDD{
        private static List<Producto> tablaProductos = new List<Producto> {
            new Producto("descripcion", 2),
            new Producto("otra descripcion",14)
        };


        public static List<Producto> ListarProductos() {
            var listado = from p in tablaProductos
                          orderby p.descripcion, p.stock
                          select p;

            return listado.ToList();

        }


        //public static String nuevoProducto() { }


    }
}