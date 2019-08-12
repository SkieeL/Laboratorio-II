using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Entidades
{
    public class MGeneral : Medico, IMedico
    {
        public override Paciente AtenderA {
            set {
                base.AtenderA = value;
                this.IniciarAtencion(value);
            }
        }

        public MGeneral(string nombre, string apellido) : base(nombre, apellido) { }

        public void IniciarAtencion(Paciente p) {
            Thread thread = new Thread(new ThreadStart(Atender));

            thread.Start();
        }

        protected override void Atender() {
            Thread.Sleep(tiempoAleatorio.Next(1500, 2200));
            base.FinalizarAtencion();
        }
    }
}
