using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.YalalovNR.Sprint5.Task6.V23.Lib
{
    public class DataService : ISprint5Task6V23
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0;
            string text = File.ReadAllText(path);

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '-')
                {
                    count++;
                }
            }

            return count;
        }
    }
}
