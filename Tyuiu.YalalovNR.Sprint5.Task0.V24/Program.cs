using System;
using System.IO;
using Tyuiu.YalalovNR.Sprint5.Task0.V24.Lib;

namespace Tyuiu.YalalovNR.Sprint5.Task0.V24
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x = 3;
            Console.WriteLine($"x = {x}");

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res = ds.SaveToFileTextData(x);

            Console.WriteLine($"Файл: {res}");
            Console.WriteLine("Создан");
            Console.WriteLine($"Значение выражения = {File.ReadAllText(res)}");

            Console.ReadKey();
        }
    }
}
