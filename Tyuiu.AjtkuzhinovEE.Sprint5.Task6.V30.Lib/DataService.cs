using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.AjtkuzhinovEE.Sprint5.Task6.V30.Lib
{
    public class DataService : ISprint5Task6V30
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                
                while ((line = reader.ReadLine()) != null)
                {
                    // Разбиваем строку на слова и сразу проверяем каждое
                    int start = 0;
                    for (int i = 0; i <= line.Length; i++)
                    {
                        // Если достигли пробела или конца строки
                        if (i == line.Length || line[i] == ' ')
                        {
                            // Проверяем длину слова
                            if (i - start == 8)
                            {
                                count++;
                            }
                            start = i + 1; // Начало следующего слова
                        }
                    }
                }
            }
            return count;
        }
    }
}
