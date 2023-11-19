// See https://aka.ms/new-console-template for more information

namespace ConvertApiJson
{
    class Program
    {
        static void Main(string[] args)
        {
            JsonRoot readRoot = ReadAndWrite.Read(args[0],args[2]);
            ReadAndWrite.Write(args[1], readRoot);
        }
    }
}
