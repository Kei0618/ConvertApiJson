// See https://aka.ms/new-console-template for more information
using Newtonsoft.Json;

namespace ConvertApiJson
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\JerryLin\Desktop\test.json";
            using (FileStream fileRead = new FileStream(args[0], FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                using (StreamReader reader = new StreamReader(fileRead))
                {
                    string? result = reader.ReadToEnd();
                    System.Console.WriteLine(result);
                }

            }

        }
    }
}
