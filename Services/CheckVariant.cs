using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConvertApiJson
{
    public static class CheckVariant
    {
        public static bool CheckResult(string[] strings)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            string _readFilePath = strings[0];

            if (strings.Length == 3)
            {
                if (!File.Exists(_readFilePath))
                {
                    System.Console.WriteLine("參數1錯誤:讀取路徑檔案不存在");

                    return false;
                }
                else if (strings[1].Contains('/'))
                {
                    System.Console.WriteLine("參數2錯誤:寫入路徑錯誤，url為參數3");

                    return false;
                }
                else if (strings[2].Contains('\\'))
                {
                    System.Console.WriteLine("參數3錯誤:url錯誤");

                    return false;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    return true;
                }
            }
            else if (strings.Length > 3)
            {
                System.Console.WriteLine("參數錯誤:輸入超過三個參數");
                return false;
            }
            else
            {
                if (strings.Length == 2)
                {
                    if (File.Exists(_readFilePath) && strings[1].Contains('/'))
                    {
                        System.Console.WriteLine("錯誤:\n參數二錯誤:寫入路徑無效\n參數三錯誤:缺少url參數");
                        return false;
                    }
                    else if (File.Exists(_readFilePath) && strings[1].Contains('\\'))
                    {
                        System.Console.WriteLine("錯誤:\n參數三錯誤:缺少url參數");
                        return false;
                    }
                    else if (!File.Exists(_readFilePath) && strings[1].Contains('/'))
                    {
                        System.Console.WriteLine("錯誤:\n參數一錯誤:讀取路徑無效\n參數二錯誤:寫入路徑無效\n參數三錯誤:缺少url參數");
                        return false;
                    }
                    else if (!File.Exists(_readFilePath) && strings[1].Contains('\\'))
                    {
                        System.Console.WriteLine("錯誤:參數一錯誤:讀取路徑無效\n參數三錯誤:缺少url參數");
                        return false;
                    }

                }
                else if (strings.Length == 1)
                {
                    if (File.Exists(_readFilePath))
                    {
                        System.Console.WriteLine("錯誤:\n參數二錯誤:缺少寫入路徑\n參數三錯誤:缺少url參數");
                        return false;
                    }
                    else if (!File.Exists(_readFilePath) && strings[0].Contains('\\'))
                    {
                        System.Console.WriteLine("錯誤:\n參數一錯誤:讀取路徑無效\n參數二錯誤:缺少寫入路徑\n參數三錯誤:缺少url參數");
                        return false;
                    }
                }

                System.Console.WriteLine("參數錯誤:缺少以下參數\n參數一:讀取路徑\n參數二:寫入路徑\n參數三:url");
                return false;

            }
        }

    }
}