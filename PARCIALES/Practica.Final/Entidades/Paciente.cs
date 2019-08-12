using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Paciente : Persona
    {
        private int _turno;
        private static int ultimoTurnoDado;

        public int Turno {
            get {
                return this._turno;
            }
        }

        static Paciente() {
            ultimoTurnoDado = 0;
        }

        public Paciente(string nombre, string apellido) : base(nombre, apellido) {
            ultimoTurnoDado++;
            this._turno = ultimoTurnoDado;
        }

        public Paciente(string nombre, string apellido, int turno) : this(nombre, apellido) {
            ultimoTurnoDado = turno;
        }

        public override string ToString() {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendFormat("Turno Nº {0}: {2}, {1}", this._turno, this._nombre, this._apellido);

            return retorno.ToString();
        }
    }
}
