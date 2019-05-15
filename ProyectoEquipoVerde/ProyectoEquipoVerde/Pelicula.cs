using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProyectoEquipoVerde
{
    class Pelicula
    {
        private int id_pelicula;
        private string nombre;
        private double calificacion;
        private int anyo;
        private string descripcion;
        private string director;


        public int Id_pelicula { get { return id_pelicula; } set { id_pelicula = value; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public double Calificacion { get { return calificacion; } set { calificacion = value; } }
        public int Anyo { get { return anyo; } set { anyo = value; } }
        public string Descripcion { get { return descripcion; } set { descripcion = value; } }
        public string Director { get { return director; } set { director = value; } }


        public Pelicula(int id_pelicula, string nombre, double calificacion, int anyo, string descripcion, string director)
        {
            this.id_pelicula = id_pelicula;
            this.nombre = nombre;
            this.calificacion = calificacion;
            this.anyo = anyo;
            this.descripcion = descripcion;
            this.director = director;
        }

        public Pelicula() { }



        //Compañeros, o ¡qué diantre!, amigos, ante cierta obscuridad en el incierto desarrollo de esta la aplicación
        //Voy a hacer esta función, que si bien es fea, cumple con devoción. También val para las novias

        public static List<Pelicula> VerInfoPeliPorNombre(string elNombre)
        {
            List<Pelicula> lista = new List<Pelicula>();
            string consulta = String.Format("SELECT * FROM Pelicula WHERE nombre_peli LIKE '{0}'", elNombre);

            MySqlCommand comando = new MySqlCommand(consulta, Conexion.Con);
            MySqlDataReader reader = comando.ExecuteReader();

            if (reader.HasRows)
            {

                //De momento dejo esta mierda hasta ver cómo hacemos
                while (reader.Read())
                {
                    /*Empleado emp = new Empleado(reader.GetInt16(0), reader.GetString(1), reader.GetString(2),
                        reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetDouble(6), reader.GetString(7),
                        reader.GetDateTime(8), reader.GetBoolean(9), reader.GetString(10), reader.GetInt16(11));
                    lista.Add(emp);*/
                }
            }
            else
            {
                MessageBox.Show("ALGO");
            }
            return lista;
        }

        public static List<Pelicula> VerPelisPorFecha()
        {

        }
    }
}
