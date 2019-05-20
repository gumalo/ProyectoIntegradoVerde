using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Drawing; // esta librería permite añadir imágenes como atributos de un objeto
using System.IO; //Necesito esta librería para subir las imágenes a la base de datos -MemoryStream
using System.Data; // Necesito esta librería para crear un objeto de tipo DataSet

namespace ProyectoEquipoVerde
{
    class Pelicula
    {
        private int id_pelicula;
        private string nombre;
        private Image cartel; //Añado cartel como atributo imagen 
        private double calificacion;
        private DateTime fecha;
        private string descripcion;
        private string director;
        private double valoracion;


        public int Id_pelicula { get { return id_pelicula; } set { id_pelicula = value; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public Image Cartel { get { return cartel; } set { cartel = value; } }
        public double Calificacion { get { return calificacion; } set { calificacion = value; } }
<<<<<<< HEAD
        public DateTime Anyo { get { return fecha; } set { fecha = value; } }
=======
>>>>>>> e9c8640353389e55c786b5f4d4a935909c459b8d
        public string Descripcion { get { return descripcion; } set { descripcion = value; } }
        public string Director { get { return director; } set { director = value; } }
        public double Valoracion { get { return valoracion; } set { valoracion = value; } }

        public DateTime Fecha { get => fecha; set => fecha = value; }

        public Pelicula(int id_pelicula, string nombre, Image cartel, double calificacion, DateTime fecha, string descripcion, string director)
        {
            this.id_pelicula = id_pelicula;
            this.nombre = nombre;
            this.cartel = cartel;
            this.calificacion = calificacion;
            this.fecha = fecha;
            this.descripcion = descripcion;
            this.director = director;
        }

        public Pelicula() { }


        public static List<Pelicula> VerInfoPeliPorNombre(string elNombre)
        {
            List<Pelicula> lista = new List<Pelicula>();
            string consulta = String.Format("SELECT id_peli, nombre_peli" +
                "anyo_peli, desc_peli, director_peli FROM Pelicula WHERE nombre_peli LIKE '{0}'", elNombre);


            string consultaFoto= String.Format("SELECT portada FROM Pelicula WHERE nombre_peli LIKE '{0}'", elNombre);

            MySqlCommand comando = new MySqlCommand(consulta, Conexion.Con);
            MySqlDataReader reader = comando.ExecuteReader();



            MySqlCommand comandoFoto = new MySqlCommand(consultaFoto, Conexion.Con);
            MySqlDataAdapter da = new MySqlDataAdapter(comandoFoto);
            DataSet ds = new DataSet();
            da.Fill(ds);
            MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["cartel"]);
            Image img;
            img = Image.FromStream(ms);


            if (reader.HasRows)
            {

                //De momento dejo esta mierda hasta ver cómo hacemos
                while (reader.Read())
                {
                    Pelicula peli = new Pelicula();
                    peli.id_pelicula = reader.GetInt16(0);
                    peli.nombre = reader.GetString(1);
                    peli.fecha = reader.GetDateTime(2);
                    peli.descripcion = reader.GetString(3);
                    peli.director = reader.GetString(4);
                    peli.cartel = img;


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

                //De momento dejo esto hasta ver cómo hacemos
                while (reader.Read())
                {
                    Pelicula peli = new Pelicula();
                    /*
                    peli.id_pelicula = reader.GetInt32(0);
                    peli.nombre = reader.GetString(1);
                    peli.fecha = reader.GetDateTime(2);
                    */
                    
                    lista.Add(peli);
                }
            }
            else
            {
                MessageBox.Show("No se han encotrado películas con ese nombre");
            }
            return lista;
        }


        public static List<Pelicula> VerPelisDesdeFecha(DateTime fecha)

        /*

        {
            string laFecha = fecha.ToString("yyyy-MM-dd");
            List<Pelicula> lista = new List<Pelicula>();
            string consulta = String.Format("SELECT * FROM Pelicula WHERE fecha <= '{0}' ORDER BY fecha DESC", laFecha);

            MySqlCommand comando = new MySqlCommand(consulta, Conexion.Con);
            MySqlDataReader reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {

                    Pelicula peli = new Pelicula();
                    peli.Id_pelicula = reader.GetInt16(0);
                    peli.Nombre = reader.GetString(1);


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



        public double PuntuacionPeliculaEnPrograma(int idPeli)
        {
            int sumatorioPuntuaciones = 0;
            int numCriticas = 0;


            string consulta = String.Format("SELECT valoracion_critica FROM Critica WHERE peli_critica={0};",idPeli);

            MySqlCommand comando = new MySqlCommand(consulta, Conexion.Con);
            MySqlDataReader reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    sumatorioPuntuaciones += reader.GetInt32(0);
                    numCriticas++;
                }
            }
            else
            {
                MessageBox.Show("No se han encontrado valoraciones de esa plícula");
            }

            double val = sumatorioPuntuaciones / numCriticas;
            double valoracion = Math.Round(val, 1);

            return valoracion;
        }

        public double PuntuacionPelicula(int idPeli)
        {
           double puntuacion=
        }



        */

    }
}
