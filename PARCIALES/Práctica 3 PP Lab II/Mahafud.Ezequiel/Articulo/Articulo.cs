using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticuloNS
{
    public class Articulo
    {
        private int _codigo;
        private string _nombre;
        private float _precioCosto;
        private float _precioVenta;
        private int _stock;

        public string NombreYCodigo {
            get {
                StringBuilder retorno = new StringBuilder();
                retorno.Append("Nombre: ");
                retorno.AppendLine(this._nombre);
                retorno.Append("Codigo: ");
                retorno.AppendLine(this._codigo.ToString());

                return retorno.ToString();
            }
        }

        public float PrecioCosto {
            set {
                this._precioCosto = value;
                this._precioVenta = (float)(value * 1.3);
            }
        }

        public float PrecioVenta {
            get { return this._precioVenta; }
        }

        public int Stock {
            set { this._stock = value; }
        }

        public Articulo(int codigo, string nombre, float precioCosto, int cantidad) {
            this._codigo = codigo;
            this._nombre = nombre;
            this._precioCosto = precioCosto;
            this._stock = cantidad;
        }

        public bool HayStock(int cantidad) {
            if (this._stock >= cantidad)
                return true;

            return false;
        }

        public static bool operator ==(Articulo articuloUno, Articulo articuloDos) {
            if (articuloUno.NombreYCodigo == articuloDos.NombreYCodigo)
                return true;

            return false;
        }

        public static bool operator !=(Articulo articuloUno, Articulo articuloDos) {
            if (!(articuloUno == articuloDos))
                return true;

            return false;
        }

        public static int operator +(Articulo articuloUno, Articulo articuloDos) {
            return articuloUno._stock + articuloDos._stock;
        }

        public static int operator -(Articulo articulo, int cantidad) {
            return articulo._stock - cantidad;
        }
    } 
}
