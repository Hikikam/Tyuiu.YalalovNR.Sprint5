using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.YalalovNR.Sprint5.Task2.V24.Lib
{
    public class DataService : ISprint5Task2V24
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask2.csv");
            string text = "";

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (matrix[i, j] > 0) matrix[i, j] = 1;
                    if (matrix[i, j] < 0) matrix[i, j] = 0;

                    text += matrix[i, j];
                    if (j < 2) text += ";";
                }
                if (i < 2) text += Environment.NewLine;
            }

            File.WriteAllText(path, text);
            return path;
        }
    }
}
