using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.AjtkuzhinovEE.Sprint5.Task7.V16.Lib
{
    public class DataService : ISprint5Task7V16
    {
        public string LoadDataAndSave(string path)
        {
           string pathSaveFile = Path.Combine(Path.GetTempPath(), "OutPutFileTask7.txt");
           
            FileInfo fileInfo = new FileInfo(pathSaveFile);
            bool fileExists = fileInfo.Exists;

            if (fileExists) 
            {
                File.Delete(pathSaveFile);
            }

            
            using (StreamReader reader = new StreamReader(path)) 
            {
                string line;
                while ((line = reader.ReadLine()) != null) 
                {
                    string strLine = ""; 
                    string[] words = line.Split(' '); 
                    for (int i = 0; i < words.Length; i++) 
                    {
                        if ((words[i].Length == 2))
                        {
                            strLine += "XY ";
                        }
                        else
                        {
                            strLine += words[i] + " ";
                        }
                    }
                    File.AppendAllText(pathSaveFile, strLine + Environment.NewLine);
                    
                    
                }
            }
            return pathSaveFile;
        }
    }
}
