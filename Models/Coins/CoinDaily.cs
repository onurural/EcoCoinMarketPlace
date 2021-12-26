
namespace EcoCoinMarketPlace.Models.Coins
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class DailyCoins : IModel
    {
        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public List<DailyCoin> Data { get; set; }

        [JsonProperty("timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public long? Timestamp { get; set; }
    }

    public partial class DailyCoin : Coin
    {

        [JsonProperty("priceUsd", NullValueHandling = NullValueHandling.Ignore)]
        public string PriceUsdDaily { get; set; }

        [JsonProperty("time", NullValueHandling = NullValueHandling.Ignore)]
        public long? Time { get; set; }

        [JsonProperty("date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Date { get; set; }
    }

    public partial class DailyCoins
    {
        public static DailyCoins FromJson(string json) => JsonConvert.DeserializeObject<DailyCoins>(json, ConverterDC.Settings);
    }

    public static class SerializeDC
    {
        public static string ToJson(this DailyCoins self) => JsonConvert.SerializeObject(self, ConverterDC.Settings);
    }

    internal static class ConverterDC
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}

