namespace ConvertApiJson
{
    public static class VariantCheck
    {
        // 判斷主程式陣列參數的長度。依據長度交給自定方法判斷
        public static bool CheckResult(string[] strings)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            try
            {
                // 根據陣列參數的長度來進行相對應的方法
                switch (strings.Length)
                {
                    case 3:
                        return ConditionCheck.CheckThreeInputParameters(strings);
                    case 2:
                        return ConditionCheck.CheckTwoInputParameters(strings);
                    case 1:
                        return ConditionCheck.CheckOneInputParameters(strings);
                    case 0:
                        System.Console.WriteLine("參數錯誤:缺少以下參數\n參數一:讀取路徑\n參數二:寫入路徑\n參數三:url");
                        return false;
                    default:
                        System.Console.WriteLine("參數錯誤:輸入超過三個參數\n需求參數為\n參數一:讀取路徑\n參數二:寫入路徑\n參數三:url");
                        return false;
                }

            }
            catch (System.Exception _ex)
            {
                System.Console.WriteLine(_ex.Message);
            }

            return false;
        }

    }
}