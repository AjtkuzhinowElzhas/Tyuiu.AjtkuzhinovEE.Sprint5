using Tyuiu.AjtkuzhinovEE.Sprint5.Task5.V24.Lib;
using System.IO;
namespace Tyuiu.AjtkuzhinovEE.Sprint5.Task5.V24.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask5V24.txt";
            FileInfo fileInfo = new FileInfo(path);

            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
