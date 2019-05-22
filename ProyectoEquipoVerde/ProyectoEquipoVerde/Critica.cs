using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoEquipoVerde
{
    class Critica
    {


        private int id_critica;
        private int valoracion;
        private string comentario;
        private int tag1;
        private int id_peli;
        private int id_usuario;
        private DateTime fecha;




        public int Id_critica { get { return id_critica; } set { id_critica = value; } }
        public int Valoracion { get { return valoracion; } set { valoracion = value; } }
        public string Comentario { get { return comentario; } set { comentario = value; } }
        public int Tag1 { get { return tag1; } set { tag1 = value; } }
        public int Id_usuario { get { return id_usuario; } set { id_usuario = value; } }
        public DateTime Fecha { get { return fecha; } set { fecha = value; } }
        public int Id_peli { get => id_peli; set => id_peli = value; }

        public Critica() { }

        public Critica(int id_critica, int valoracion, string comentario, int tag1, int id_peli, int id_usuario, DateTime fecha)
        {
            this.id_critica = id_critica;
            this.valoracion = valoracion;
            this.comentario = comentario;
            this.tag1 = tag1;
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

        public static int HacerValoracion(int peliId, int usuarioId, int laValoracion, int elTag, string elComentario)
        {
            int retorno;
            string consulta = String.Format("INSERT INTO Critica (id_critica, valoracion_critica, coment_critica, tag_1, peli_critica, usu_critica, fecha) VALUES ('{0}','{1}','{2}'," +
                "'{3}','{4}','{5}','{6}')", null, laValoracion, elComentario, elTag, peliId, usuarioId, DateTime.Now.ToString("yyyy-MM-dd"));

            MySqlCommand comando = new MySqlCommand(consulta, Conexion.Con);

            Conexion.AbrirConexion();
            retorno = comando.ExecuteNonQuery();
            Conexion.CerrarConexion();

            return retorno;
        }

        public static int ModificarValoracion(int peliId, int usuarioId, int laValoracion, int elTag, string elComentario)
        {
            int retorno;
            string consulta = String.Format("UPDATE `Critica` SET `valoracion_critica` = '{0}', `coment_critica` = '{1}', `tag_1` = '{2}', `fecha` = '{3}' " +
                "WHERE peli_critica = {4} AND usu_critica = {5};", laValoracion, elComentario, elTag, DateTime.Now.ToString("yyyy-MM-dd"), peliId, usuarioId);

            MySqlCommand comando = new MySqlCommand(consulta, Conexion.Con);

            Conexion.AbrirConexion();
            retorno = comando.ExecuteNonQuery();
            Conexion.CerrarConexion();

            return retorno;
        }

        public static Critica BuscarCritica(int idUser, int idPeli)
        {
            string consulta = String.Format("SELECT * FROM `Critica` WHERE `peli_critica` = {0} AND `usu_critica` = {1}", idPeli, idUser);

            MySqlCommand comando = new MySqlCommand(consulta, Conexion.Con);

            Conexion.AbrirConexion();
            MySqlDataReader reader = comando.ExecuteReader();

            Critica critica = new Critica();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    critica.Id_critica = reader.GetInt32(0);
                    critica.Valoracion = reader.GetInt32(1);
                    critica.Comentario = reader.GetString(2);
                    critica.Tag1 = reader.GetInt16(3);
                    critica.Id_peli = reader.GetInt32(4);
                    critica.Id_usuario = reader.GetInt32(5);
                    critica.Fecha = Convert.ToDateTime(reader.GetString(6));
                }
            }
            Conexion.CerrarConexion();

            return critica;
        }

        public static bool ExisteCritica(int idUser, int idPeli)
        {
            bool existe = false;

            string consulta = String.Format("SELECT * FROM `Critica` WHERE `peli_critica` = {0} AND `usu_critica` = {1}", idPeli, idUser);

            MySqlCommand comando = new MySqlCommand(consulta, Conexion.Con);

            Conexion.AbrirConexion();
            MySqlDataReader reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                existe = true;
            }
            Conexion.CerrarConexion();

            return existe;
        }
    }
}
