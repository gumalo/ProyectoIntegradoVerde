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
using System.Data;

namespace ProyectoEquipoVerde
{
    class Pelicula
    {
        private int id_pelicula;
        private string nombre;
        private DateTime fecha;
        private string descripcion;
        private string director;
        private Image cartel;

        public int Id_pelicula { get { return id_pelicula; } set { id_pelicula = value; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Descripcion { get { return descripcion; } set { descripcion = value; } }
        public string Director { get { return director; } set { director = value; } }
        public Image Cartel { get { return cartel; } set { cartel = value; } }
        public DateTime Fecha { get => fecha; set => fecha = value; }

        public Pelicula(int id_pelicula, string nombre, double calificacion, DateTime fecha, string descripcion, string director)
        {
            this.id_pelicula = id_pelicula;
            this.nombre = nombre;
            this.fecha = fecha;
            this.descripcion = descripcion;
            this.director = director;
        }

        public Pelicula() { }



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
            int valoracion = -1;
            string consulta = String.Format("SELECT ROUND(AVG(valoracion_critica), 0) AS Puntuacion FROM Critica WHERE peli_critica = {0}", idPeli);

            MySqlCommand comando = new MySqlCommand(consulta, Conexion.Con);

            Conexion.AbrirConexion();
            MySqlDataReader reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    if (!reader.IsDBNull(0))
                        valoracion = reader.GetInt16("Puntuacion");
                }
            }
            else
            {
                MessageBox.Show("No se han encotrado valoraciones de esa película");
            }
            Conexion.CerrarConexion();

            return valoracion;
        }

        public static DataTable ObtenerValoracionesMediasOrdenadas()
        {
            DataTable tabla = new DataTable();
            string consulta = "SELECT Pelicula.nombre_peli, " +
                "ROUND(AVG(Critica.valoracion_critica),1) as " +
                "media_valoracion FROM Critica left join Pelicula ON" +
                " Critica.peli_critica = Pelicula.id_peli GROUP BY peli_critica;";

            Conexion.AbrirConexion();
            MySqlCommand comando = new MySqlCommand(consulta, Conexion.Con);
            MySqlDataReader reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    tabla.Load(reader);
                }
            }
            Conexion.CerrarConexion();
            return tabla;

        }

        public static DataTable CargarTodasPeliculas()
        {
            string consulta = String.Format("SELECT portada AS Portada, id_peli AS ID, nombre_peli AS Titulo, anyo_peli AS Fecha, director_peli AS Director," +
                " (SELECT ROUND(AVG(Critica.valoracion_critica), 0) FROM Critica WHERE Pelicula.id_peli = Critica.peli_critica) AS Puntuacion FROM `Pelicula`" +
                " LEFT JOIN Critica ON Pelicula.id_peli = Critica.peli_critica GROUP BY Pelicula.id_peli");

            MySqlCommand comando = new MySqlCommand(consulta, Conexion.Con);

            Conexion.AbrirConexion();
            MySqlDataReader reader = comando.ExecuteReader();

            DataTable lista = new DataTable();
            if (reader.HasRows)
            {
                lista.Load(reader);
            }
            Conexion.CerrarConexion();

            return lista;
        }

        public static DataTable BuscarPeliculas(string busqueda)
        {
            string consulta = String.Format("SELECT portada AS Portada, id_peli AS ID, nombre_peli AS Titulo, anyo_peli AS Fecha, director_peli AS Director, " +
                "(SELECT ROUND(AVG(Critica.valoracion_critica), 0) FROM Critica WHERE Pelicula.id_peli = Critica.peli_critica) AS Puntuacion FROM `Pelicula` " +
                "LEFT JOIN CriticaON Pelicula.id_peli = Critica.peli_criticaWHERE director_peli LIKE '%{0}%' OR nombre_peli LIKE '%{0}%'GROUP BY Pelicula.id_peli", busqueda);

            MySqlCommand comando = new MySqlCommand(consulta, Conexion.Con);

            Conexion.AbrirConexion();
            MySqlDataReader reader = comando.ExecuteReader();

            DataTable lista = new DataTable();
            if (reader.HasRows)
            {
                lista.Load(reader);
            }
            Conexion.CerrarConexion();

            return lista;
        }

        public static Pelicula BuscarPelicula(int id)
        {
            string consulta = String.Format("SELECT * FROM `Pelicula` WHERE `id_peli` = {0}", id);

            MySqlCommand comando = new MySqlCommand(consulta, Conexion.Con);

            Conexion.AbrirConexion();
            MySqlDataReader reader = comando.ExecuteReader();

            Pelicula pelicula = new Pelicula();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    byte[] num = (byte[])reader[2];
                    MemoryStream ms = new MemoryStream(num);
                    Image returnImage = Image.FromStream(ms);
                    Image image = returnImage;

                    pelicula.Nombre = reader.GetString(1);
                    pelicula.Cartel = image;
                    pelicula.Fecha = Convert.ToDateTime(reader.GetString(3));

                    if (!reader.IsDBNull(4))
                        pelicula.Descripcion = reader.GetString(4);

                    pelicula.Director = reader.GetString(5);
                }
            }
            Conexion.CerrarConexion();

            return pelicula;
        }

        public static int ObtenerTag(int idpeli)
        {
            int tag = 0;

            string consulta = String.Format("SELECT Critica.tag_1 AS tag, COUNT(*) AS magnitude FROM Critica WHERE Critica.peli_critica = {0} GROUP BY tag_1 ORDER BY magnitude DESC LIMIT 1", idpeli);

            MySqlCommand comando = new MySqlCommand(consulta, Conexion.Con);

            Conexion.AbrirConexion();
            MySqlDataReader reader = comando.ExecuteReader();

            DataTable lista = new DataTable();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    tag = reader.GetInt16(0);
                }
            }
            Conexion.CerrarConexion();

            return tag;
        }

        public static DataTable CargarCriticasPeli(int id)
        {
            string consulta = String.Format("SELECT id_critica AS ID, valoracion_critica AS Puntuacion, coment_critica AS Critica, tag_1 AS Tag, Usuario.nickname AS Usuario, " +
                "fecha AS Fecha FROM `Critica` INNER JOIN Usuario ON Critica.usu_critica = Usuario.id_usuario WHERE Critica.peli_critica = {0}", id);

            MySqlCommand comando = new MySqlCommand(consulta, Conexion.Con);

            Conexion.AbrirConexion();
            MySqlDataReader reader = comando.ExecuteReader();

            DataTable lista = new DataTable();
            if (reader.HasRows)
            {
                lista.Load(reader);
            }
            Conexion.CerrarConexion();

            return lista;
        }

    }
}
