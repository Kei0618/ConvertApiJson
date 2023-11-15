using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ConvertApiJson
{
    public static class ReadAndWrite
    {
        public static JsonRoot Read(string path)
        {
            try
            {
                using (FileStream fileRead = new FileStream(path, FileMode.Open, FileAccess.Read))
                {
                    using (StreamReader reader = new StreamReader(fileRead))
                    {
                        string? result = reader.ReadToEnd();
                        JsonRoot? test = JsonConvert.DeserializeObject<JsonRoot>(result);

                        return test;
                    }

                }

            }
            catch (System.Exception ex)
            {
                System.Console.WriteLine(ex.Message);
                return null;
            }
        }

        public static void Write(string path, JsonRoot jsonContent)
        {
            if (jsonContent == null)
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
                        string jsonString = JsonConvert.SerializeObject(jsonContent, Formatting.Indented);

                        writer.WriteLine(jsonString);
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