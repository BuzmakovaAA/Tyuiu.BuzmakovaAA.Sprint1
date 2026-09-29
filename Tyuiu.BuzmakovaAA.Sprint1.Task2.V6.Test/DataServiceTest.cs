using Tyuiu.BuzmakovaAA.Sprint1.Task2.V6.Lib;
namespace Tyuiu.BuzmakovaAA.Sprint1.Task2.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int value = 1000;
            var res = ds.Calculate(value);
            Assert.AreEqual(1, res);
        }
    }
}
