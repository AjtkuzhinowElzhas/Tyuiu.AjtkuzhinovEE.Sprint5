using Tyuiu.AjtkuzhinovEE.Sprint5.Task7.V16.Lib;

namespace Tyuiu.AjtkuzhinovEE.Sprint5.Task7.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\user\AppData\Local\Temp\OutPutFileTask7.txt";
            FileInfo fileInfo = new FileInfo(path);

            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
