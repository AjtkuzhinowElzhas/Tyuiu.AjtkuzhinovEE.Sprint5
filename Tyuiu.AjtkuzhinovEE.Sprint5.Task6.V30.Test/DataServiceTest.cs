using Tyuiu.AjtkuzhinovEE.Sprint5.Task6.V30.Lib;
using System.IO;

namespace Tyuiu.AjtkuzhinovEE.Sprint5.Task6.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    { 
            [TestMethod]
            public void CheckedExistsFile()
            {
                
                string path = @"C:\DataSprint5\InPutDataFileTask6V30.txt";
                FileInfo fileInfo = new FileInfo(path);

                bool fileExists = fileInfo.Exists;
                bool wait = true;
                Assert.AreEqual(wait, fileExists);
            }
            [TestMethod]
            public void ValidCalc()
            {
                 DataService ds = new DataService();

            string path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask6V30.txt");

                var res = ds.LoadFromDataFile(path);
                int wait = 2;
                Assert.AreEqual(wait, res);
            }
    }
}
