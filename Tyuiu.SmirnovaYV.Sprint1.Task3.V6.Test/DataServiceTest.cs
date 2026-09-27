using Tyuiu.SmirnovaYV.Sprint1.Task3.V6.Lib;
namespace Tyuiu.SmirnovaYV.Sprint1.Task3.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double distance = 67;
            double gasFlow = 8.5;
            double gasPrice = 6.5;
            double wait = 74.035;
            var res =  ds.TravelCost(distance, gasFlow, gasPrice);
            Assert.AreEqual(wait , res);

        }
    }
}
