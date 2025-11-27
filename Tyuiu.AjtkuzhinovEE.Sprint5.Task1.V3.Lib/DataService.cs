using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.AjtkuzhinovEE.Sprint5.Task1.V3.Lib
{
    public class DataService : ISprint5Task1V3
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            //string path = $"C:\\Users\\user\\AppData\\Local\\Temp\\OutPutFileTask1.txt";
            //string path = Path.GetTempFileName();
            string path = Path.Combine( Path.GetTempPath(), "OutPutFileTask1.txt" );
            
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;


            if (fileExists)
            { 
                File.Delete(path);
            }

            string strY;
            for (int x = startValue; x<= stopValue; x++)
            {
                var y = Math.Cos(2 * x)+ (Math.Sin(x)/(2.5 + x))+ 2*x;
                y = Math.Round(y, 2);
                strY = Convert.ToString(y);


                if(x != stopValue)
                {
                    File.AppendAllText(path, strY + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path,strY);
                }


                if (2.5 + x == 0)
                {
                    y = 0;
                }               
            }
            return path;
        }
    }
}
