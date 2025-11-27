using Tyuiu.AjtkuzhinovEE.Sprint5.Task0.V5.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        int x = 3;

        DataService ds = new DataService();

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫНЕ:                                                       *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("x = " + x);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        string res = ds.SaveToFileTextData(x);
        Console.WriteLine("Файл " + res + " создан!");
        Console.ReadKey();
    }
}