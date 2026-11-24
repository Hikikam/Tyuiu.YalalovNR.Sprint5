using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.YalalovNR.Sprint5.Task4.V16.Lib;

namespace Tyuiu.YalalovNR.Sprint5.Task4.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask4V0.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
