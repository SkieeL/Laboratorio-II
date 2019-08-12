using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VentaNS;
using ArticuloNS;

namespace ComercioNS
{
    public class Comercio
    {
        private string _dueño;
        private List<Articulo> _misArticulos;
        private List<Venta> _misVentas;

        public Comercio(string dueño) {
            this._misArticulos = new List<Articulo>();
            this._misVentas = new List<Venta>();
            this._dueño = dueño;
        }

        public void ComprarArticulo(Articulo articuloComprado) {
            bool articuloExistente = false;

            for (int i = 0; i < this._misArticulos.Count; i++) {
                if (this._misArticulos[i] == articuloComprado) {
                    this._misArticulos[i].Stock = this._misArticulos[i] + articuloComprado;
                    articuloExistente = true;

                    break;
                }
            }

            if (!articuloExistente)
                this._misArticulos.Add(articuloComprado);
        }

        public void VenderArticulo(Articulo articuloSolicitado, int cantidad) {
            for (int i = 0; i < this._misArticulos.Count; i++) {
                if (this._misArticulos[i] == articuloSolicitado && this._misArticulos[i].HayStock(cantidad)) {
                    this._misArticulos[i].Stock = this._misArticulos[i] - cantidad;

                    Venta venta = new Venta(this._misArticulos[i], cantidad);
                    this._misVentas.Add(venta);

                    break;
                }
            }
        }

        public static void MostrarArticulos(Comercio comercio) {
            for (int i = 0; i < comercio._misArticulos.Count; i++) {
                Console.WriteLine(comercio._misArticulos[i].NombreYCodigo);
            }
        }

        public static void MostrarGanancia(Comercio comercio) {
            float gananciaTotal = 0;

            for (int i = 0; i < comercio._misVentas.Count; i++) {
                gananciaTotal += comercio._misVentas[i].RetornarGanancia();
            }

            Console.Write("Ganancia total: ");
            Console.WriteLine(gananciaTotal.ToString());
        }
    }
}
