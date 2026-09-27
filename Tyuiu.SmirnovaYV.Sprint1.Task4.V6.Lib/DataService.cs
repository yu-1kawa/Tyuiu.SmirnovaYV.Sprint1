using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.SmirnovaYV.Sprint1.Task4.V6.Lib
{
    public class DataService : ISprint1Task4V6
    {
        public double Calculate(double x, double y)
        {
            var res = Math.Round((Math.Abs((Math.Pow(y, 2) - x))) / (x * y),3);
            return res; 
        } 
    } 
}
