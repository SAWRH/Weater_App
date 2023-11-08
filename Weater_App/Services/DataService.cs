using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Net.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using MVVM4.ViewModels;

namespace MVVM4.Services
{
    internal class DataService
    {
        public static async void GetLatLon()
        {
            List<string> description_list=new List<string>();
            List<string> date_list = new List<string>();
            List<string> temperature_list = new List<string>();
            var viewmodel = App.Current.MainWindow.DataContext as MainWindowViewModel;
            if (viewmodel==null) return;
            string city = viewmodel.City;;
            
            HttpClient client = new HttpClient();

            HttpRequestMessage request2 = new HttpRequestMessage();
            string req= $"http://api.openweathermap.org/geo/1.0/direct?q={city}&appid=e80d4256ed43b83e044adfe4d464103e";
            request2.RequestUri = new Uri(req);
            request2.Method = HttpMethod.Get;
            request2.Headers.Add("Accept", "application/json");
            var json2 = "";
            HttpResponseMessage response2 = await client.SendAsync(request2);
            if(response2.StatusCode==HttpStatusCode.OK)
            {
                HttpContent responseContent = response2.Content;
                json2 = await responseContent.ReadAsStringAsync();
                
            }
            
            string json2_s = (string) json2;
            
            JArray j_obj2 = JArray.Parse(json2_s);
            JToken zeroEl = j_obj2[0];
            JToken j_token_lat = zeroEl["lat"];
            double lat = j_token_lat.ToObject<double>();
                
            JToken j_token_lon = zeroEl["lon"];
            double lon = j_token_lon.ToObject<double>();

            HttpClient client_weather = new HttpClient();
            HttpRequestMessage request = new HttpRequestMessage();

            string reqWeather = $"http://api.openweathermap.org/data/2.5/forecast?lat={lat}&lon={lon}&units=metric&appid=e80d4256ed43b83e044adfe4d464103e";
            request.RequestUri = new Uri(reqWeather);
            
            
            request.Method = HttpMethod.Get;
            request.Headers.Add("Accept", "application/json");
            var json = "";
            HttpResponseMessage response_weather = await client_weather.SendAsync(request);
            if(response_weather.StatusCode==HttpStatusCode.OK)
            {
                HttpContent responseContent_weather = response_weather.Content;
                json = await responseContent_weather.ReadAsStringAsync();
                
            } 

            
            try
            {
                

                JObject j_obj = JObject.Parse(json);
    
                JToken j_token = j_obj["list"];
                int count = 8;
                foreach(JToken item in j_token)
                {
                    
                    JToken list0 = item;
                    
                    JToken dt_txt_token = list0["dt_txt"];
                    string date = dt_txt_token.ToObject<string>();

                    JToken main = list0["main"];
                    JToken temp = main["temp"];

                    double t = double.Parse(temp.ToString());
                    string temp_string = $"Temperature = {t}";
                    
                    JToken weather0 =  list0["weather"];
                    JToken weatherItem = weather0[0];
                    
                    JToken description = weatherItem["description"];
                    string desc = description.ToObject<string>();
                    if(count % 8==0)
                    {
                        description_list.Add(desc);
                        date_list.Add(date);
                        temperature_list.Add(temp_string);
                    }
                    
                    
                    count++;
                }
                viewmodel.Description=description_list;
                viewmodel.Date=date_list;
                viewmodel.Temperature=temperature_list;
            }
            catch
            {
                string t = "Некорректный файл JSON";
            }
            
        }

    }
}