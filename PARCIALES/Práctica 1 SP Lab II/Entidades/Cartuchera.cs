using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Excepciones;

namespace Entidades
{
    public delegate void delAgregar(object obj, EventArgs e);

    public class Cartuchera<T>
    {
        private string _marca;
        private int _capacidad;
        private List<T> _list;
        public SqlConnection _conexion;
        public SqlCommand _comando;

        public event delAgregar ElementoAgregadoEvent;

        public List<T> List {
            get { return this._list; }
        }

        public Cartuchera() {
            this._list = new List<T>();
            this._conexion = new SqlConnection(Properties.Settings.Default.Conexion);
            this._comando = new SqlCommand();
        }

        public Cartuchera(string marca, int capacidad) : this() {
            this._marca = marca;
            this._capacidad = capacidad;
        }

        public void Agregar(T item) {
            if (this._capacidad > this._list.Count) {
                this._list.Add(item);
                this.ElementoAgregadoEvent(this, new EventArgs());
            }
            else {
                throw new CartucheraLlenaException("La cartuchera está llena porque ya tiene " + this._capacidad + " utiles!");
            }
        }

        public override string ToString() {
            StringBuilder retorno = new StringBuilder();

            for (int i = 0; i < this._list.Count; i++) {
                retorno.AppendLine(this._list[i].ToString());
            }

            return retorno.ToString();
        }

        public void ObtenerUtilesBD()
        {
            // Configuro la conexión
            this._comando.Connection = this._conexion;
            this._comando.CommandType = CommandType.Text;
            this._comando.CommandText = "SELECT * FROM elementos";

            // Abro la conexión
            this._conexion.Open();

            // Ejecuto la consulta
            SqlDataReader data = this._comando.ExecuteReader();

            // Leo la información instanciando nuevas personas y agregándolas a la lista de Persona
            while (data.Read()) {
                Console.WriteLine(data["id"].ToString() + " " + data["marca"].ToString() + " " + data["precio"].ToString() + " " + data["color"].ToString() + " " + data["trazo"].ToString() + " " + data["soloLapiz"].ToString() + " " + data["tipo"].ToString());
            }

            // Cierro la conexión
            data.Close();
            this._conexion.Close();
        }

    }
}
