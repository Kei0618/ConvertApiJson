using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Threading.Tasks;
using ConvertApiJson.Models;
using Newtonsoft.Json;

namespace ConvertApiJson
{
    public static class ReadAndWrite
    {
        public static JsonRoot Read(string path)
        {
            try
            {
                using (FileStream _fileRead = new FileStream(path, FileMode.Open, FileAccess.Read))
                {
                    using (StreamReader _reader = new StreamReader(_fileRead))
                    {
                        string? _result = _reader.ReadToEnd();
                        JsonRoot? _jsonRoot = JsonConvert.DeserializeObject<JsonRoot>(_result);

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

        public static void Write(string path, JsonRoot jsonContent)
        {
            if (jsonContent == null)
            {
                System.Console.WriteLine("讀取資料為空");
                return;
            }
            try
            {
                NewJsonRoot _newJsonRoot = new NewJsonRoot
                {
                    Info = jsonContent.Info,
                    Auth = jsonContent.Auth,
                    Event = jsonContent.Event
                };

                foreach (var _items in jsonContent.Items)
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
                        string _jsonString = JsonConvert.SerializeObject(_newJsonRoot, Formatting.Indented);

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