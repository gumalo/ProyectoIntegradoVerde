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

                        string server = "server=proyectoverde.cbuicy56smab.us-east-1.rds.amazonaws.com;";
                        string oldguids = "oldguids=true;";
                        string database = "database=proyectoverde;";
                        string usuario = "uid=admin;";
                        string password = "pwd=proyectoverde;";
                        string connectionstring = server + oldguids + database + usuario + password;

                        instancia.ConnectionString = connectionstring;


                            // "Data Source = proyectoverde.cbuicy56smab.us-east-1.rds.amazonaws.com; database=proyectoverde; User ID = admin; Password = proyectoverde; port=3306;";
                    }

                    return instancia;
                }
            }
        }


        public static void AbrirConexion()
        {
            if (instancia != null)
                instancia.Open();
        }

        public static void CerrarConexion()
        {
            if (instancia != null)
                instancia.Close();
        }
    }
}
