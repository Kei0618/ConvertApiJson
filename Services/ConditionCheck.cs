namespace ConvertApiJson
{
    public class ConditionCheck
    {
        // 根據呼叫方法傳入的參數進行判斷並且回應

        // 參數為三個時，分別檢查參數一、二是否為有效路徑，以及檢查參數三是否為絕對url

        public static bool CheckThreeInputParameters(string[] strings)
        {
            string _readPath = strings[0];
            string? _writePath = Path.GetDirectoryName(strings[1]);
            string _url = strings[2];

            if (!File.Exists(_readPath))
            {
                System.Console.WriteLine("參數一錯誤:讀取路徑檔案不存在");

                return false;
            }
            else if (!Directory.Exists(_writePath))
            {
                System.Console.WriteLine("參數二錯誤:寫入路徑不存在");

                return false;
            }
            else if (!Uri.TryCreate(_url, UriKind.Absolute, out Uri? uriResult))
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

        // 參數為三個時，分別檢查參數一、二是否為有效路徑
        public static bool CheckTwoInputParameters(string[] strings)
        {
            string _readPath = strings[0];
            string _writePath = strings[1];

            if (File.Exists(_readPath) && !Directory.Exists(_writePath))
            {
                System.Console.WriteLine("錯誤:\n參數二錯誤:寫入路徑無效\n參數三錯誤:缺少url參數");
                return false;
            }
            else if (File.Exists(_readPath) && Directory.Exists(_writePath))
            {
                System.Console.WriteLine("錯誤:\n參數三錯誤:缺少url參數");
                return false;
            }
            else if (!File.Exists(_readPath) && !Directory.Exists(_writePath))
            {
                System.Console.WriteLine("錯誤:\n參數一錯誤:讀取路徑無效\n參數二錯誤:寫入路徑無效\n參數三錯誤:缺少url參數");
                return false;
            }
            else if (!File.Exists(strings[0]) && Directory.Exists(_writePath))
            {
                System.Console.WriteLine("錯誤:參數一錯誤:讀取路徑無效\n參數三錯誤:缺少url參數");
                return false;
            }

            System.Console.WriteLine("錯誤:參數一錯誤:讀取路徑無效\n參數三錯誤:缺少url參數");
            return false;

        }

        public static bool CheckOneInputParameters(string[] strings)
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