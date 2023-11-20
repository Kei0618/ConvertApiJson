// See https://aka.ms/new-console-template for more information

namespace ConvertApiJson
{
    class Program
    {
        static void Main(string[] args)
        {
            string _errorResult = ErrorResult.ErrorString;

            if (CheckVariant.CheckLength(args))
            {
                JsonRoot readRoot = ReadAndWrite.Read(args[0], args[2]);
                ReadAndWrite.Write(args[1], readRoot);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine(_errorResult);
            }

        }
    }
}
