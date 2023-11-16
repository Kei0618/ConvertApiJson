// See https://aka.ms/new-console-template for more information
using Newtonsoft.Json;

namespace ConvertApiJson
{
    class Program
    {
        static void Main(string[] args)
        {
            JsonRoot readRoot = ReadAndWrite.Read(args[0]);
            ReadAndWrite.Write(args[1],readRoot);
        }
    }
}
