using Tyuiu.AjtkuzhinovEE.Sprint5.Task1.V3.Lib;
using System.IO;

namespace Tyuiu.AjtkuzhinovEE.Sprint5.Task1.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = $"C:\\Users\\user\\AppData\\Local\\Temp\\OutPutFileTask1.txt";

            FileInfo fileInfo = new FileInfo(path);

            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
            
        }
    }
}
