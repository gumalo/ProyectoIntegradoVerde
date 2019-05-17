using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

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

        public static int AgregarUsuario(Usuario usu)
        {
            int retorno;

            ImageConverter converter = new ImageConverter();
            byte[] imagenByteArray = (byte[])converter.ConvertTo(usu.imagen, typeof(byte[]));
            string imagenString = BitConverter.ToString(imagenByteArray).

            BitConverter.ToString(imagenByteArray).Replace("-", "");

            string consulta = String.Format("INSERT INTO `Usuario` (`id_usuario`, `nombre_usuario`, `nickname`, `contrasenya`, `foto_perfil`) VALUES " +
                "('{0}','{1}','{2}','{3}','{4}')", null, usu.nombre, usu.nickname, usu.contrasenya, imagenString);

            MessageBox.Show(consulta);

            MySqlCommand comando = new MySqlCommand(consulta, Conexion.Con);

            Conexion.AbrirConexion();
            retorno = comando.ExecuteNonQuery();
            Conexion.CerrarConexion();

            return retorno;
        }

        public static bool ExisteUsuario(string usuario)
        {
            bool existe;

            string consulta = String.Format("SELECT * FROM `Usuario` WHERE `nombre_usuario` LIKE '{0}'", usuario);

            MessageBox.Show(consulta);

            MySqlCommand comando = new MySqlCommand(consulta, Conexion.Con);

            Conexion.AbrirConexion();
            MySqlDataReader reader = comando.ExecuteReader();

            if (reader.HasRows)
                existe = true;
            else
                existe = false;

            Conexion.CerrarConexion();

            return existe;
        }

        public static bool ExisteUsuario(string usuario, string contrasenya)
        {
            bool existe;

            string consulta = String.Format("SELECT * FROM `Usuario` WHERE `nickname` LIKE '{0}' AND `contrasenya` LIKE '{1}'", usuario, contrasenya);

            MessageBox.Show(consulta);

            MySqlCommand comando = new MySqlCommand(consulta, Conexion.Con);

            Conexion.AbrirConexion();
            MySqlDataReader reader = comando.ExecuteReader();

            if (reader.HasRows)
                existe = true;
            else
                existe = false;

            Conexion.CerrarConexion();

            return existe;
        }
    }
}
