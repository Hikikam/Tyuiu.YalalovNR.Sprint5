using System;
using System.IO;
using Tyuiu.YalalovNR.Sprint5.Task3.V13.Lib;

namespace Tyuiu.YalalovNR.Sprint5.Task3.V13
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
            Console.WriteLine("Создан!");

            using (BinaryReader reader = new BinaryReader(File.Open(res, FileMode.Open)))
            {
                Console.WriteLine($"Значение выражения = {reader.ReadDouble()}");
            }

            Console.ReadKey();
        }
    }
}
