using Newtonsoft.Json;
using System.Collections.Generic;

namespace EcoCoinMarketPlace.Models.Coins
{



    public class Coin : IModel<Coin>
    {
        public string Id { get; set; }

        public long? Rank { get; set; }

        public string Symbol { get; set; }

        public string Name { get; set; }

        public string Supply { get; set; }

        public string MaxSupply { get; set; }

        public string MarketCapUsd { get; set; }

        public string VolumeUsd24Hr { get; set; }

        public string PriceUsd { get; set; }

        public string ChangePercent24Hr { get; set; }

        public string Vwap24Hr { get; set; }
        public List<Coin> Data { get; set; }

        public Coin FromJson(string json)
        {
            return JsonConvert.DeserializeObject<Coin>(json, Converter.Settings);
        }

        public string ToJson(Coin self)
        {
            return JsonConvert.SerializeObject(self, Converter.Settings);
        }
    }


}