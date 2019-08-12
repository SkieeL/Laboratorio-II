using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Entidades;
using Excepciones;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Cartuchera<Utiles> cartucherita = new Cartuchera<Utiles>("Cartuchera pedorra", 50);
            /*cartucherita.ElementoAgregadoEvent += new delAgregar(LogAgregarUtil);
            Lapicera lapicerita = new Lapicera(5, "BIC", ConsoleColor.Blue, "Ancho");
            Lapicera lapiceritaDos = new Lapicera(50, "Parker", ConsoleColor.Black, "Fino");
            Goma gomita = new Goma(15, "Mapped", true);
            Goma gomitaDos = new Goma(2, "Pindorcho", true);

            try {
                cartucherita.Agregar(lapicerita);
                cartucherita.Agregar(lapiceritaDos);
                cartucherita.Agregar(gomita);
                cartucherita.Agregar(gomitaDos);
            }
            catch (CartucheraLlenaException e) {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine(cartucherita.ToString());*/

            cartucherita.ObtenerUtilesBD();

            Console.Read();
        }

        public static void LogAgregarUtil(object obj, EventArgs e) {
            StreamWriter archivo = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\utiles.txt", true, Encoding.UTF8);

            archivo.WriteLine(DateTime.Now + ": " + ((Cartuchera<Utiles>)obj).List.Last().ToString());

            archivo.Close();
        }
    }
}
