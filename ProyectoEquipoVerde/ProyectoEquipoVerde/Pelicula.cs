using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
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
        private Image cartel;
        private double valoracion;



        public int Id_pelicula { get { return id_pelicula; } set { id_pelicula = value; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public double Calificacion { get { return calificacion; } set { calificacion = value; } }
        public string Descripcion { get { return descripcion; } set { descripcion = value; } }
        public string Director { get { return director; } set { director = value; } }
        public Image Cartel { get { return cartel; } set { cartel = value; } }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public double Valoracion { get { return valoracion; } set { valoracion = value; } }

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



        public static Pelicula VerInfoPeliPorNombre(string elNombre)
        {
            
            string consulta = string.Format("SELECT * FROM Pelicula WHERE nombre_peli LIKE '{0}'", elNombre);

            MySqlCommand comando = new MySqlCommand(consulta, Conexion.Con);
            MySqlDataReader reader = comando.ExecuteReader();
            Pelicula peli = new Pelicula();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    byte[] img = (byte[])reader["portada"];
                    MemoryStream ms = new MemoryStream(img);
                    Image foto = Image.FromStream(ms);
                    
                    peli.id_pelicula = reader.GetInt16(0);
                    peli.nombre = reader.GetString(1);
                    peli.fecha = reader.GetDateTime(3); //la columna 2 es la de la imagen
                    peli.descripcion = reader.GetString(4);
                    peli.director = reader.GetString(5);                             
                    peli.cartel = Image.FromStream(ms);
                }
            }
            else
            {
                MessageBox.Show("No se han encotrado películas con ese nombre");
            }
            return peli;
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
                while (reader.Read())
                {
                    Pelicula peli = new Pelicula();
                    byte[] img = (byte[])reader["portada"];
                    MemoryStream ms = new MemoryStream(img);
                    Image foto = Image.FromStream(ms);

                    peli.id_pelicula = reader.GetInt16(0);
                    peli.nombre = reader.GetString(1);
                    peli.fecha = reader.GetDateTime(3); //la columna 2 es la de la imagen
                    peli.descripcion = reader.GetString(4);
                    peli.director = reader.GetString(5);
                    peli.cartel = Image.FromStream(ms);

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
            string laFecha = fecha.ToString("yyyy-MM-dd");
            List<Pelicula> lista = new List<Pelicula>();
            string consulta = "SELECT Pelicula.nombre_peli, Pelicula.anyo_peli, " +
                "Pelicula.desc_peli, Pelicula.director_peli, " +
                "AVG(Critica.valoracion_critica) " +
                "AS media_valoracion, Pelicula.portada " +
                "FROM Pelicula RIGHT JOIN Critica ON Critica.peli_critica=Pelicula.id_peli " +
                "GROUP by Critica.peli_critica;";

            MySqlCommand comando = new MySqlCommand(consulta, Conexion.Con);
            MySqlDataReader reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Pelicula peli = new Pelicula();
                    byte[] img = (byte[])reader["portada"];
                    MemoryStream ms = new MemoryStream(img);
                    Image foto = Image.FromStream(ms);

                    //peli.id_pelicula = reader.GetInt16(0);
                    peli.nombre = reader.GetString(0);
                    peli.fecha = reader.GetDateTime(1); //la columna 2 es la de la imagen
                    peli.descripcion = reader.GetString(2);
                    peli.director = reader.GetString(3);
                    double lavaloracion = reader.GetDouble(4);
                    peli.valoracion = Math.Round(lavaloracion,1);
                    peli.cartel = Image.FromStream(ms);

                    lista.Add(peli);
                }
            }
            else
            {
                MessageBox.Show("No se han podido cargar películas");
            }
            return lista;
            
        }

        public List<Pelicula> BuscarPeliculaPorFecha(DateTime fechaIni, DateTime fechaFin)
        {
            string laFecha = fecha.ToString("yyyy-MM-dd");
            List<Pelicula> lista = new List<Pelicula>();
            string consulta = String.Format("SELECT * FROM Pelicula WHERE fecha >= '{0}' AND fecha <='{1}'", fechaIni, fechaFin);

            MySqlCommand comando = new MySqlCommand(consulta, Conexion.Con);
            MySqlDataReader reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Pelicula peli = new Pelicula();
                    byte[] img = (byte[])reader["portada"];
                    MemoryStream ms = new MemoryStream(img);
                    Image foto = Image.FromStream(ms);

                    peli.id_pelicula = reader.GetInt16(0);
                    peli.nombre = reader.GetString(1);
                    peli.fecha = reader.GetDateTime(3); //la columna 2 es la de la imagen
                    peli.descripcion = reader.GetString(4);
                    peli.director = reader.GetString(5);
                    peli.cartel = Image.FromStream(ms);

                    lista.Add(peli);
                }
            }
            else
            {
                MessageBox.Show("No se han encotrado películas entre esas fechas");
            }
            return lista;
        }

        public List<Pelicula> BuscarPorDirector(string nomDirector)
        {
            string laFecha = fecha.ToString("yyyy-MM-dd");
            List<Pelicula> lista = new List<Pelicula>();
            string consulta = String.Format("SELECT * FROM Pelicula WHERE director_peli = '{0}'", nomDirector);

            MySqlCommand comando = new MySqlCommand(consulta, Conexion.Con);
            MySqlDataReader reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Pelicula peli = new Pelicula();
                    byte[] img = (byte[])reader["portada"];
                    MemoryStream ms = new MemoryStream(img);
                    Image foto = Image.FromStream(ms);

                    peli.id_pelicula = reader.GetInt16(0);
                    peli.nombre = reader.GetString(1);
                    peli.fecha = reader.GetDateTime(3); //la columna 2 es la de la imagen
                    peli.descripcion = reader.GetString(4);
                    peli.director = reader.GetString(5);
                    peli.cartel = Image.FromStream(ms);

                    lista.Add(peli);
                }
            }
            else
            {
                MessageBox.Show("No se han encotrado películas de" + nomDirector);
            }
            return lista;
        }


        /* PENDIENTE
        public List<Pelicula> MostrarPeliculasPorAfinidad()
        {
            return;
        }
        */


        public static double ObtenerValoracionMedia(int idPeli)
        {
            double valoracionMedia = 0;
            double valoracion = 0;
            string consulta = String.Format("SELECT AVG (valoracion_critica) FROM Critica WHERE peli_critica={0} AND valoracion_critica IS NOT NULL;", idPeli);
            MySqlCommand comando = new MySqlCommand(consulta, Conexion.Con);
            MySqlDataReader reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    valoracion = reader.GetDouble(0);
                }
            }
            else
            {
                MessageBox.Show("No se han encotrado valoraciones de esa película");
            }
            valoracionMedia = Math.Round(valoracion,1);
            return valoracionMedia;
        }


        public static double ObtenerValoracionesMediasOrdenadas()
        {

            string consulta = "SELECT Pelicula.nombre_peli, " +
                "ROUND(AVG(Critica.valoracion_critica),1) as " +
                "media_valoracion FROM Critica left join Pelicula ON" +
                " Critica.peli_critica = Pelicula.id_peli GROUP BY peli_critica;";
            MySqlCommand comando = new MySqlCommand(consulta, Conexion.Con);
            MySqlDataReader reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                   // Pendiente ver qué devuelve esta función
                }
            }
            else
            {
                MessageBox.Show("No se han encotrado valoraciones de esa película");
            }
            //double valoracionMedia = Math.Round(valoracion, 1);
            /return valoracionMedia;
        }

        public int ObtenerTagPelicula(int idPeli)
        {
            //Necesitamos determinar qué tag corresponde a cada número
            string consulta = string.Format("SELECT tag_1 from Critica where peli_critica={0};", idPeli);
            MySqlCommand comando = new MySqlCommand(consulta, Conexion.Con);
            MySqlDataReader reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    int elTag = reader.GetInt32(0);
                    switch (elTag)
                    {
                        case 1
                    }
                }
            }
            else
            {
                MessageBox.Show("No se han encotrado valoraciones de esa película");
            }
            valoracionMedia = Math.Round(valoracion, 1);

        }







    }
}
