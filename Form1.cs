using EcoCoinMarketPlace.API;
using System;
using EcoCoinMarketPlace.Controller;
using System.Windows.Forms;
using System.Threading;
using EcoCoinMarketPlace.UIComponents;
using EcoCoinMarket.Models.LoginRegister;

namespace EcoCoinMarketPlace
{
    public partial class Form1 : Form
    {

        public Form1(bool isLogin)
        {
            
            bool isConnected = RestApiController.InitializeRestfulApi();


            InitializeComponent(isLogin);
            if (isConnected)
            {
                RestApiController.MakeRequest(RequestType.assets);
                Thread.Sleep(1000);
                RestApiController.MakeRequest(RequestType.exchanges);
                FillTopThreeCoin();
                FillTopThreeExchange();
                FillCoinMainMenu();


            }
            else
            {
                Console.WriteLine("Error on form1 restful api connection");
            }
        }

        private void FillCoinMainMenu()
        {

            var coinList = RestApiController.GetMainMenuCoinData();
            int row = 0;



            int length = tableLayoutPanel5.Controls.Count;
            string type = tableLayoutPanel5.Controls[0].GetType().ToString();

            foreach (CoinRow element in tableLayoutPanel5.Controls)
            {
                /*CoinRow element = (CoinRow)this.tableLayoutPanel5.Controls[i];*/
                
                element.coinMenuCoin1Name.Text = coinList[row].Name;
                element.coinMenuCoin1Rank.Text = coinList[row].Rank.ToString();
                element.coinMenuCoin1Price.Text = coinList[row].PriceUsd.Substring(0, 5);
                element.coinMenuCoin1MarketCap.Text = coinList[row].MarketCapUsd.Substring(0, 5);
                element.coinMenuCoin124HPercentage.Text = coinList[row].ChangePercent24Hr.Substring(0, 5);
                element.coinMenuCoin1CirculatingSupply.Text = coinList[row].Supply.Substring(0, 5);
                element.coinMenuCoin1Volume.Text = coinList[row].VolumeUsd24Hr.Substring(0, 5);

                

                row++;
            }







            // get all labels in table  




            /*coinMenuCoin1Rank.Text = coinList[0].Rank.ToString();
            coinMenuCoin1Name.Text = coinList[0].Name;
            coinMenuCoin1Price.Text = coinList[0].PriceUsd;
            coinMenuCoin124HVolume.Text = coinList[0].VolumeUsd24Hr;
            coinMenuCoin124Percentage.Text = coinList[0].ChangePercent24Hr;
            coinMenuCoin1MarketCap.Text = coinList[0].MarketCapUsd;
            coinMenuCoin1CS.Text = coinList[0].Supply;*/




        }

        private void FillTopThreeExchange()
        {
            var topThreeExchange = RestApiController.GetTopThreeExchange();
            trendExchange1Name.Text = topThreeExchange[0].Name;
            trendExchange2Name.Text = topThreeExchange[1].Name;
            trendExchange3Name.Text = topThreeExchange[2].Name;

            trendExchange1Url.Text = topThreeExchange[0].ExchangeUrl.ToString();
            trendExchange2Url.Text = topThreeExchange[1].ExchangeUrl.ToString();
            trendExchange3Url.Text = topThreeExchange[2].ExchangeUrl.ToString();

            trendExchange1PercentageVolume.Text = topThreeExchange[0].PercentTotalVolume;
            trendExchange2PercentageVolume.Text = topThreeExchange[1].PercentTotalVolume;
            trendExchange3PercentageVolume.Text = topThreeExchange[2].PercentTotalVolume;

        }

        private void FillTopThreeCoin()
        {

            var topThree = RestApiController.GetTopThreeCoin();
            trendCoin1Name.Text = topThree[0].Name;
            trendCoin2Name.Text = topThree[1].Name;
            trendCoin3Name.Text = topThree[2].Name;


            trendCoin1Symbol.Text = topThree[0].Symbol;
            trendCoin2Symbol.Text = topThree[1].Symbol;
            trendCoin3Symbol.Text = topThree[2].Symbol;


            trendCoin1Price.Text = topThree[0].ChangePercent24Hr;
            trendCoin2Price.Text = topThree[1].ChangePercent24Hr;
            trendCoin3Price.Text = topThree[2].ChangePercent24Hr;


        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void coinRow2_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
