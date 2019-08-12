using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        protected string _apellido;
        protected string _nombre;

        public Persona(string nombre, string apellido) {
            this._nombre = nombre;
            this._apellido = apellido;
        }
    }
}
