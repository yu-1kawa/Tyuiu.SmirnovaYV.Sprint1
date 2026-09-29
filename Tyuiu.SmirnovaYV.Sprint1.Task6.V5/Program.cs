using System.ComponentModel.Design;
using Tyuiu.SmirnovaYV.Sprint1.Task6.V5.Lib;
namespace Tyuiu.SmirnovaYV.Sprint1.Task6.V5
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
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #5                                                              *");
            Console.WriteLine("* Выполнила: Смирнова Юлия Валерьевна | АСОиУБ-26-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Напечатать те слова, которые являются симметричными, из тех что ввели   *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите текст                                                              ");
            string input = Console.ReadLine();
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine("***************************************************************************");
            string result = ds.CheckSymmetricalWords(input);
            if (result == "")
            {
                Console.WriteLine("Симметричных слов не найдено.");
            }
            else
            {
                Console.WriteLine("Симметричные слова:" + result);
            }
            Console.ReadKey();

        }
    }
}
