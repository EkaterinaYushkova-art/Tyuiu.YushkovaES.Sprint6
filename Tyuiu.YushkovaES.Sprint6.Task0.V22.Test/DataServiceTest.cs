using Tyuiu.YushkovaES.Sprint6.Task0.V22.Lib;
namespace Tyuiu.YushkovaES.Sprint6.Task0.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(2);
            double wait = 11.68;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCalculateAtZero()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(0);
            double wait = 0;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCalculateAtOne()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(1);
            double wait = 2.22;
            Assert.AreEqual(wait, res);
        }
    }
    
}
