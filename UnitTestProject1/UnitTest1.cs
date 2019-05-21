using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades.Estacionamientos.starter;

namespace UnitTestProject1
{
  [TestClass]
  public class UnitTest1
  {
    [TestMethod]
    public void TestMethod1()
    {
      Estacionamiento e1 = new Estacionamiento(5);
      
      Assert.IsNotNull(e1.Autos);
    }
    [TestMethod]
    public void EspacioEstacionamientoIncorrecto()
    {
      Estacionamiento e = new Estacionamiento(101);
      Estacionamiento e2 = new Estacionamiento(0);

      if (e.EspacioDisponible == 100)
        Assert.Fail("El espacio es incorrecto {0}", e.EspacioDisponible);

      Assert.AreNotEqual(e2.EspacioDisponible, 1);

      if (e2.EspacioDisponible != 0)
        Assert.Fail("Esta mal validado el limite inferior");
    }

    [TestMethod]
    public void AgregarAutos()
    {
      Estacionamiento e = new Estacionamiento(2);
      Auto a1 = new Auto("DSA 314", ConsoleColor.Black);
      Auto a2 = new Auto("GRE 643", ConsoleColor.Blue);
      Auto a3 = new Auto("RGK 475", ConsoleColor.Green);

      try
      {
        e += a1;
        e += a2;
        e += a3;

        Assert.Fail("Se agregaron mas autos que el espacio disponible");
      }
      catch (Exception exc)
      {
        Assert.IsInstanceOfType(exc, typeof(EstacionamientoLlenoException));

      }
    }

    [TestMethod]
    public void AgregarAutoEspacioDisponible()
    {
      Estacionamiento e = new Estacionamiento(2);
      Auto a1 = new Auto("DSA 314", ConsoleColor.Black);
      Auto a2 = new Auto("GRE 643", ConsoleColor.Blue);

      e += a1;

      Assert.AreEqual(e.EspacioDisponible, 1);

      e += a2;

      Assert.AreEqual(e.EspacioDisponible, 0);
    }

  }
}
