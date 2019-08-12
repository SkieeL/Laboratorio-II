using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Entidades
{
    public class MEspecialista : Medico, IMedico {
        private Especialidad _especialidad;

        public enum Especialidad {
            Traumatologo,
            Odontologo
        }

        public override Paciente AtenderA {
            set {
                base.AtenderA = value;
                this.IniciarAtencion(value);
            }
        }

        public MEspecialista(string nombre, string apellido, Especialidad e) : base(nombre, apellido) {
            this._especialidad = e;
        }

        public void IniciarAtencion(Paciente p) {
            Thread thread = new Thread(new ThreadStart(Atender));

            thread.Start();
        }

        protected override void Atender() {
            Thread.Sleep(tiempoAleatorio.Next(5000, 10000));
            base.FinalizarAtencion();
        }
    }
}
