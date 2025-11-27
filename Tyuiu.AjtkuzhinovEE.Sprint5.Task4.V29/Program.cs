using Tyuiu.AjtkuzhinovEE.Sprint5.Task4.V29.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
       DataService ds = new DataService();
       
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫНЕ:                                                       *");
        Console.WriteLine("***************************************************************************");

        string path = @"C:\DataSprint5\InPutDataFileTask4V29.txt";

        Console.WriteLine("Данные находятся в файле: " + path);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        double y = ds.LoadFromDataFile(path);
        Console.WriteLine(y);
        
        
        Console.ReadKey();
    }
}