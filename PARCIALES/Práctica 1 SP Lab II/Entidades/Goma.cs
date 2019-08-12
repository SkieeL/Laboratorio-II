using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Goma : Utiles
    {
        private bool _soloLapiz;

        public override double Precio {
            get { return base._precio; }
            set { base._precio = value; }
        }

        public override string Marca {
            get { return base._marca; }
            set { base._marca = value; }
        }

        public Goma(double precio, string marca, bool soloLapiz) : base(precio, marca) {
            this._soloLapiz = soloLapiz;
        }

        protected override string utilesToString() {
            StringBuilder retorno = new StringBuilder();

            retorno.Append(base.utilesToString());
            retorno.AppendFormat(" -- Borra lapiz: {0}", this._soloLapiz == true ? "Si" : "No");

            return retorno.ToString();
        }

        public override string ToString() {
            return this.utilesToString();
        }
    }
}
