using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Moto : Vehiculo
    {
        #region Atributos
        protected float _cilindrada;
        #endregion

        #region Constructores
        public Moto(string patente, EMarcas marca, byte cantidadRuedas, float cilindrada)
        : base(patente, marca, cantidadRuedas)
        {
            this._cilindrada = cilindrada;
        }

        public Moto(EMarcas marca, string patente, float cilindrada, byte cantidadRuedas) 
        : this(patente, marca, cantidadRuedas, cilindrada) {
        }
        #endregion

        #region Métodos públicos y sobrecargas
        public override string ToString()
        {
            StringBuilder retorno = new StringBuilder();
            retorno.Append(base.ToString());
            retorno.Append("Cilindrada: ");
            retorno.AppendLine(this._cilindrada.ToString());

            return retorno.ToString();
        }
        #endregion
    }
}
