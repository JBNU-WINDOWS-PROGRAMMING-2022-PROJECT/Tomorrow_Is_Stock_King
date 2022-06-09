using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Tomorrow_Is_Stock_King.Model;

namespace Tomorrow_Is_Stock_King.ViewModel
{
    internal class StockAPI
    {
        static string API_KEY = "FvLmbKsT5UkHbbCa%2FWOFTOHM13EOJ8UNnbWreWSXVU8W8DrN%2BA8wfjZGcAJOJRiWc2M%2FViJPDXdwQhne%2Btv8HA%3D%3D";
        static string BASE_URL = "https://api.odcloud.kr/api/GetStockSecuritiesInfoService/v1/getStockPriceInfo?resultType=json&basDt={0}&itmsNm={1}&serviceKey={2}";

        public static Item GetStockData(string date ,string Stockname)
        {
            Example result = new Example();

            string url = String.Format(BASE_URL, date, Stockname, API_KEY);

            HttpClient client = new HttpClient();
            var response = client.GetAsync(url);
            string resultString = response.Result.Content.ReadAsStringAsync().Result;
            client.Dispose();

            result = JsonConvert.DeserializeObject<Example>(resultString);

            Item resultitem = (Item)result.Response.Body.Items.Item[0];
            
            return resultitem;

        }

    }
}
