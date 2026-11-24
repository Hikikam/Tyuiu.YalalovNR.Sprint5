using System;
using System.IO;
using Tyuiu.YalalovNR.Sprint5.Task1.V21.Lib;

namespace Tyuiu.YalalovNR.Sprint5.Task1.V21
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine($"Старт шага = {startValue}");
            Console.WriteLine($"Конец шага = {stopValue}");

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res = ds.SaveToFileTextData(startValue, stopValue);

            Console.WriteLine($"Файл: {res}");
            Console.WriteLine("Создан!");
            Console.WriteLine();

            string[] lines = File.ReadAllLines(res);

            Console.WriteLine("+----------+----------+");
            Console.WriteLine("|    X     |   f(x)   |");
            Console.WriteLine("+----------+----------+");

            int x = startValue;
            for (int i = 0; i < lines.Length; i++)
            {
                Console.WriteLine("|{0,5:d}     |  {1, 6}  |", x, lines[i]);
                x++;
            }

            Console.WriteLine("+----------+----------+");

            Console.ReadKey();
        }
    }
}
