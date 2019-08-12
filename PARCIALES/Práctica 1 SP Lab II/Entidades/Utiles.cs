using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Utiles
    {
        protected double _precio;
        protected string _marca;

        public abstract double Precio { get; set; }
        public abstract string Marca { get; set; }

        public Utiles(double precio, string marca) {
            this._precio = precio;
            this._marca = marca;
        }

        protected virtual string utilesToString() {
            return "Precio: $" + this._precio + " -- Marca: " + this._marca;
        }
    }
}
