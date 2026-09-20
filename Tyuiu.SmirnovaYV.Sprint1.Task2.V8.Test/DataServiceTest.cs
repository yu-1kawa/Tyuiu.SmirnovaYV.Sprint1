using Tyuiu.SmirnovaYV.Sprint1.Task2.V8.Lib;
namespace Tyuiu.SmirnovaYV.Sprint1.Task2.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int a = 2;
            int b = 3;
            var res = ds.CalculatePerimetr(a, b);
            Assert.AreEqual(10, res);
        }
    }
}
