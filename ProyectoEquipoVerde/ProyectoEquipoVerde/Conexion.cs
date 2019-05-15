using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProyectoEquipoVerde
{
    class Conexion
    {
        private static MySqlConnection instancia = null;
        private static readonly object padlock = new object();

        private Conexion() { }
        public static MySqlConnection Con
        {
            get
            {
                lock (padlock)
                {
                    if (instancia == null)
                    {
                        instancia = new MySqlConnection();
                        //Pendiente cambiar datos de la conexion
                        instancia.ConnectionString = "server=127.0.0.1;port=3306;" +
                            "database=miempresa;uid=root;pwd=;";
                    }
                    return instancia;
                }
            }
        }


        public static void AbrirConexion()
        {
            if (instancia != null)
            {
                instancia.Open();
            }
        }

        public static void CerrarConexion()
        {
            if (instancia != null)
            {
                instancia.Close();
            }
        }

    }
}
