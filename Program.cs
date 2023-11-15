// See https://aka.ms/new-console-template for more information
using Newtonsoft.Json;

namespace ConvertApiJson
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\JerryLin\Desktop\test.json";
            using (FileStream fileRead = new FileStream(args[0], FileMode.Open, FileAccess.Read))
            {
                using (StreamReader reader = new StreamReader(fileRead))
                {
                    string? result = reader.ReadToEnd();

                    using (FileStream fileWrite = new FileStream(filePath, FileMode.Create, FileAccess.Write))
                    {
                        using (StreamWriter writer = new StreamWriter(fileWrite))
                        {
                            writer.WriteLine(result);
                        }
                    }
                }

            }

        }
    }
}
