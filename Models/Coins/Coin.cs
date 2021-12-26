using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace EcoCoinMarketPlace.Models.Coins
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    

    public partial class Coin
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        [JsonProperty("rank", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? Rank { get; set; }

        [JsonProperty("symbol", NullValueHandling = NullValueHandling.Ignore)]
        public string Symbol { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("supply", NullValueHandling = NullValueHandling.Ignore)]
        public string Supply { get; set; }

        [JsonProperty("maxSupply", NullValueHandling = NullValueHandling.Ignore)]
        public string MaxSupply { get; set; }

        [JsonProperty("marketCapUsd", NullValueHandling = NullValueHandling.Ignore)]
        public string MarketCapUsd { get; set; }

        [JsonProperty("volumeUsd24Hr", NullValueHandling = NullValueHandling.Ignore)]
        public string VolumeUsd24Hr { get; set; }

        [JsonProperty("priceUsd", NullValueHandling = NullValueHandling.Ignore)]
        public string PriceUsd { get; set; }

        [JsonProperty("changePercent24Hr", NullValueHandling = NullValueHandling.Ignore)]
        public string ChangePercent24Hr { get; set; }

        [JsonProperty("vwap24Hr", NullValueHandling = NullValueHandling.Ignore)]
        public string Vwap24Hr { get; set; }
    }

    public partial class Coin
    {
        public static Coin FromJson(string json) => JsonConvert.DeserializeObject<Coin>(json, Converter.CoinSettings);
    }

    public static class Serialize
    {
        public static string ToJson(this Coin self) => JsonConvert.SerializeObject(self, Converter.CoinSettings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings CoinSettings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class ParseStringConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(long) || t == typeof(long?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            long l;
            if (Int64.TryParse(value, out l))
            {
                return l;
            }
            throw new Exception("Cannot unmarshal type long");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (long)untypedValue;
            serializer.Serialize(writer, value.ToString());
            return;
        }

        public static readonly ParseStringConverter Singleton = new ParseStringConverter();
    }
}
