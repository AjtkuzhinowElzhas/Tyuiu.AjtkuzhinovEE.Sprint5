using Tyuiu.AjtkuzhinovEE.Sprint5.Task3.V4.Lib;
using System.IO;

namespace Tyuiu.AjtkuzhinovEE.Sprint5.Task3.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = $"C:\\Users\\user\\AppData\\Local\\Temp\\OutPutFileTask3.txt";

            FileInfo fileInfo = new FileInfo(path);

            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
