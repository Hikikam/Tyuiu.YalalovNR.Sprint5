using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.YalalovNR.Sprint5.Task3.V13.Lib;

namespace Tyuiu.YalalovNR.Sprint5.Task3.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            DataService ds = new DataService();
            string path = ds.SaveToFileTextData(3);

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
