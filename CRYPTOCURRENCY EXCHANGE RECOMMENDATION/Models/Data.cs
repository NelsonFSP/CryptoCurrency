using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace CRYPTOCURRENCY_EXCHANGE_RECOMMENDATION.Models
{
    public class Data
    {  
        [JsonProperty ("id")]
        public string Id { get; set; }
        [JsonProperty("symbol")]
        public string Symbol { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("nameid")]
        public string Nameid { get; set; }
        [JsonProperty("rank")]
        public int Rank { get; set; }
        [JsonProperty("price_usd")]
        public string Price_usd { get; set; }
        [JsonProperty("percent_change_24h")]
        public string Percent_change_24h { get; set; }
        [JsonProperty("percent_change_1h")]
        public string Percent_change_1h { get; set; }
        [JsonProperty("percent_change_7d")]
        public string Percent_change_7d { get; set; }
        [JsonProperty("price_btc")]
        public string Price_btc { get; set; }
        [JsonProperty("market_cap_usd")]
        public string Market_cap_usd { get; set; }
        [JsonProperty("volume24")]
        public double Volume24 { get; set; }
        [JsonProperty("volume24a")]
        public double Volume24a { get; set; }
        [JsonProperty("csupply")]
        public string Csupply { get; set; }
        [JsonProperty("tsupply")]
        public string Tsupply { get; set; }
        [JsonProperty("msupply")]
        public string Msupply { get; set; }

        public static implicit operator string(Data v)
        {
            throw new NotImplementedException();
        }
    }

    public class Root
    {
        public List<Data> Data { get; set; }
    }
}
