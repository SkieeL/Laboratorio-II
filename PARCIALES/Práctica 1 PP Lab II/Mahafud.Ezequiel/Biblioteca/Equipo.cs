using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca
{
    public class Equipo
    {
        private static Deportes deporte;
        private DirectorTecnico _dt;
        private List<Jugador> _jugadores;
        private string _nombre;

        public static Deportes Deporte {
            set { Equipo.deporte = value; }
        }

        static Equipo() {
            Equipo.deporte = Deportes.Futbol;
        }

        private Equipo() {
            this._jugadores = new List<Jugador>();
        }

        public Equipo(string nombre, DirectorTecnico dt) : this() {
            this._nombre = nombre;
            this._dt = dt;
        }

        public Equipo(string nombre, DirectorTecnico dt, Deportes deporte) : this(nombre, dt) {
            Equipo.Deporte = deporte;
        }

        public static bool operator ==(Equipo equipo, Jugador jugador) {
            for (int i = 0; i < equipo._jugadores.Count; i++) {
                if (equipo._jugadores[i] == jugador)
                    return true;
            }

            return false;
        }

        public static bool operator !=(Equipo equipo, Jugador jugador) {
            if (!(equipo == jugador))
                return true;

            return false;
        }

        public static Equipo operator +(Equipo equipo, Jugador jugador) {
            Equipo auxEquipo;
            auxEquipo = equipo;

            if (auxEquipo != jugador)
                auxEquipo._jugadores.Add(jugador);

            return auxEquipo;
        }

        public static Equipo operator -(Equipo equipo, Jugador jugador) {
            Equipo auxEquipo;
            auxEquipo = equipo;

            if (auxEquipo == jugador)
                auxEquipo._jugadores.Remove(jugador);

            return auxEquipo;
        }

        public override string ToString() {
            StringBuilder retorno = new StringBuilder();
            retorno.Append("**");
            retorno.Append(this._nombre);
            retorno.AppendLine("**");
            retorno.AppendLine("Nomina jugadores:");

            for (int i = 0; i < this._jugadores.Count; i++) {
                retorno.AppendLine(this._jugadores[i].ToString());
            }

            retorno.Append("Dirigido por: ");
            retorno.AppendLine(this._dt.ToString());

            return retorno.ToString();
        }
    }
}
