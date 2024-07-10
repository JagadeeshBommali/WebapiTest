namespace TestProject2
{
    using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using WebApiCodeTest;

    [TestClass]
    public class UnitTest1
    {
        private const string Expected1 = "1";
        private const string Expected2 = "6";
        [TestMethod]
        public void TestMethod1()
        {
            ShapeCalculationService msg = new ShapeCalculationService();
            var m1= msg.CalculateShapeMeasurements();

            Assert.AreEqual(Expected1, m1);
        }
        public void TestMethod2()
        {
            ShapeCalculationService msg = new ShapeCalculationService();
            var m1 = msg.CalculateShapeMeasurements();

            Assert.AreEqual(Expected2, m1);
        }
    }
}