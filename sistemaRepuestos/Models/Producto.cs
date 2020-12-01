using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sistemaRepuestos.Models
{
    public class Producto
    {

        private static int generarId; 

        private int _id;

        private string _descripcion;

        private int _stock;

        public Producto()
        {
            this._id = ++generarId; 
        }

        public Producto(string descripcion, int stock)
        {
            this._id = ++generarId;
            this._descripcion = descripcion;
            this._stock = stock;
        }

        public int stock
        {
            get { return _stock; }
            set { _stock = value; }
        }

        public string descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        public int id
        {
            get { return _id; }
        }

    }
}