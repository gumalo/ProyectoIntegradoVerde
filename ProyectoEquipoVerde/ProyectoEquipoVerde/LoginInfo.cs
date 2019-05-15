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
    }
}
