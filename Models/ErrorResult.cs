using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConvertApiJson
{
    public static class ErrorResult
    {
        public static string ErrorString { get; }
        static ErrorResult()
        {
            ErrorString = "找不到需要的三個參數:讀取檔案路徑、輸出檔案路徑、url，所以無法執行。\n可能的原因包括:\n缺少讀取檔案路徑\n缺少輸出檔案路徑\n缺少url參數";
        }

    }
}