using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class ListaCircularTests
{
    [TestMethod]
    public void InsertarAlInicio_Test()
    {
        var lista = new ListaCircular();
        lista.InsertarAlInicio(10);
        lista.InsertarAlInicio(20);
        lista.InsertarAlInicio(30);

        Assert.AreEqual("30, 20, 10", lista.ToString());
    }

    [TestMethod]
    public void InsertarAlFinal_Test()
    {
        var lista = new ListaCircular();
        lista.InsertarAlFinal(10);
        lista.InsertarAlFinal(20);
        lista.InsertarAlFinal(30);

        Assert.AreEqual("10, 20, 30", lista.ToString());
    }

    [TestMethod]
    public void InsertAt_Test()
    {
        var lista = new ListaCircular();
        lista.InsertarAlFinal(10);
        lista.InsertarAlFinal(30);
        lista.InsertAt(20, 1);

        Assert.AreEqual("10, 20, 30", lista.ToString());
    }

    [TestMethod]
    public void EliminarAlInicio_Test()
    {
        var lista = new ListaCircular();
        lista.InsertarAlFinal(10);
        lista.InsertarAlFinal(20);
        lista.InsertarAlFinal(30);
        lista.EliminarAlInicio();

        Assert.AreEqual("20, 30", lista.ToString());
    }

    [TestMethod]
    public void EliminarAlFinal_Test()
    {
        var lista = new ListaCircular();
        lista.InsertarAlFinal(10);
        lista.InsertarAlFinal(20);
        lista.InsertarAlFinal(30);
        lista.EliminarAlFinal();

        Assert.AreEqual("10, 20", lista.ToString());
    }

    [TestMethod]
    public void EliminarEn_Test()
    {
        var lista = new ListaCircular();
        lista.InsertarAlFinal(10);
        lista.InsertarAlFinal(20);
        lista.InsertarAlFinal(30);
        lista.EliminarEn(1);

        Assert.AreEqual("10, 30", lista.ToString());
    }

    [TestMethod]
    public void ObtenerTamaño_Test()
    {
        var lista = new ListaCircular();
        lista.InsertarAlFinal(10);
        lista.InsertarAlFinal(20);
        lista.InsertarAlFinal(30);

        Assert.AreEqual(3, lista.ObtenerTamaño());
    }

    [TestMethod]
    public void ToString_Test()
    {
        var lista = new ListaCircular();
        lista.InsertarAlFinal(10);
        lista.InsertarAlFinal(20);
        lista.InsertarAlFinal(30);

        Assert.AreEqual("10, 20, 30", lista.ToString());
    }
}