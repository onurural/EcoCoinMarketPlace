using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoCoinMarketPlace.Models.Coins
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using EcoCoinMarketPlace.Models;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class Coins : IModel
    {
        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public List<Coin> Data { get; set; }
    }

    public partial class Coins
    {
        public static Coins FromJson(string json) => JsonConvert.DeserializeObject<Coins>(json, CoinsConverter.Settings);
    }

    public static class SerializeCoins
    {
        public static string ToJson(this Coins self) => JsonConvert.SerializeObject(self, CoinsConverter.Settings);
    }

    internal static class CoinsConverter
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
