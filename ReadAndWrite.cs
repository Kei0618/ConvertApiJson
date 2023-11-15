using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Threading.Tasks;

namespace ConvertApiJson
{
    public static class ReadAndWrite
    {
        public static string Read(string path)
        {
            try
            {
                using (FileStream fileRead = new FileStream(path, FileMode.Open, FileAccess.Read))
                {
                    using (StreamReader reader = new StreamReader(fileRead))
                    {
                        string? result = reader.ReadToEnd();
                        return result;
                    }

                }

            }
            catch (System.Exception ex)
            {
                System.Console.WriteLine(ex.Message);
                return "";
            }
        }

        public static void Write(string path, string jsonContent)
        {
            if (jsonContent == "")
            {
                System.Console.WriteLine("讀取資料為空");
                return;
            }
            try
            {
                using (FileStream fileWrite = new FileStream(path, FileMode.Create, FileAccess.Write))
                {
                    using (StreamWriter writer = new StreamWriter(fileWrite))
                    {
                        writer.WriteLine(jsonContent);
                        System.Console.WriteLine("寫入完成");
                    }
                }
            }
            catch (System.Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }

        }
    }
}