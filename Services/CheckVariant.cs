using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConvertApiJson
{
    public static class CheckVariant
    {
        // 判斷主程式陣列參數的長度以及檢查路徑參數內的"\"跟url參數內的"//"是否存在
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
                    _readPath = strings[0];
                    _writePath = strings[1];
                    _url = strings[2];

                    if (!File.Exists(_readPath))
                    {
                        System.Console.WriteLine("參數一錯誤:讀取路徑檔案不存在");

                        return false;
                    }
                    else if (!_writePath.Contains('\\'))
                    {
                        System.Console.WriteLine("參數二錯誤:寫入路徑錯誤");

                        return false;
                    }
                    else if (_url.Contains('\\') || !_url.Contains("//"))
                    {
                        System.Console.WriteLine("參數三錯誤:url錯誤");

                        return false;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        return true;
                    }
                }


                if (strings.Length == 2)
                {
                    _readPath = strings[0];
                    _writePath = strings[1];

                    if (File.Exists(_readPath) && !_writePath.Contains('\\'))
                    {
                        System.Console.WriteLine("錯誤:\n參數二錯誤:寫入路徑無效\n參數三錯誤:缺少url參數");
                        return false;
                    }
                    else if (File.Exists(_readPath) && _writePath.Contains('\\'))
                    {
                        System.Console.WriteLine("錯誤:\n參數三錯誤:缺少url參數");
                        return false;
                    }
                    else if (!File.Exists(_readPath) && !_writePath.Contains('\\'))
                    {
                        System.Console.WriteLine("錯誤:\n參數一錯誤:讀取路徑無效\n參數二錯誤:寫入路徑無效\n參數三錯誤:缺少url參數");
                        return false;
                    }
                    else if (!File.Exists(strings[0]) && _writePath.Contains('\\'))
                    {
                        System.Console.WriteLine("錯誤:參數一錯誤:讀取路徑無效\n參數三錯誤:缺少url參數");
                        return false;
                    }

                }

                if (strings.Length == 1)
                {
                    _readPath = strings[0];

                    if (File.Exists(_readPath))
                    {
                        System.Console.WriteLine("錯誤:\n參數二錯誤:缺少寫入路徑\n參數三錯誤:缺少url參數");
                        return false;
                    }
                    else
                    {
                        System.Console.WriteLine("錯誤:\n參數一錯誤:讀取路徑無效\n參數二錯誤:缺少寫入路徑\n參數三錯誤:缺少url參數");
                        return false;
                    }
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