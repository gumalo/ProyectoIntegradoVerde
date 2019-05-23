using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.IO;
using System.Data;
using System.Drawing.Imaging;

namespace ProyectoEquipoVerde
{
    class Usuario
    {
        private int id;
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

        public Usuario() { }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Nickname { get => nickname; set => nickname = value; }
        public string Contrasenya { get => contrasenya; set => contrasenya = value; }
        public Image Imagen { get => imagen; set => imagen = value; }
        public int Id { get => id; set => id = value; }

        public static int AgregarUsuario(Usuario usu)
        {
            int retorno;

            MemoryStream ms = new MemoryStream();
            usu.Imagen.Save(ms, ImageFormat.Jpeg);
            byte[] img = ms.ToArray();

            string consulta = String.Format("INSERT INTO `Usuario` (`id_usuario`, `nombre_usuario`, `nickname`, `contrasenya`, `foto_perfil`) VALUES " +
                "('{0}','{1}','{2}','{3}',@imagen)", null, usu.nombre, usu.nickname, usu.contrasenya);

            MySqlCommand comando = new MySqlCommand(consulta, Conexion.Con);
            comando.Parameters.AddWithValue("imagen", img);

            Conexion.AbrirConexion();
            retorno = comando.ExecuteNonQuery();
            Conexion.CerrarConexion();

            return retorno;
        }

        public static bool ExisteUsuario(string usuario)
        {
            bool existe;

            string consulta = String.Format("SELECT * FROM `Usuario` WHERE `nickname` LIKE '{0}'", usuario);

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

        public static Usuario BuscarUsuario(int id)
        {
            string consulta = String.Format("SELECT * FROM `Usuario` WHERE `id_usuario` = {0}", id);

            MySqlCommand comando = new MySqlCommand(consulta, Conexion.Con);

            Conexion.AbrirConexion();
            MySqlDataReader reader = comando.ExecuteReader();

            Usuario usuario = new Usuario();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    byte[] img = (byte[])reader[4];
                    MemoryStream ms = new MemoryStream(img);
                    Image foto = Image.FromStream(ms);

                    usuario.Nombre = reader.GetString(1);
                    usuario.Nickname = reader.GetString(2);
                    usuario.Contrasenya = reader.GetString(3);
                    usuario.Imagen = foto;
                }
            }
            Conexion.CerrarConexion();

            return usuario;
        }

        public static DataTable CargarTodosUsuarios()
        {
            string consulta = String.Format("SELECT `Usuario`.`id_usuario` AS ID, `Usuario`.`nickname` AS Nick, `Usuario`.`nombre_usuario` AS Nombre, (SELECT COUNT(*) FROM Critica WHERE Usuario.id_usuario = Critica.usu_critica) AS Criticas " +
                "FROM `Usuario` LEFT JOIN Critica ON Usuario.id_usuario = Critica.usu_critica GROUP BY Usuario.id_usuario");

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

        public static DataTable BuscarUsuarios(string busqueda)
        {
            string consulta = String.Format("SELECT `Usuario`.`id_usuario` AS ID, `Usuario`.`nickname` AS Nick, `Usuario`.`nombre_usuario` AS Nombre, (SELECT COUNT(*) FROM Critica WHERE Usuario.id_usuario = Critica.usu_critica) AS Criticas " +
                "FROM `Usuario` LEFT JOIN Critica ON Usuario.id_usuario = Critica.usu_critica WHERE nickname LIKE '%{0}%' OR nombre_usuario LIKE '%{0}%' GROUP BY Usuario.id_usuario", busqueda);

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

        public static DataTable CargarPelisUsuario(int id)
        {
            string consulta = String.Format("SELECT Pelicula.id_peli AS ID, Pelicula.nombre_peli AS Titulo, Critica.valoracion_critica AS Puntuacion FROM Pelicula INNER JOIN Critica ON Pelicula.id_peli = Critica.peli_critica WHERE Critica.usu_critica = {0}", id);

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

        public static DataTable CargarCriticasUsuario(int id)
        {
            string consulta = String.Format("SELECT id_critica AS ID, valoracion_critica AS Puntuacion, coment_critica AS Critica, tag_1 AS Tag, Pelicula.nombre_peli AS Pelicula, fecha AS Fecha" +
                " FROM `Critica` INNER JOIN Pelicula ON peli_critica = Pelicula.id_peli WHERE usu_critica = {0}", id);

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

        public static int ModificarUsuario(int id, string nickname, string nombre, string contrasenya, Image imagenPerfil)
        {
            int retorno;

            MemoryStream ms = new MemoryStream();
            imagenPerfil.Save(ms, ImageFormat.Jpeg);
            byte[] img = ms.ToArray();

            string consulta = String.Format("UPDATE `Usuario` SET `nombre_usuario` = '{0}', `nickname` = '{1}', `contrasenya` = '{2}'," +
                " `foto_perfil` = @imagen WHERE id_usuario = {3}", nickname, nombre, contrasenya, id);

            MySqlCommand comando = new MySqlCommand(consulta, Conexion.Con);
            comando.Parameters.AddWithValue("imagen", img);

            Conexion.AbrirConexion();
            retorno = comando.ExecuteNonQuery();
            Conexion.CerrarConexion();

            return retorno;
        }

        public static List<Usuario> CargarUsuariosPorNumCriticas()
        {
            string consulta = String.Format("SELECT `Usuario`.`id_usuario` AS ID, foto_perfil AS Imagen, (SELECT COUNT(*) FROM Critica WHERE Usuario.id_usuario = Critica.usu_critica) AS Criticas " +
                "FROM `Usuario` LEFT JOIN Critica ON Usuario.id_usuario = Critica.usu_critica GROUP BY Usuario.id_usuario ORDER BY Criticas DESC");

            MySqlCommand comando = new MySqlCommand(consulta, Conexion.Con);

            Conexion.AbrirConexion();
            MySqlDataReader reader = comando.ExecuteReader();

            List<Usuario> lista = new List<Usuario>();

            Usuario usuarioTemp;

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    byte[] num = (byte[])reader[1];
                    MemoryStream ms = new MemoryStream(num);
                    Image returnImage = Image.FromStream(ms);
                    Image image = returnImage;

                    usuarioTemp = new Usuario();
                    usuarioTemp.id = reader.GetInt32(0);
                    usuarioTemp.imagen = image;

                    lista.Add(usuarioTemp);
                }
            }
            Conexion.CerrarConexion();

            return lista;
        }
    }
}
