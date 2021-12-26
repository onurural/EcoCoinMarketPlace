

namespace EcoCoinMarketPlace.Models
{
    using System;
    using System.Collections.Generic;
    using EcoCoinMarketPlace.Models.Coins;
    using Newtonsoft.Json;

    public partial class Exchanges : IModel
    {
        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public List<Exchange> Data { get; set; }
    }

    public partial class Exchange
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("rank", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? Rank { get; set; }

        [JsonProperty("percentTotalVolume", NullValueHandling = NullValueHandling.Ignore)]
        public string PercentTotalVolume { get; set; }

        [JsonProperty("volumeUsd", NullValueHandling = NullValueHandling.Ignore)]
        public string VolumeUsd { get; set; }

        [JsonProperty("tradingPairs", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? TradingPairs { get; set; }

        [JsonProperty("socket", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Socket { get; set; }

        [JsonProperty("exchangeUrl", NullValueHandling = NullValueHandling.Ignore)]
        public Uri ExchangeUrl { get; set; }

        [JsonProperty("updated", NullValueHandling = NullValueHandling.Ignore)]
        public long? Updated { get; set; }
    }

    public partial class Exchanges
    {
        public static Exchanges FromJson(string json) => JsonConvert.DeserializeObject<Exchanges>(json, Converter.CoinSettings);
    }
}
