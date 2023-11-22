using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConvertApiJson
{
    public class CheckCondition
    {
        // 根據呼叫方法傳入的參數進行判斷並且回應
        public static bool LengthThree(string[] strings)
        {
            string _readPath = strings[0];
            string _writePath = strings[1];
            string _url = strings[2];

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
            else if (!_url.Contains("//"))
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
        public static bool LengthTwo(string[] strings)
        {
            string _readPath = strings[0];
            string _writePath = strings[1];

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

            System.Console.WriteLine("錯誤:參數一錯誤:讀取路徑無效\n參數三錯誤:缺少url參數");
            return false;

        }

        public static bool LengthOne(string[] strings)
        {
            string _readPath = strings[0];

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
    }
}