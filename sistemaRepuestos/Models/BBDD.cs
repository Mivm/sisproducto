using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sistemaRepuestos.Models
{
    public class BBDD{
        private static List<Producto> tablaProductos = new List<Producto> {
            new Producto{Id = 1, Descripcion = "Descripcion1", Stock = 12 },
            new Producto{Id = 2, Descripcion = "Descripcion2", Stock = 10 },
            new Producto{Id = 3, Descripcion = "Descripcion3", Stock = 2 },
            new Producto{Id = 4, Descripcion = "Descripcion4", Stock = 3 }
        };


        public static List<Producto> ListarProductos() {
            var listado = from p in tablaProductos
                          orderby p.Descripcion, p.Stock
                          select p;

            return listado.ToList();

        }


    }
}