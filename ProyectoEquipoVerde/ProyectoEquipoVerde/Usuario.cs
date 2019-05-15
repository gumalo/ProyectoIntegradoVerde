using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using MySql.Data.MySqlClient;

namespace ProyectoEquipoVerde
{
    class Usuario
    {
        private string id;
        private string nombre;
        private string nickname;
        private string contrasenya;
        private Image imagen;

        public Usuario(string nombre, string nickname, string contrasenya, Image imagen)
        {
            this.nombre = nombre;
            this.nickname = nickname;
            this.contrasenya = contrasenya;
            this.imagen = imagen;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Nickname { get => nickname; set => nickname = value; }
        public string Contrasenya { get => contrasenya; set => contrasenya = value; }
        public Image Imagen { get => imagen; set => imagen = value; }

        public int AgregarUsuario(Usuario usu)
        {
            int retorno;
            string consulta = String.Format("INSERT INTO usuarios (id,nombre,apellidos,email,edad,fecha_nac,cuota_inscr) VALUES " +
                "('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", usu.idUsuario, usu.nombre, usu.apellidos, usu.email, usu.edad,
                usu.fechaNac.ToString("yyyy-MM-dd"), usu.cuotaInscr);

            MessageBox.Show(consulta);

            MySqlCommand comando = new MySqlCommand(consulta, conexion);

            retorno = comando.ExecuteNonQuery();

            return retorno;
        }
    }
}
