// See https://aka.ms/new-console-template for more information

namespace ConvertApiJson
{
    class Program
    {
        // 判斷參數長度以及內容後，呼叫讀、寫方法
        static void Main(string[] args)
        {
            if (VariantChecker.CheckResult(args))
            {
                PostManApiContent readRoot = PostmanApiJsonHandler.Read(args[0], args[2]);
                PostmanApiJsonHandler.Write(args[1], readRoot);
            }
        }
    }
}
