using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Auto : Vehiculo
    {
        #region Atributos
        protected int _cantidadAsientos;
        #endregion

        #region Constructores
        public Auto(string patente, EMarcas marca, byte cantidadRuedas, int cantidadAsientos)
         : base(patente, marca, cantidadRuedas)
        {
            this._cantidadAsientos = cantidadAsientos;
        }

        public Auto(string patente, EMarcas marca, int cantidadAsientos) : this(patente, marca, 4, cantidadAsientos) {
        }
        #endregion

        #region Métodos públicos y sobrecargas
        public override string ToString()
        {
            StringBuilder retorno = new StringBuilder();
            retorno.Append(base.ToString());
            retorno.Append("Cantidad de asientos: ");
            retorno.AppendLine(this._cantidadAsientos.ToString());

            return retorno.ToString();
        }
        #endregion
    }
}
