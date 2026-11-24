using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.YalalovNR.Sprint5.Task0.V24.Lib;

namespace Tyuiu.YalalovNR.Sprint5.Task0.V24.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            ds.SaveToFileTextData(3);

            string path = @"C:\Users\Hikika\source\repos\Tyuiu.YalalovNR.Sprint5\Tyuiu.YalalovNR.Sprint5.Task0.V24.Test\bin\Debug\net8.0\OutPutFileTask0.txt";
            FileInfo fileinfo = new FileInfo(path);
            bool FileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, FileExists);
        }
    }
}
