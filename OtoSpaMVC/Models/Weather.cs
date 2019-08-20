using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace OtoSpaMVC.Models
{
    public class Weather
    {
        public Object getWeatherForcast()
        {

            //string url = "http://api.openweathermap.org/data/2.5/weather?q=Rehovot&APPID=b83cd06be9ae6193d640ddba54e93bad";
            string url = "https://api.openweathermap.org/data/2.5/weather?q=Rehovot&APPID=b83cd06be9ae6193d640ddba54e93bad&units=metric";
            var client = new WebClient();
            var content = client.DownloadString(url);
            //var serializer = new JavaScriptSerializer();
            //DataContractSerializer seri= new DataContractSerializer(typeof(Object));
            //seri.ReadObject(content);
            //var jsonContent = serializer.Deserialize<Object>(content);
            //var jsonContent = JsonConvert.SerializeObject(content);

            return content;
        }
    }
}
