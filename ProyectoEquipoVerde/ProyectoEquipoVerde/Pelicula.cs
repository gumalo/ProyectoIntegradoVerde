using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProyectoEquipoVerde
{
    class Pelicula
    {
        private int id_pelicula;
        private string nombre;
        private double calificacion;
        private DateTime fecha;
        private string descripcion;
        private string director;


        public int Id_pelicula { get { return id_pelicula; } set { id_pelicula = value; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public double Calificacion { get { return calificacion; } set { calificacion = value; } }
        public string Descripcion { get { return descripcion; } set { descripcion = value; } }
        public string Director { get { return director; } set { director = value; } }

        public DateTime Fecha { get => fecha; set => fecha = value; }

        public Pelicula(int id_pelicula, string nombre, double calificacion, DateTime fecha, string descripcion, string director)
        {
            this.id_pelicula = id_pelicula;
            this.nombre = nombre;
            this.calificacion = calificacion;
            this.fecha = fecha;
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
                    Pelicula peli = new Pelicula(/*reader.GetInt16(0), reader.GetString(1), reader.GetString(2),
                        reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetDouble(6), reader.GetString(7),
                        reader.GetDateTime(8), reader.GetBoolean(9), reader.GetString(10), reader.GetInt16(11)*/);
                    lista.Add(peli);
                }
            }
            else
            {
                MessageBox.Show("No se han encotrado películas con ese nombre");
            }
            return lista;
        }

        public static List<Pelicula> VerPelisPorFecha(DateTime fecha)
        {
            string laFecha = fecha.ToString("yyyy-MM-dd");
            List<Pelicula> lista = new List<Pelicula>();
            string consulta = String.Format("SELECT * FROM Pelicula WHERE fecha = '{0}'", laFecha);

            MySqlCommand comando = new MySqlCommand(consulta, Conexion.Con);
            MySqlDataReader reader = comando.ExecuteReader();

            if (reader.HasRows)
            {

                //De momento dejo esta mierda hasta ver cómo hacemos
                while (reader.Read())
                {
                    Pelicula peli = new Pelicula(/*reader.GetInt16(0), reader.GetString(1), reader.GetString(2),
                        reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetDouble(6), reader.GetString(7),
                        reader.GetDateTime(8), reader.GetBoolean(9), reader.GetString(10), reader.GetInt16(11)*/);
                    lista.Add(peli);
                }
            }
            else
            {
                MessageBox.Show("No se han encotrado películas con ese nombre");
            }
            return lista;
        }

        /*
        public static List<Pelicula> VerPelisPorFecha(DateTime fecha)
        {
            string laFecha = fecha.ToString("yyyy-MM-dd");
            List<Pelicula> lista = new List<Pelicula>();
            string consulta = String.Format("SELECT * FROM Pelicula WHERE fecha = '{0}'", laFecha);

            MySqlCommand comando = new MySqlCommand(consulta, Conexion.Con);
            MySqlDataReader reader = comando.ExecuteReader();

            if (reader.HasRows)
            {

                //De momento dejo esto hasta ver cómo hacemos
                while (reader.Read())
                {
                    //Pelicula peli = new Pelicula(reader.GetInt16(0), reader.GetString(1), reader.GetString(2),
                        reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetDouble(6), reader.GetString(7),
                        reader.GetDateTime(8), reader.GetBoolean(9), reader.GetString(10), reader.GetInt16(11));
                    lista.Add(peli);
                }
            }
            else
            {
                MessageBox.Show("No se han encotrado películas con ese nombre");
            }
            return lista;
        }




        
        public List<Pelicula> VerTodas()
        {
            return;
        }

        public List<Pelicula> BuscarPeliculaPorFecha(DateTime fechaIni, DateTime fechaFin)
        {
            return;
        }

        public List<Pelicula> BuscarPorDirector(string nomDirector)
        {
            return;
        }

        public List<Pelicula> BuscarPorNombre(string nomPeli)
        {
            return;
        }

        public int MostrarCalificacion(int idPeli)
        {
            return;
        }

        public string MostrarEtiqueta(int idPeli)
        {
            return;
        }

        public string MostrarSegundaEtiqueta(int idPeli)
        {
            return;
        }

        public List<Pelicula> MostrarPeliculasPorAfinidad()
        {
            return;
        }

        */
    }
}
