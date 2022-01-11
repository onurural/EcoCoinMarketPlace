namespace EcoCoinMarketPlace.Models
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;

    public partial class Exchange : IModel<Exchange>
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public long? Rank { get; set; }

        public string PercentTotalVolume { get; set; }

        public string VolumeUsd { get; set; }

        public long? TradingPairs { get; set; }

        public bool? Socket { get; set; }

        public Uri ExchangeUrl { get; set; }

        public long? Updated { get; set; }
        public List<Exchange> Data { get; set; }

        public Exchange FromJson(string json)
        {
            return JsonConvert.DeserializeObject<Exchange>(json, Converter.Settings);
        }

        public string ToJson(Exchange self)
        {
            return JsonConvert.SerializeObject(self, Converter.Settings);
        }
    }
}