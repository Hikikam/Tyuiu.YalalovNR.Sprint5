using System;
using System.Globalization;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.YalalovNR.Sprint5.Task5.V17.Lib
{
    public class DataService : ISprint5Task5V17
    {
        public double LoadFromDataFile(string path)
        {
            double sum = 0;
            string text = File.ReadAllText(path);
            string[] items = text.Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < items.Length; i++)
            {
                string str = items[i].Replace(',', '.');
                double num = double.Parse(str, CultureInfo.InvariantCulture);

                if (num % 1 == 0 && num > 1)
                {
                    int n = (int)num;
                    bool isPrime = true;

                    for (int j = 2; j < n; j++)
                    {
                        if (n % j == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }

                    if (isPrime)
                    {
                        sum += n;
                    }
                }
            }

            return Math.Round(sum, 3);
        }
    }
}
