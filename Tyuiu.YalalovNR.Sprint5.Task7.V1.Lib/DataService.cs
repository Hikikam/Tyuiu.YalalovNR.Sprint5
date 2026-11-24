using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.YalalovNR.Sprint5.Task7.V1.Lib
{
    public class DataService : ISprint5Task7V1
    {
        public string LoadDataAndSave(string path)
        {
            string pathSaveFile = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V1.txt");

            if (File.Exists(pathSaveFile))
            {
                File.Delete(pathSaveFile);
            }

            string text = File.ReadAllText(path);
            string newText = "";

            for (int i = 0; i < text.Length; i++)
            {
                if (!char.IsDigit(text[i]))
                {
                    newText += text[i];
                }
            }

            File.WriteAllText(pathSaveFile, newText);
            return pathSaveFile;
        }
    }
}
