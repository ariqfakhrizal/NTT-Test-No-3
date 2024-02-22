namespace NTT_Test_No_3.MSTest
{
    [TestClass]
    public class UnitTestNo3
    {
        [TestMethod]
        public void SoalA_FunctionHitungFaktor_ReturnTrue()
        {
            int z = 6;

            var result = NTT.NTT_Test_No_3.functionHitungFaktor(z);
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void SoalB_FunctionHitungFaktor_ReturnTrue()
        {
            int z = 10;

            var result = NTT.NTT_Test_No_3.functionHitungFaktor(z);
            Assert.AreEqual(4, result);
        }
    }
}