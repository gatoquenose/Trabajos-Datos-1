using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Listadoblementecircular.Tests
{
    [TestClass]
    public class ListaDoblementeCircularTests
    {
        [TestMethod]
        public void Insertaralprincipio_ShouldAddNodeAtBeginning()
        {
            // Arrange
            var lista = new ListaDoblementeCircular();

            // Act
            lista.Insertaralprincipio(10);
            lista.Insertaralprincipio(20);

            // Assert
            Assert.AreEqual("20, 10", lista.ToString());
        }

        [TestMethod]
        public void Insertaralfinal_ShouldAddNodeAtEnd()
        {
            // Arrange
            var lista = new ListaDoblementeCircular();

            // Act
            lista.Insertaralfinal(10);
            lista.Insertaralfinal(20);

            // Assert
            Assert.AreEqual("10, 20", lista.ToString());
        }

        [TestMethod]
        public void InserAt_ShouldAddNodeAtIndex()
        {
            // Arrange
            var lista = new ListaDoblementeCircular();
            lista.Insertaralfinal(10);
            lista.Insertaralfinal(20);
            lista.Insertaralfinal(30);

            // Act
            lista.InserAt(15, 1);

            // Assert
            Assert.AreEqual("10, 15, 20, 30", lista.ToString());
        }

        [TestMethod]
        public void EliminarPrimero_ShouldRemoveFirstNode()
        {
            // Arrange
            var lista = new ListaDoblementeCircular();
            lista.Insertaralprincipio(10);
            lista.Insertaralprincipio(20);

            // Act
            lista.EliminarPrimero();

            // Assert
            Assert.AreEqual("10", lista.ToString());
        }

        [TestMethod]
        public void EliminarUltimo_ShouldRemoveLastNode()
        {
            // Arrange
            var lista = new ListaDoblementeCircular();
            lista.Insertaralprincipio(10);
            lista.Insertaralprincipio(20);

            // Act
            lista.EliminarUltimo();

            // Assert
            Assert.AreEqual("20", lista.ToString());
        }

        [TestMethod]
        public void EliminarEn_ShouldRemoveNodeAtIndex()
        {
            // Arrange
            var lista = new ListaDoblementeCircular();
            lista.Insertaralprincipio(10);
            lista.Insertaralprincipio(20);
            lista.Insertaralprincipio(30);

            // Act
            lista.EliminarEn(1);

            // Assert
            Assert.AreEqual("30, 10", lista.ToString());
        }

        [TestMethod]
        public void ObtenerTamaño_ShouldReturnCorrectSize()
        {
            // Arrange
            var lista = new ListaDoblementeCircular();
            lista.Insertaralprincipio(10);
            lista.Insertaralprincipio(20);

            // Act
            int size = lista.ObtenerTamaño();

            // Assert
            Assert.AreEqual(2, size);
        }

        [TestMethod]
        public void ToString_ShouldReturnCorrectStringRepresentation()
        {
            // Arrange
            var lista = new ListaDoblementeCircular();
            lista.Insertaralprincipio(10);
            lista.Insertaralprincipio(20);

            // Act
            string result = lista.ToString();

            // Assert
            Assert.AreEqual("20, 10", result);
        }
    }
}