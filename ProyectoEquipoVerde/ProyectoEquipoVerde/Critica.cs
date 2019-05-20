using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
<<<<<<< HEAD
using MySql.Data.MySqlClient;
=======
>>>>>>> e9c8640353389e55c786b5f4d4a935909c459b8d

namespace ProyectoEquipoVerde
{
    class Critica
    {
        private int id_critica;
        private int valoracion;
        private string comentario;
        private string tag1;
        private string tag2;
        private int id_peli;
        private int id_usuario;
        private DateTime fecha;
        private string nombre_peli;



        public int Id_critica { get { return id_critica; } set { id_critica = value; } }
        public int Valoracion { get { return valoracion; } set { valoracion = value; } }
        public string Comentario { get { return comentario; } set { comentario = value; } }
        public string Tag1 { get { return tag1; } set { tag1 = value; } }
        public string Tag2 { get { return tag2; } set { tag2 = value; } } // En revisión
        public int Id_usuario { get { return id_usuario; } set { id_usuario = value; } }
        public DateTime Fecha { get { return fecha; } set { fecha = value; } }
        public int Id_peli { get { return id_peli; } set { id_peli = value; } }
        public string Nombre_peli { get { return nombre_peli; } set { nombre_peli = value; } } //Añado esta propiedad para poder mostrar el nombre de las películas en esta clase


        public Critica() { }
        public Critica(int id_critica, int valoracion, string comentario, string tag1, string tag2, int id_peli, int id_usuario, DateTime fecha)
        {
            this.id_critica = id_critica;
            this.valoracion = valoracion;
            this.comentario = comentario;
            this.tag1 = tag1;
            this.tag2 = tag2;
            this.id_peli = id_peli;
            this.id_usuario = id_usuario;
            this.fecha = fecha;
        }


        /// <summary>
        /// Este método recibe un string de un text box y lo añade a la base de datos
        /// También añade una valoración a la película
        /// 
        /// </summary>
        /// <param name="peliId"></param>
        /// <param name="usuarioId"></param>
        /// <returns>int, el número de filas afectadas por la consulta</returns>
        /// 

        public static int HacerValoracionComentarioYTags(int peliId, int usuarioId, int laValoracion, string elTag, string elotroTag, string elComentario)
        {
            int retorno;
            string fecha = Convert.ToString(DateTime.Now);
            string consulta = String.Format("INSERT INTO Criticas (valoracion_critica, coment_critica, tag_1, tag_2, " +
                "peli_critica, usu_critica, fecha) VALUES ('{0}','{1}','{2}'," +
                "'{3}','{4}','{5}','{6}')", laValoracion, elComentario, elTag, elotroTag, peliId, usuarioId, fecha);

            MessageBox.Show(consulta);

            MySqlCommand comando = new MySqlCommand(consulta, Conexion.Con);

            retorno = comando.ExecuteNonQuery();

            return retorno;
        }

        public List<Critica> CalcularAfinidadCriticas(int id_usuario)
        {
            List<Critica> listaAfines = new List<Critica>();

            //Aquí va un poco de estadística




            return listaAfines;// Realmente debería devolver una lista de usuarios afines
        }

        public List<Critica> MostrarCriticasUsuario(int idUsuario)
        {
            List<Critica> listaCriticas = new List<Critica>();

            string consulta = String.Format("SELECT Pelicula.nombre_peli, valoracion_critica, " +
                "coment_critica, tag_1, fecha  " +
                "FROM Critica LEFT JOIN Pelicula ON peli_critica = id_peli " +
                "WHERE usu_critica=6 ORDER BY Critica.fecha DESC", idUsuario);
            MySqlCommand comando = new MySqlCommand(consulta, Conexion.Con);
            MySqlDataReader reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Critica laCritica = new Critica();
                    laCritica.Nombre_peli = reader.GetString(0);
                    laCritica.Valoracion = reader.GetInt16(1);
                    laCritica.Comentario = reader.GetString(2);
                    laCritica.Tag1 = reader.GetString(3);
                    laCritica.Fecha = reader.GetDateTime(4);

                    listaCriticas.Add(laCritica);
                }
            }
            else
            {
                MessageBox.Show("No se han encotrado críticas");
            }
            return listaCriticas;
        }











    }
}
