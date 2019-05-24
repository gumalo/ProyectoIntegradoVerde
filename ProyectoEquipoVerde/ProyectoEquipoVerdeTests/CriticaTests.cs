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
    public class CriticaTests
    {
        [TestMethod()]
        public void ExisteCriticaTest()
        {
            int idUser = 8;
            int idPeli = 32;

            bool resEsperado = true;

            bool resultado = Critica.ExisteCritica(idUser, idPeli);

            Assert.AreEqual(resEsperado, resultado);
        }
    }
}