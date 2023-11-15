// See https://aka.ms/new-console-template for more information
using Newtonsoft.Json;

namespace ConvertApiJson
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\JerryLin\Desktop\test.json";
            JsonRoot readRoot = ReadAndWrite.Read(args[0]);
            ReadAndWrite.Write(filePath,readRoot);

        }
    }
}
