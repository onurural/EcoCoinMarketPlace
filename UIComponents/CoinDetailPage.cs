using EcoCoinMarketPlace.Controller;
using EcoCoinMarketPlace.Models.Coins;
using System;
using WebSocketSharp;
using System.Windows.Forms;
using System.Threading;
using System.Windows.Forms.DataVisualization.Charting;

namespace EcoCoinMarketPlace.UIComponents
{
    public partial class CoinDetailPage : Form
    {
        public string CoinPrice;
        private string CoinName;
        private const String baseWSUrl = "wss://ws.coincap.io/prices?assets=";
        DailyCoin dailyCoinData;
        public bool isRegistered;
        WebSocket webSocket;
        Coin coin;
        public CoinDetailPage(string coinMenuCoin1Name)
        {
            CoinName = coinMenuCoin1Name;
            InitializeComponent();
            Thread.Sleep(1000);
            dailyCoinData = RestApiController.GetCoinDailyData(coinMenuCoin1Name.ToLower().ToString());
            coin = RestApiController.GetCoinData(CoinName);
            webSocket = new WebSocket(baseWSUrl + coinMenuCoin1Name);
            // Event Handler Function Will Execute on Every new Message from WebSocket 
            webSocket.OnMessage += Ws_OnMessage;
            webSocket.Connect();
            FillCoinData(coin);
            FillChart();


        }

        private void FillCoinData(Coin coin)
        {
            coinDetailName.Text = "Name : "+coin.Name;
            coinDetailId.Text = "Id : "+coin.Id;
            coin24HPercentage.Text = "Change Percent 24 Hour : "+coin.ChangePercent24Hr;
            coinDetailMarketCap.Text = "Market Cap : "+coin.MarketCapUsd;
            coinDetailVolume.Text = "Max Supply : "+coin.Supply;
        
        }

        private void FillChart()
        {
            for (int i = 0; i < 363; i++)
            {
                chart1.Series["PriceDaily"].Points.AddXY(dailyCoinData.Data[i].Date.ToString().Substring(0, 10), dailyCoinData.Data[i].PriceUsd);


            }
            ChartArea chartArea = chart1.ChartAreas["ChartArea1"];
            chartArea.AxisX.Minimum = 0;
            chartArea.AxisX.Maximum = 363;
            chartArea.CursorX.AutoScroll = true;
            chartArea.AxisX.ScaleView.Zoomable = true;
            chartArea.AxisX.ScaleView.SizeType = DateTimeIntervalType.Number;
            chartArea.AxisX.ScaleView.Zoom(0, 10);
            chartArea.AxisX.ScrollBar.ButtonStyle = ScrollBarButtonStyles.SmallScroll;
            chartArea.AxisX.ScaleView.SmallScrollSize = 363;
            chartArea.AxisX.ScrollBar.Size = 20;
            chartArea.AxisY.ScrollBar.ButtonStyle = ScrollBarButtonStyles.SmallScroll;
            chartArea.AxisY.ScrollBar.IsPositionedInside = true;
            chartArea.AxisY.ScrollBar.Enabled = true;
            


            chart1.Titles.Add(CoinName.ToUpper()+" Daily Chart"); ;
        }

        private void Ws_OnMessage(object sender, MessageEventArgs e)
        {
            CoinPrice = e.Data;
        }

        private void timer1_Click(object sender, EventArgs e)
        {
            coinRealTimePrice.Text = CoinPrice;
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
