using Microsoft.VisualStudio.TestTools.UnitTesting;
using CardioLibrary;

namespace DataCardio_test
{
    [TestClass]
    public class Cardio_test
    {
        [TestMethod]
        public void BattitiTest1()
        {
            int bpm = 190;
            double FrequenzaBattiti = DataCardio.MaxBattiti(30);
            Assert.AreEqual(bpm, FrequenzaBattiti);
        }
    }
}
