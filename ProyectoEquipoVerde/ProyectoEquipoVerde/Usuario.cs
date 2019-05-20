﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.IO;
using System.Data;

namespace ProyectoEquipoVerde
{
    public class Usuario
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

        public Usuario() { }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Nickname { get => nickname; set => nickname = value; }
        public string Contrasenya { get => contrasenya; set => contrasenya = value; }
        public Image Imagen { get => imagen; set => imagen = value; }

        public static int AgregarUsuario(Usuario usu)
        {
            int retorno;

            ImageConverter converter = new ImageConverter();
            byte[] imagenByteArray = (byte[])converter.ConvertTo(usu.imagen, typeof(byte[]));
            string imagenString = BitConverter.ToString(imagenByteArray).Replace("-", "");

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
                    byte[] num = (byte[])reader[4];
                    MemoryStream ms = new MemoryStream(num);
                    Image returnImage = Image.FromStream(ms);
                    Image image = returnImage;

                    usuario.Nombre = reader.GetString(1);
                    usuario.Nickname = reader.GetString(2);
                    usuario.Contrasenya = reader.GetString(3);
                    usuario.Imagen = image;
                }
            }
            Conexion.CerrarConexion();

            return usuario;
        }

        public static DataTable CargarTodosUsuarios()
        {
            string consulta = String.Format("SELECT `Usuario`.`id_usuario` AS ID, `Usuario`.`nickname` AS Nick, `Usuario`.`nombre_usuario` AS Nombre, (SELECT COUNT(*) FROM Critica WHERE Usuario.id_usuario = Critica.usu_critica) AS Criticas FROM `Usuario` LEFT JOIN Critica ON Usuario.id_usuario = Critica.usu_critica GROUP BY Usuario.id_usuario");

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
            string consulta = String.Format("SELECT id_critica AS ID, valoracion_critica AS Puntuacion, coment_critica AS Critica, tag_1 AS Tag, Pelicula.nombre_peli AS Pelicula, fecha AS Fecha FROM `Critica` INNER JOIN Pelicula ON peli_critica = Pelicula.id_peli WHERE usu_critica = {0}", id);

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
