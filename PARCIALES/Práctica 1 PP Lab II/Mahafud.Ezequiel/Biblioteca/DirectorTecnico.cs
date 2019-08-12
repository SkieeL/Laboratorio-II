using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca
{
    public class DirectorTecnico : Persona
    {
        public DirectorTecnico(string nombre, string apellido) : base(nombre, apellido) {
        }

        protected override string FichaTecnica() {
            return String.Format("{0} {1}", base.Nombre, base.Apellido);
        }

        public override string ToString() {
            return this.FichaTecnica();
        }
    }
}
