using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.AjtkuzhinovEE.Sprint5.Task2.V15.Lib
{
    public class DataService : ISprint5Task2V15
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask2.txt");

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;

            for(int i = 0; i < rows; i++)
            {
                for(int j = 0;j < columns; j++)
                {
                    if (matrix[i,j] % 2 == 1)
                    {
                        matrix[i, j] = 0;
                    }
                }
            }
            string str = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != rows - 1)
                    {
                        str += matrix[i, j] + ";";
                    }
                    else
                    {
                        str += matrix[i, j];
                    }
                }

                if (i != rows - 1)
                {
                    File.AppendAllText(path, str + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, str);
                }
                str = "";
            }
            return path;
        }
    }
}
