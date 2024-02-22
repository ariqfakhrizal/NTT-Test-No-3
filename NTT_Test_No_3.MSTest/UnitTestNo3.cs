namespace NTT_Test_No_3.MSTest
{
    [TestClass]
    public class UnitTestNo3
    {
        [TestMethod]
        [DataRow(6)]
        public void SoalA_FunctionHitungFaktor_ReturnEqual(int numberEnteredTestZ)
        {
            var actualResult = NTT.NTT_Test_No_3.functionHitungFaktor(numberEnteredTestZ);
            int expectedResult = 4;
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        [DataRow(10)]
        public void SoalB_FunctionHitungFaktor_ReturnTrue(int numberEnteredTestZ)
        {
            var actualResult = NTT.NTT_Test_No_3.functionHitungFaktor(numberEnteredTestZ);
            int expectedResult = 4;
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}