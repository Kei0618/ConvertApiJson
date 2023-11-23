using System.Text.RegularExpressions;

namespace ConvertApiJson
{
    public static class VariantChecker
    {
        // 判斷主程式陣列參數的長度。依據長度交給自定方法判斷
        public static bool CheckResult(string[] strings)
        {
            Console.ForegroundColor = ConsoleColor.Red;

            // 將參數傳給自定義方法判斷
            return CheckInputParameters(strings);
        }

        // 檢查陣列的各個參數
        public static bool CheckInputParameters(string[] strings)
        {
            // 預設紅色字體，定義變數用於檢查，用三元運算子先判斷值是否存在，不存在則為""
            Console.ForegroundColor = ConsoleColor.Red;
            string _readPath = strings.Length > 0 ? strings[0] : "";
            string? _writePath = Path.GetDirectoryName(strings.Length > 1 ? strings[1] : "");
            string _url = strings.Length > 2 ? strings[2] : "";
            // 定義錯誤訊息、檢測的結果(bool)
            string _resultText = "錯誤:";
            bool _checkResult = true;
            System.Console.WriteLine($"url檢測結果為=>{IsValidUrl(_url)}");
            try
            {
                // 判斷每一個參數是否符合條件，若不達成條件則加入字串訊息以及檢測的結果變為false
                // 判斷路徑檔案是否存在
                if (!File.Exists(_readPath))
                {
                    _resultText += "\n參數一錯誤:讀取路徑檔案不存在";
                    _checkResult = false;
                }
                // 判斷路徑是否存在
                if (!Directory.Exists(_writePath))
                {
                    _resultText += "\n參數二錯誤:寫入路徑不存在";
                    _checkResult = false;
                }
                // 使用絕對url判斷是否符合url格式
                if (!Uri.IsWellFormedUriString(_url, UriKind.Absolute))
                {
                    _resultText += "\n參數三錯誤:url錯誤";
                    _checkResult = false;
                }
                // 若_errorNumber==代表三個參數都正確，回傳true
                if (_checkResult)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    return true;
                }
            }
            catch (System.Exception _ex)
            {
                System.Console.WriteLine(_ex.Message);
            }
            // 若上面無return則列出錯誤訊息並回傳false
            System.Console.WriteLine(_resultText);
            return false;

        }

        static bool IsValidUrl(string url)
        {
            string pattern = @"^https:\/\/[^\s\/\\]*$";
            Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);

            return regex.IsMatch(url);
        }

    }
}