using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataCardio_test
{
    [TestClass]
    public class Cardio_test
    {
        [TestMethod]
        public void TestCalcoloMaxBattitiCardiaci()
        {
            double risultato =DataCardio.CalcoloMaxBattitiCardiaci(16);
            Assert.AreEqual(204,risultato);
        }
        
        [TestMethod]oMaxBattitiPalestra()
        {
            double risultato = DataCardio.CalcoloMaxBattitiPalestra(16);
            Assert.AreEqual(183.6, risultato); 
        }

        [TestMethod]
        public void TestCalcoloMinBaiottitiPalestra()
        {
            double risultato = DataCardio.CalcoloMinBattitiPalestra(16);
            Assert.AreEqual(142.8,risultato);
        }

        [TestMethod]
        public void TestBattiti_Riposo()
        {
            string risultato = DataCardio.Battiti_Riposo(101);
            Assert.AreEqual("Tachicardia", risultato);
        }
    }
}
