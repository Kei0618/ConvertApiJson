// See https://aka.ms/new-console-template for more information

namespace ConvertApiJson
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = @"C:\Users\JerryLin\Downloads\Horing Lih Auth.postman_collection_1.json";
            string b = @"C:\Users\JerryLin\Downloads\測試1.json";
            // JsonRoot readRoot = ReadAndWrite.Read(args[0]);
            // ReadAndWrite.Write(args[1], readRoot);
            JsonRoot readRoot = ReadAndWrite.Read(a);
            ReadAndWrite.Write(b, readRoot);
        }
    }
}
