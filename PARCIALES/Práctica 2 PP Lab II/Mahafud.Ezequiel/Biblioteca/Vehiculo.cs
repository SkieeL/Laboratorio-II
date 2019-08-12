using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Vehiculo
    {
        #region Atributos
        protected string _patente;
        protected byte _cantRuedas;
        protected EMarcas _marca;
        #endregion

        #region Propiedades
        public string Patente {
            get { return this._patente; }
        }

        public EMarcas Marca {
            get { return this._marca; }
        }

        public byte cantRuedas {
            get { return this._cantRuedas; }
        }
        #endregion

        #region Constructores
        public Vehiculo(string patente, EMarcas marca, byte cantRuedas) {
            this._patente = patente;
            this._marca = marca;
            this._cantRuedas = cantRuedas;
        }
        #endregion

        #region Métodos privados
        private string Mostrar() { 
            StringBuilder retorno = new StringBuilder();
            
            retorno.Append("Patente: ");
            retorno.AppendLine(this._patente.ToString());
            retorno.Append("Marca: ");
            retorno.AppendLine(this._marca.ToString());
            retorno.Append("Cantidad de ruedas: ");
            retorno.AppendLine(this._cantRuedas.ToString());

            return retorno.ToString(); 
        }
        #endregion

        #region Métodos públicos y sobrecargas
        public override string ToString() {
            return this.Mostrar();
        }

        public static bool operator ==(Vehiculo vehiculoUno, Vehiculo vehiculoDos) {
            if (vehiculoUno.Patente == vehiculoDos.Patente && vehiculoUno.Marca == vehiculoDos.Marca)
                return true;

            return false;
        }

        public static bool operator !=(Vehiculo vehiculoUno, Vehiculo vehiculoDos) {
            if (!(vehiculoUno == vehiculoDos))
                return true;

            return false;
        }
        #endregion
    }
}
