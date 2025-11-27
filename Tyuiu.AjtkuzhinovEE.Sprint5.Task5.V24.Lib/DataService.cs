using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.AjtkuzhinovEE.Sprint5.Task5.V24.Lib
{
    public class DataService : ISprint5Task5V24
    {
        public double LoadFromDataFile(string path)
        {
            double res =0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    // Разбиваем строку на отдельные числа
                    string[] numbers = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                    foreach (string number in numbers)
                    {
                        // Парсим каждое число отдельно
                        double num = double.Parse(number, System.Globalization.CultureInfo.InvariantCulture);

                        // Проверяем: целое число И в диапазоне 10-99
                        if (num == Math.Floor(num) && num >= 10 && num <= 99)
                        {
                            res += num;
                        }
                    }
                }
            }
             return res;
        }
    }
}
