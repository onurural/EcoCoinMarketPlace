using EcoCoinMarketPlace.API;
using EcoCoinMarketPlace.Models;
using EcoCoinMarketPlace.Models.Coins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoCoinMarketPlace.Controller
{
    enum CoinType
    {

        bitcoin,
        etherium,
        dogecoin

    }



    class RestApiController
    {

        static RestApiClient restApiClient;
        static private Coins coins;
        static private Exchanges exchanges;


        public static bool InitializeRestfulApi()
        {
            try
            {
                restApiClient = RestApiClient.Instance();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error on Initialize Restful Api " + e);
                return false;
            }
        }

        public static Coin GetCoinData(string coin)
        {
            Coin coin1 = new Coin() ;
            for (int i = 0; i<coins.Data.Count; i++)
            {
                if (coins.Data[i].Name.ToLower() == coin)
                {
                    coin1 = coins.Data[i];
                }
            }

            return coin1;
        }

        public static void MakeRequest(RequestType requestType)
        {
            switch (requestType)
            {
                case RequestType.assets:
                    coins = (Coins)restApiClient.MakeRequest(requestType);
                    break;
                case RequestType.exchanges:
                    exchanges = (Exchanges)restApiClient.MakeRequest(requestType);
                    break;
            }

        }

        public static DailyCoins GetCoinDailyData(string CoinName)
        {
            return (DailyCoins)restApiClient.MakeRequest(RequestType.history, CoinName);

        }

        public static Coin[] GetTopThreeCoin()
        {
            Coin c1 = coins.Data[0];
            Coin c2 = coins.Data[1];
            Coin c3 = coins.Data[2];


            Coin[] topThreeCoin = { c1, c2, c3 };

            return topThreeCoin;
        }

        public static Exchange[] GetTopThreeExchange()
        {
            Exchange ex1 = exchanges.Data[0];
            Exchange ex2 = exchanges.Data[1];
            Exchange ex3 = exchanges.Data[2];

            Exchange[] topThreeExchange = { ex1, ex2, ex3 };
            return topThreeExchange;
        }

        public static Coin[] GetMainMenuCoinData()
        {

            Coin[] coinList = new Coin[100];
            int i = 0;
            foreach (Coin coin in coins.Data)
            {
                coinList[i] = coin;
                i++;
            }

            return coinList;

        }









    }
}
