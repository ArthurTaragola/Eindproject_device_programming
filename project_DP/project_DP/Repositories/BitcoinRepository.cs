using Newtonsoft.Json;
using project_DP.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace project_DP.Repositories
{
    public static class BitcoinRepository
    {
        private static HttpClient GetHttpClient()
        {
            HttpClient httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("Accept", "application/json");
            return httpClient;
        }
        public async static Task<Dictionary<string,BitcoinLiveData>> GetJsonData()
        {
            Dictionary<string, BitcoinLiveData> dict = new Dictionary<string, BitcoinLiveData>();
            string url = "https://blockchain.info/ticker";
            using (HttpClient client = GetHttpClient())
            {
                try
                {
                    Debug.WriteLine("oke");
                    string json = await client.GetStringAsync(url);
                    dict = JsonConvert.DeserializeObject<Dictionary<string, BitcoinLiveData>>(json);
                    Debug.WriteLine("nog steeds oke");
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("niet meer oke");
                    throw ex;
                }
            }
            return dict;
        }
        
    }
}
