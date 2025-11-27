using Tyuiu.AjtkuzhinovEE.Sprint5.Task5.V24.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        

        DataService ds = new DataService();

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫНЕ:                                                       *");
        Console.WriteLine("***************************************************************************");

        string path = @"C:\DataSprint5\InPutDataFileTask5V24.txt";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        double res = ds.LoadFromDataFile(path);
        Console.WriteLine("Сумма двухзначных целых элементов файла = " + res);
        Console.ReadKey();
    }
}