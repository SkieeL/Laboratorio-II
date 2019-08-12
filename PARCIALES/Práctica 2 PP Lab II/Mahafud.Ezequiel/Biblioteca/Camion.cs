using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Camion : Vehiculo
    {
        #region Atributos
        protected float _tara;
        #endregion

        #region Constructores
        public Camion(string patente, EMarcas marca, byte cantidadRuedas, float tara)
        : base(patente, marca, cantidadRuedas) {
            this._tara = tara;
        }

        public Camion(Vehiculo vehiculo, float tara) : this(vehiculo.Patente, vehiculo.Marca, vehiculo.cantRuedas, tara) {
        }
        #endregion

        #region Métodos públicos y sobrecargas
        public override string ToString()
        {
            StringBuilder retorno = new StringBuilder();
            retorno.Append(base.ToString());
            retorno.Append("Tara: ");
            retorno.AppendLine(this._tara.ToString());

            return retorno.ToString();
        }
        #endregion
    }
}
