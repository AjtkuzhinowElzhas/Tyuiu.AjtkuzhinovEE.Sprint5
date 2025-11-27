using System.IO;
using Tyuiu.AjtkuzhinovEE.Sprint5.Task0.V5.Lib;

namespace Tyuiu.AjtkuzhinovEE.Sprint5.Task0.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistFile()
        {
            string path = @"C:\Users\user\source\repos\Tyuiu.AjtkuzhinovEE.Sprint5\Tyuiu.AjtkuzhinovEE.Sprint5.Task0.V5\bin\Debug\OutPutFileTask0.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExist);   
        }
    }
}
