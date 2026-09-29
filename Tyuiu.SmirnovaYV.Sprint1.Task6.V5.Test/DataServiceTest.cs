using Tyuiu.SmirnovaYV.Sprint1.Task6.V5.Lib;
namespace Tyuiu.SmirnovaYV.Sprint1.Task6.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            DataService ds=new DataService();
            string strTest = "казак шалаш привет топот";
            string res = ds.CheckSymmetricalWords(strTest);
            string wait = "казак шалаш топот";
            Assert.AreEqual(wait, res);
        }
    }
}
