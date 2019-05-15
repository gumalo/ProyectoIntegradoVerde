using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

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

        public static bool IniciadaSesion(int id)
        {
            
        }
    }
}
