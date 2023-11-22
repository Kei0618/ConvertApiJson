using System.Text.Encodings.Web;
using System.Text.Json;

namespace ConvertApiJson
{
    public static class JsonStream
    {
        // 讀取原postman api collection json內容，替換{{url}}為參數url後放入JsonRoot中
        public static PostManApiContent Read(string path, string url)
        {
            try
            {
                using (FileStream _fileRead = new FileStream(path, FileMode.Open, FileAccess.Read))
                {
                    using (StreamReader _reader = new StreamReader(_fileRead))
                    {
                        string? _result = _reader.ReadToEnd();
                        string? _replacedResult = _result.Replace("{{url}}", url);
                        PostManApiContent? _postManApiContent = JsonSerializer.Deserialize<PostManApiContent>(_replacedResult);

                        return _postManApiContent;
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
        public static void Write(string path, PostManApiContent jsonContent)
        {
            if (jsonContent == null)
            {
                System.Console.WriteLine("讀取資料為空");
                return;
            }
            try
            {
                NewPostManApiContent _newJsonRoot = new NewPostManApiContent
                {
                    Info = jsonContent.Info,
                    Auth = jsonContent.Auth,
                    Event = jsonContent.Event,
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
                return;
            }

        }
    }
}