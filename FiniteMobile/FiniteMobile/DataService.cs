﻿using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace FiniteMobile
{
    class DataService
    {
        public static async Task<dynamic> getDataFromService(string queryString)
        {
            HttpClient client = new HttpClient(); var response = await client.GetAsync(queryString);

            dynamic data = null; if (response != null) { string json = response.Content.ReadAsStringAsync().Result; data = JsonConvert.DeserializeObject(json); }

            return data;
        }
    }
}
