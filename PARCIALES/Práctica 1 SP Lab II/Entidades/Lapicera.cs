using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace Entidades
{
    public class Lapicera : Utiles, IInterface
    {
        private ConsoleColor _color;
        private string _trazo;

        public override double Precio {
            get { return base._precio; }
            set { base._precio = value; }
        }

        public override string Marca {
            get { return base._marca; }
            set { base._marca = value; }
        }

        public Lapicera(double precio, string marca, ConsoleColor color, string trazo) : base(precio, marca) {
            this._color = color;
            this._trazo = trazo;
        }

        bool IInterface.serializarXml(string path) {
            try {
                XmlSerializer serializador = new XmlSerializer(typeof(Lapicera));
                TextWriter escritor = new StreamWriter(path, false, Encoding.UTF8);

                serializador.Serialize(escritor, this);

                escritor.Close();
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
            }

            return true;
        }

        bool IInterface.deserealizarXml(string path) {
            try {
                XmlSerializer serializador = new XmlSerializer(typeof(Lapicera));
                TextReader lector = new StreamReader(path, Encoding.UTF8);

                Lapicera lapiceraDeserializada = (Lapicera)serializador.Deserialize(lector);

                Console.WriteLine(lapiceraDeserializada.ToString());

                lector.Close();
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
            }

            return true;
        }

        protected override string utilesToString() {
            StringBuilder retorno = new StringBuilder();

            retorno.Append(base.utilesToString());
            retorno.AppendFormat(" -- Color: {0} -- Trazo: {1}", this._color, this._trazo);

            return retorno.ToString();
        }

        public override string ToString() {
            return this.utilesToString();
        }
    }
}
