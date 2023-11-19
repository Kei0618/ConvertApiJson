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
                        JsonRoot? _jsonRoot = JsonSerializer.Deserialize<JsonRoot>(_result);


                        return _jsonRoot;
                    }

                }

            }
            catch (System.Exception _ex)
            {
                System.Console.WriteLine(_ex);
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
                JsonRoot _jsonRoot = jsonContent;
                NewJsonRoot _newJsonRoot = new NewJsonRoot
                {
                    Info = jsonContent.Info,
                    Auth = jsonContent.Auth,
                    Event = jsonContent.Event,
                };

                var urlObject = new
                {
                    raw = "https://hokwangiot.cornerdigit.com/api/soapmachine/addrecord",
                    // protocol = "https",
                    // host = new List<string> { "hokwangiot", "cornerdigit", "com" },
                    // path = new List<string> { "api", "soapmachine" }
                };
                foreach (var _items in _jsonRoot.Items)
                {
                    foreach (var _item in _items.Item)
                    {
                        string _requestUrl = _item.Request.Url.ToString();
                        System.Console.WriteLine(_requestUrl);

                        // if (!_requestUrl.Contains(","))
                        // {
                            // string _urlString = _item.Request.Url.ToString();
                            // string[] _urlStings = _urlString.Split('/');
                            // string[] _urlHost = new string[] { _urlStings[0] };
                            // string[] _urlStringNoVariable = _urlStings.Skip(1).ToArray();
                            // System.Console.WriteLine(_urlStringNoVariable);
                            // var urlObject = new
                            // {
                            //     raw = _urlString,
                            //     host = _urlHost,
                            //     protocol ="https",
                            //     path = _urlStringNoVariable
                            // };
                            _item.Request.Url = urlObject;
                            _item.Request.Url = "https://hokwangiot.cornerdigit.com/api/soapmachine/addrecord";
                        // }
                        foreach (var _itemResponse in _item.Response)
                        {
                            string _responseUrl = _itemResponse.OriginalRequest.Url.ToString();
                            // if (!_responseUrl.Contains(","))
                            // {
                                // string _urlString = _responseUrl.ToString();
                                // string[] _urlStings = _urlString.Split('/');
                                // string[] _urlHost = new string[] { _urlStings[0] };
                                // string[] _urlStringNoVariable = _urlStings.Skip(1).ToArray();
                                // var urlObject = new
                                // {
                                //     raw = _urlString,
                                //     host = _urlHost,
                                // protocol ="https",
                                //     path = _urlStringNoVariable
                                // };
                                // _itemResponse.OriginalRequest.Url = urlObject;
                                _itemResponse.OriginalRequest.Url = "https://hokwangiot.cornerdigit.com/api/soapmachine/addrecord";
                            // }
                        }
                        _newJsonRoot.Items.Add(_item);

                    }
                }

                // foreach (var _items in _jsonRoot.Items)
                // {
                //     foreach (var _item in _items.Item)
                //     {
                //         _newJsonRoot.Items.Add(_item);
                //     }
                // }

                using (FileStream _fileWrite = new FileStream(path, FileMode.Create, FileAccess.Write))
                {
                    using (StreamWriter _writer = new StreamWriter(_fileWrite))
                    {
                        // string _jsonString = JsonConvert.SerializeObject(_newJsonRoot, Formatting.Indented);
                        var options = new JsonSerializerOptions { WriteIndented = true, Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping };
                        string _jsonString = JsonSerializer.Serialize(_newJsonRoot, options);

                        _writer.WriteLine(_jsonString);
                        System.Console.WriteLine("寫入完成");
                    }
                }
            }
            catch (System.Exception _ex)
            {
                System.Console.WriteLine(_ex);
            }

        }
    }
}