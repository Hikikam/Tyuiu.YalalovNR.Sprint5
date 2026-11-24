using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.YalalovNR.Sprint5.Task2.V24.Lib;

namespace Tyuiu.YalalovNR.Sprint5.Task2.V24.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            DataService ds = new DataService();

            int[,] matrix = new int[3, 3]
            {
                { 6, 0, 6 },
                { -1, -8, 7 },
                { 5, 1, 0 }
            };

            string path = ds.SaveToFileTextData(matrix);

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
