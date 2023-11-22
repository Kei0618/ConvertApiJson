using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConvertApiJson
{
    public static class CheckVariant
    {
        // 判斷主程式陣列參數的長度。依據長度交給自定方法判斷
        public static bool CheckResult(string[] strings)
        {
            string _readPath;
            string _writePath;
            string _url;

            Console.ForegroundColor = ConsoleColor.Red;

            try
            {

                if (strings.Length > 3)
                {
                    System.Console.WriteLine("參數錯誤:輸入超過三個參數\n需求參數為\n參數一:讀取路徑\n參數二:寫入路徑\n參數三:url");

                    return false;
                }

                if (strings.Length == 3)
                {
                    return CheckCondition.LengthThree(strings);
                }

                if (strings.Length == 2)
                {
                    return CheckCondition.LengthTwo(strings);
                }

                if (strings.Length == 1)
                {
                    return CheckCondition.LengthOne(strings);
                }

                System.Console.WriteLine("參數錯誤:缺少以下參數\n參數一:讀取路徑\n參數二:寫入路徑\n參數三:url");
                return false;
            }
            catch (System.Exception _ex)
            {
                System.Console.WriteLine(_ex.Message);
                return false;
            }




        }

    }
}