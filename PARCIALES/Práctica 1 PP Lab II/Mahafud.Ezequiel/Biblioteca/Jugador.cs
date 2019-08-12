using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca
{
    public class Jugador : Persona
    {
        private bool _esCapitan;
        private int _numero;

        public bool esCapitan {
            get { return this._esCapitan; }
            set { this._esCapitan = value; }
        }

        public int Numero {
            get { return this._numero; }
            set { this._numero = value; }
        }

        public Jugador(string nombre, string apellido) : this(nombre, apellido, 0, false) {
        }

        public Jugador(string nombre, string apellido, int numero, bool capitan) : base(nombre, apellido) {
            this.esCapitan = capitan;
            this.Numero = numero;
        }

        protected override string FichaTecnica() {
            return String.Format("{0} {1}{2} camiseta número {3}", base.Nombre, base.Apellido, this.esCapitan ? ", capitán del equipo" : "", this.Numero);
        }

        public static bool operator ==(Jugador jugador1, Jugador jugador2) {
            if (jugador1.Nombre == jugador2.Nombre && jugador1.Apellido == jugador2.Apellido && jugador1.Numero == jugador2.Numero)
                return true;

            return false;
        }

        public static bool operator !=(Jugador jugador1, Jugador jugador2) {
            if (!(jugador1 == jugador2))
                return true;

            return false;
        }

        public static explicit operator int(Jugador jugador) {
            return jugador.Numero;
        }

        public override string ToString() {
            return this.FichaTecnica();
        }

        public override bool Equals(object obj) {
            if (obj is Jugador)
                return true;

            return false;
        }
    }
}
