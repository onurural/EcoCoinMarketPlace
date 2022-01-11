namespace EcoCoinMarketPlace.Models.Coins
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;



    public partial class DailyCoin : Coin, IModel<DailyCoin>
    {
        public long? Timestamp { get; set; }
        public string PriceUsdDaily { get; set; }

        public long? Time { get; set; }

        public DateTimeOffset? Date { get; set; }
        public new List<DailyCoin> Data { get; set; }

        public new DailyCoin FromJson(string json)
        {
            return JsonConvert.DeserializeObject<DailyCoin>(json, Converter.Settings);
        }

        public string ToJson(DailyCoin self)
        {
            return JsonConvert.SerializeObject(self, Converter.Settings);
        }
    }






}