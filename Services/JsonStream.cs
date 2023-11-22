using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Reflection;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Threading.Tasks;
using ConvertApiJson.Models;

namespace ConvertApiJson
{
    public static class JsonStream
    {
        // 讀取原postman api collection json內容，替換{{url}}為參數url後放入JsonRoot中
        public static JsonRoot Read(string path, string url)
        {

            try
            {
                using (FileStream _fileRead = new FileStream(path, FileMode.Open, FileAccess.Read))
                {
                    using (StreamReader _reader = new StreamReader(_fileRead))
                    {

                        string? _result = _reader.ReadToEnd();
                        string? _replaceResultUrl = _result.Replace("{{url}}", url);
                        JsonRoot? _jsonRoot = JsonSerializer.Deserialize<JsonRoot>(_replaceResultUrl);

                        return _jsonRoot;
                    }

                }

            }
            catch (System.Exception _ex)
            {
                System.Console.WriteLine(_ex.Message);
                return null;
            }
        }

        // 將JsonRoot類別的內容轉換為NewJsonRoot後寫成新json檔案
        public static void Write(string path, JsonRoot jsonContent)
        {
            if (jsonContent == null)
            {
                System.Console.WriteLine("讀取資料為空");
                return;
            }
            try
            {
                JsonRoot _jsonRoot = jsonContent;
                NewJsonRoot _newJsonRoot = new NewJsonRoot
                {
                    Info = jsonContent.Info,
                    Auth = jsonContent.Auth,
                    Event = jsonContent.Event,
                };

                foreach (var _items in _jsonRoot.Items)
                {
                    foreach (var _item in _items.Item)
                    {
                        _newJsonRoot.Items.Add(_item);
                    }
                }

                using (FileStream _fileWrite = new FileStream(path, FileMode.Create, FileAccess.Write))
                {
                    using (StreamWriter _writer = new StreamWriter(_fileWrite))
                    {
                        JsonSerializerOptions options = new JsonSerializerOptions { WriteIndented = true, Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping };
                        string _jsonString = JsonSerializer.Serialize(_newJsonRoot, options);

                        _writer.WriteLine(_jsonString);
                        System.Console.WriteLine("寫入完成");
                    }
                }
            }
            catch (System.Exception _ex)
            {
                System.Console.WriteLine(_ex.Message);
            }

        }
    }
}