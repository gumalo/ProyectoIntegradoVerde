using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoEquipoVerde
{
    static class LoginInfo
    {
        private static int idUserLogged;

        public static int IdUserLogged { get => idUserLogged; set => idUserLogged = value; }

        public static bool IniciadaSesion(int id)
        {
            if (IdUserLogged == id)
                return true;
            else
                return false;
        }

        public static void IniciarSesion(string nomUsuario)
        {
            string consulta = String.Format("SELECT `id_usuario` FROM `Usuario` WHERE `nombre_usuario` LIKE '{0}'", nomUsuario);

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
