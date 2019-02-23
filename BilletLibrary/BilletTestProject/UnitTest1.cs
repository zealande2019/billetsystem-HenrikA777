using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BilletTestProject
{
    using System;

    using BilletLibrary;

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void NummerpladeTestBil_string()
        {
            string nummerplade = "abc123";
            Bil bil = new Bil(nummerplade, DateTime.Today, false);
            
            Assert.AreEqual(bil.Nummerplade, nummerplade);
        }
        [TestMethod]
        public void DatoTestBil_Today()
        {
            string nummerplade = "abc123";
            Bil bil = new Bil(nummerplade, DateTime.Today, false);

            Assert.AreEqual(bil.Dato, DateTime.Today);
        }
        [TestMethod]
        public void PrisTestBil_decimal()
        {
            string nummerplade = "abc123";
            Bil bil = new Bil(nummerplade, DateTime.Today, false);

            Assert.AreEqual(bil.Pris(), 240);
        }
        [TestMethod]
        public void BilType_string()
        {
            string nummerplade = "abc123";
            Bil bil = new Bil(nummerplade, DateTime.Today, false);

            Assert.AreEqual(bil.Type(), "Bil");
        }
        [TestMethod]
        public void NummerpladeTestMC_string()
        {
            string nummerplade = "abc123";
            MC mc = new MC(nummerplade, DateTime.Today, false);

            Assert.AreEqual(mc.Nummerplade, nummerplade);
        }
        [TestMethod]
        public void DatoTestMC_Today()
        {
            string nummerplade = "abc123";
            MC mc = new MC(nummerplade, DateTime.Today, false);

            Assert.AreEqual(mc.Dato, DateTime.Today);
        }
        [TestMethod]
        public void PrisTestMC_decimal()
        {
            string nummerplade = "abc123";
            MC mc = new MC(nummerplade, DateTime.Today, false);

            Assert.AreEqual(mc.Pris(), 125);
        }
        [TestMethod]
        public void MCType_string()
        {
            string nummerplade = "abc123";
            MC mc = new MC(nummerplade, DateTime.Today, false);

            Assert.AreEqual(mc.Type(), "MC");
        }
        [TestMethod]
        public void NummerpladeTooLong_Exception()
        {
            Assert.ThrowsException<ArgumentException>((() => new MC("12345678", DateTime.Today, false)));
        }
        [TestMethod]
        public void BrobizzRabat_decimal()
        {
            string nummerplade = "abc123";
            MC mc = new MC(nummerplade, DateTime.Today, true);

            Assert.AreEqual(125 - 125 * 0.05, Convert.ToDouble(mc.Pris()), 0.1);
        }
    }
}
