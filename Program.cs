// See https://aka.ms/new-console-template for more information

namespace ConvertApiJson
{
    class Program
    {
        // 判斷參數長度以及內容後，呼叫讀、寫方法
        static void Main(string[] args)
        {

            if (VariantCheck.CheckResult(args))
            {
                PostManApiContent readRoot = JsonStream.Read(args[0], args[2]);
                JsonStream.Write(args[1], readRoot);
            }

        }
    }
}
