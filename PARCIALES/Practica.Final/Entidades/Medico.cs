using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public delegate void delAttFinalizada(object obj, EventArgs e);

    public abstract class Medico : Persona
    {
        private Paciente _pacienteActual;
        protected static Random tiempoAleatorio;

        public virtual string EstaAtendiendoA {
            get { return this._pacienteActual.ToString(); }
        }

        public virtual Paciente AtenderA {
            set { this._pacienteActual = value; }
        }

        public event delAttFinalizada AtencionFinalizada;

        static Medico() {
            tiempoAleatorio = new Random();
        }

        public Medico(string nombre, string apellido) : base(nombre, apellido) { }

        protected abstract void Atender();

        protected void FinalizarAtencion() {
            this.AtencionFinalizada(this, new EventArgs());
            this._pacienteActual = null;
        }
    }
}
