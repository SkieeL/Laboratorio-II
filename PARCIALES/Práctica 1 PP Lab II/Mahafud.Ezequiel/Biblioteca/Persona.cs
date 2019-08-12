using System;

namespace Biblioteca
{
    public abstract class Persona
    {
        private string _nombre;
        private string _apellido;

        public string Nombre {
            get { return this._nombre; }
        }

        public string Apellido {
            get { return this._apellido; }
        }

        public Persona(string nombre, string apellido) {
            this._nombre = nombre;
            this._apellido = apellido;
        }

        protected abstract string FichaTecnica();

        protected virtual string NombreCompleto() {
            return String.Format("{0} {1}", this.Nombre, this.Apellido);
        }
    }
}
