using EcoCoinMarketPlace.Models;
using EcoCoinMarketPlace.Models.Coins;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace EcoCoinMarketPlace.API
{
    public enum RequestType

    {
        assets,
        history,
        rates,
        exchanges,
        markets,
        candles

    }

    public enum HttpMethodType
    {
        GET
    }



    class RestApiClient
    {

        // Constants
        private const string baseApiUrl = "https://api.coincap.io/v2";



        public HttpMethodType HttpMethodType { get; set; }


        private RestApiClient()
        {
            HttpMethodType = HttpMethodType.GET;
        }
        private static RestApiClient instance = null;

        public static RestApiClient Instance()
        {

            if (instance == null)
            {
                instance = new RestApiClient();
            }
            return instance;

        }



        // Where the magic happens...
        public IModel MakeRequest(RequestType requestType, string CoinName = "bitcoin")
        {
            string EndPoint;
            EndPoint = baseApiUrl + "/" + requestType.ToString().ToLower();
            if (requestType == RequestType.history)
            {
                EndPoint = baseApiUrl + "/assets" +"/"+ CoinName.ToLower() + "/history?interval=d1";
            }

            // Creating object using .Create method and Casting to HttpWebRequest type
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(EndPoint);
            // Defining method type (GET,PUT...)
            request.Method = HttpMethodType.ToString();


            HttpWebResponse httpWebResponse = (HttpWebResponse)request.GetResponse();



            if (httpWebResponse.StatusCode != HttpStatusCode.OK)
            {
                /// TODO IMPLEMENT ERROR CLASS
                Console.WriteLine("Error happened in RestClient Status Code: " + httpWebResponse.StatusCode);

                throw new Exception();

            }
            else
            {
                // if the process is success than get the message from api in JSON form 
                Stream responseStream = httpWebResponse.GetResponseStream();
                if (responseStream == null)
                {
                    throw new Exception();
                }
                else
                {
                    StreamReader streamReader = new StreamReader(responseStream);
                    string apiResponseMessage = streamReader.ReadToEnd();

                    /** TODO DESERIALIZE JSON */


                    switch (requestType)
                    {
                        case RequestType.assets:
                            Coins coin = Coins.FromJson(apiResponseMessage);
                            return coin;

                        case RequestType.history:
                            DailyCoins CoinDailyDataList = DailyCoins.FromJson(apiResponseMessage);
                            return CoinDailyDataList;

                        case RequestType.exchanges:
                            Exchanges exchange = Exchanges.FromJson(apiResponseMessage);
                            return exchange;
                        default:
                            throw new Exception();

                    }

                }
            }

        }


    }
}
