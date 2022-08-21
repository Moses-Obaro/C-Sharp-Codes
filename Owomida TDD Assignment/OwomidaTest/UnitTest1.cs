using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OwomidaForms;

namespace OwomidaTDD
{
    [TestClass]
    public class OwomidaTest
    {
        [TestMethod]
        [DataRow(2, "Bus","Yes", 1400)]
        [DataRow(2, "Bus", "No", 2000)]
        [DataRow(5, "Motorcycle","Yes", 700)]
        [DataRow(5, "Motorcycle", "No", 1000)]
        [DataRow(3, "Tricycle", "Yes", 1050)]
        [DataRow(3, "Tricycle", "No", 1500)]
        [DataRow(3, "MiniBus", "Yes", 1680)]
        [DataRow(3, "MiniBus", "No", 2400)]
        public void testToll(int numTrips, string vehicle, string membership, double expectedToll)
        {
            Owomida owo = new Owomida();             
            double calculatedTolls = owo.CalcTolls(numTrips, vehicle, membership);

            Assert.AreEqual<double>(expectedToll, calculatedTolls);
        }

        
    }



}
