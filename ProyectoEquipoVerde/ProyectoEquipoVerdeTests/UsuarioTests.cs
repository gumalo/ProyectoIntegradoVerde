using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProyectoEquipoVerde;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoEquipoVerde.Tests
{
    [TestClass()]
    public class UsuarioTests
    {
        [TestMethod()]
        public void ExisteUsuarioTest()
        {
            string nickUser = "gumalo";

            bool resultado = Usuario.ExisteUsuario(nickUser);

            Assert.IsTrue(resultado);
        }

        [TestMethod()]
        public void ExisteUsuarioTest1()
        {
            string nickUser = "gumalo";
            string pass = "tola";

            bool resultado = Usuario.ExisteUsuario(nickUser, pass);

            Assert.IsTrue(resultado);
        }
    }
}