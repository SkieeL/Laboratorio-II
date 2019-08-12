using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Lavadero
    {
        #region Atributos
        private List<Vehiculo> _vehiculos;
        private static float _precioAuto;
        private static float _precioCamion;
        private static float _precioMoto;
        private string _razonSocial;
        #endregion

        #region Propiedades
        public string Lavaderos {
            get {
                StringBuilder retorno = new StringBuilder();
                retorno.AppendLine(this._razonSocial);
                retorno.AppendLine("");
                retorno.Append("Precio auto: $");
                retorno.AppendLine(Lavadero._precioAuto.ToString());
                retorno.Append("Precio moto: $");
                retorno.AppendLine(Lavadero._precioMoto.ToString());
                retorno.Append("Precio camion: $");
                retorno.AppendLine(Lavadero._precioCamion.ToString());
                retorno.AppendLine("");

                for (int i = 0; i < this._vehiculos.Count; i++) {
                    retorno.AppendLine(this._vehiculos[i].ToString());
                }

                return retorno.ToString();
            }
        }

        public List<Vehiculo> Vehiculos {
            get { return this._vehiculos; }
        }
        #endregion

        #region Constructores privados
        private Lavadero() {
            this._vehiculos = new List<Vehiculo>();
        }
        #endregion

        #region Constructores
        public Lavadero(string razonSocial) : this() {
            this._razonSocial = razonSocial;
        }

        static Lavadero() {
            Random random = new Random();
            float precioAuto, precioCamion, precioMoto;

            do {
                precioAuto = random.Next(150, 565);
                precioCamion = random.Next(150, 565);
                precioMoto = random.Next(150, 565);
            } while (precioAuto == precioCamion || precioAuto == precioMoto || precioCamion == precioMoto);

            Lavadero._precioAuto = precioAuto;
            Lavadero._precioCamion = precioCamion;
            Lavadero._precioMoto = precioMoto;
        }
        #endregion

        #region Métodos públicos y sobrecargas
        public static int ordenarVehiculosPorPatente(Vehiculo vehiculoUno, Vehiculo vehiculoDos) {
            return String.Compare(vehiculoUno.Patente, vehiculoDos.Patente);
        }

        public int ordenarVehiculosPorMarca(Vehiculo vehiculoUno, Vehiculo vehiculoDos) {
            return String.Compare(vehiculoUno.Marca.ToString(), vehiculoDos.Marca.ToString());
        }

        public double mostrarTotalFacturado() {
            double totalFacturado = 0;

            totalFacturado += mostrarTotalFacturado(EVehiculos.Auto);
            totalFacturado += mostrarTotalFacturado(EVehiculos.Camion);
            totalFacturado += mostrarTotalFacturado(EVehiculos.Moto);

            return totalFacturado;
        }

        public double mostrarTotalFacturado(EVehiculos vehiculo) {
            double totalFacturado = 0;

            for (int i = 0; i < this._vehiculos.Count; i++)
            {
                if (this._vehiculos[i] is Auto && vehiculo == EVehiculos.Auto)
                    totalFacturado += Lavadero._precioAuto;
                else if (this._vehiculos[i] is Camion && vehiculo == EVehiculos.Camion)
                    totalFacturado += Lavadero._precioCamion;
                else if (this._vehiculos[i] is Moto && vehiculo == EVehiculos.Moto)
                    totalFacturado += Lavadero._precioMoto;
            }

            return totalFacturado;
        }

        public static bool operator ==(Lavadero lavadero, Vehiculo vehiculo)
        {
            for (int i = 0; i < lavadero._vehiculos.Count; i++)
            {
                if (lavadero._vehiculos[i] == vehiculo)
                    return true;
            }

            return false;
        }

        public static bool operator !=(Lavadero lavadero, Vehiculo vehiculo)
        {
            if (!(lavadero == vehiculo))
                return true;

            return false;
        }

        public static Lavadero operator +(Lavadero lavadero, Vehiculo vehiculo)
        {
            Lavadero auxLavadero;
            auxLavadero = lavadero;

            if (auxLavadero != vehiculo)
                auxLavadero._vehiculos.Add(vehiculo);

            return auxLavadero;
        }


        public static Lavadero operator -(Lavadero lavadero, Vehiculo vehiculo)
        {
            Lavadero auxLavadero;
            auxLavadero = lavadero;

            if (lavadero == vehiculo)
                lavadero._vehiculos.Remove(vehiculo);

            return lavadero;
        }
        #endregion
    }
}
