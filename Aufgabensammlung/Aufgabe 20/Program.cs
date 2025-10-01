using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace Aufgabe_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WebRequest request = WebRequest.Create("https://witzapi.de/api/joke/");
            WebResponse response = request.GetResponse();
            Stream responseStream = response.GetResponseStream();
            string jsonData = new StreamReader(responseStream).ReadToEnd();
            //...
            using Newtonsoft.Json;
            using Newtonsoft.Json.Linq;
            JArray array = JArray.Parse(json);
            // etc...
        }
    }
}
