using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoEquipoVerde
{
    public class LoginInfo
    {
        private static int idUserLogged;
        private static string cultura;

        public static int IdUserLogged { get => idUserLogged; set => idUserLogged = value; }
        public static string Cultura { get => cultura; set => cultura = value; }

        public LoginInfo() { }

        public static bool IniciadaSesion(int id)
        {
            if (IdUserLogged == id)
                return true;
            else
                return false;
        }

        public static void IniciarSesion(string nomUsuario)
        {
            string consulta = String.Format("SELECT `id_usuario` FROM `Usuario` WHERE nickname LIKE '{0}'", nomUsuario);

            MySqlCommand comando = new MySqlCommand(consulta, Conexion.Con);

            Conexion.AbrirConexion();
            MySqlDataReader reader = comando.ExecuteReader();

            if (reader.HasRows)
                while (reader.Read())
                    idUserLogged = reader.GetInt16(0);
            Conexion.CerrarConexion();
        }

        public static void CerrarSesion()
        {
            idUserLogged = 0;
        }
    }
}
