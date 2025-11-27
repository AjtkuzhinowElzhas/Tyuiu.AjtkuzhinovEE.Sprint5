using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.AjtkuzhinovEE.Sprint5.Task4.V29.Lib
{
    public class DataService : ISprint5Task4V29
    {
        public double LoadFromDataFile(string path)
        {
            

            string strX = File.ReadAllText(path).Replace('.', ',');
            double x = Convert.ToDouble(strX);

            double y = Convert.ToDouble(strX) / (2 * Convert.ToDouble(strX)) + Math.Sin(Math.Pow(Convert.ToDouble(strX), 2));

            y = Math.Round(y, 3);
            return y;
        }
    }
}
