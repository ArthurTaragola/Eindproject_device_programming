using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace project_DP.Models
{
    public class BitcoinLiveData
    {
    //    public Dictionary<string,Dictionary<string, string>>{ get; set; }
        [JsonProperty(PropertyName = "last")]
        public double last { get; set; }
        [JsonProperty(PropertyName = "symbol")]
        public string symbol { get; set; }
    }
}
