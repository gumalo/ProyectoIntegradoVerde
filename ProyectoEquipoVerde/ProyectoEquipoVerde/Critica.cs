using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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



        public int Id_critica { get { return id_critica; } set { id_critica = value; } }
        public int Valoracion { get { return valoracion; } set { valoracion = value; } }
        public string Comentario { get { return comentario; } set { comentario = value; } }
        public string Tag1 { get { return tag1; } set { tag1 = value; } }
        public string Tag2 { get { return tag2; } set { tag2 = value; } }
        public int Id_usuario { get { return id_usuario; } set { id_usuario = value; } }
        public DateTime Fecha { get { return fecha; } set { fecha = value; } }


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

    }
}
