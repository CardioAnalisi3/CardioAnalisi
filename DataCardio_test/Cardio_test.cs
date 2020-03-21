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
        
        [TestMethod]
        public void TestCalcoloMaxBattitiPalestra()
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
        [TestMethod]
        public void TestCalorieBruciateUomo()
        {
            double CalorieBruciate = DataCardio.CalorieBruciateUomo(45, 70, 90, 16);
            double ris_aspettato= 566.70;
            Assert.AreEqual(ris_aspettato, CalorieBruciate);
        }
        [TestMethod]
        public void TestCalorieBruciateDonna()
        {
            double CalorieBruciate = DataCardio.CalorieBruciateDonna(45, 70, 95, 18);
            double ris_aspettato = 620.48;
            Assert.AreEqual(ris_aspettato, CalorieBruciate);
        }
        [TestMethod]
        public void TestSpesaEnergeticaCorsa()
        {
            double SpesaEnergetica = DataCardio.SpesaEnergeticaCorsa(5, 70);
            double ris_aspettato = 74.5;
            Assert.AreEqual(ris_aspettato, SpesaEnergetica);
        }
        [TestMethod]
        public void TestSpesaEnergeticaCamminata()
        {
            double SpesaEnergetica = DataCardio.SpesaEnergeticaCorsa(5, 70);
            double ris_aspettato = 72.5;
            Assert.AreEqual(ris_aspettato, SpesaEnergetica);
        }
        [TestMethod]
        public void TestCalcoloMediaBattitiAlGiorno()
        {
            int[] battitiorari = new int [4] {43 ,36 ,48 ,32 };
            double media;
            media = DataCardio.CalcoloMediaBattitiAlGiorno(battitiorari);
            double ris_aspettato = 39.75;
            Assert.AreEqual(ris_aspettato, media);
        }
        [TestMethod]
        public void TestCalcoloBattitiARiposo()
        {
            int[] BattitiARiposo = new int [4] {42 ,34 ,45 ,35 };
            double media;
            media = DataCardio.CalcoloBattitiARiposo(BattitiARiposo);
            double ris_aspettato = 39;
            Assert.AreEqual(ris_aspettato, media);
        }
    }
}
