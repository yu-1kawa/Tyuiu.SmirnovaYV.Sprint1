using Tyuiu.SmirnovaYV.Sprint1.Task3.V6.Lib;
namespace Tyuiu.SmirnovaYV.Sprint1.Task3.V6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1| Выполнила: Смирнова Ю.В.| АСОиУБ-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт#1                                                                *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #6                                                              *");
            Console.WriteLine("* Выполнила: Смирнова Юлия Валерьевна | АСОиУБ-26-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу вычисления стоимости поездки на автомобиле на дачу   *");
            Console.WriteLine("* Ответ округлите до 3 знаков после запятой.                              *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            double distance = 67;
            double gasFlow = 8.5;
            double gasPrice = 6.5;
            Console.WriteLine("Расстояние до дачи (км) =" + distance);
            Console.WriteLine("Расход бензина (литров на 100 км пробега) =" + gasFlow);
            Console.WriteLine("Цена литра бензина (руб.)  =" + gasPrice);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Стоимость поездки на автомобиле на дачу (туда и обратно) =" + ds.TravelCost(distance, gasFlow, gasPrice));
            Console.ReadKey();

        }
    }
}
