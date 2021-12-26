using EcoCoinMarketPlace.Models.Coins;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EcoCoinMarketPlace.UIComponents
{
    public partial class CoinRow : UserControl
    {



        public CoinRow()
        {
            InitializeComponent();


        }


        private void coinMenuCoin1Rank_Click(object sender, EventArgs e)
        {
            CoinDetailPage coinDetailPage = new CoinDetailPage(coinMenuCoin1Name.Text.ToLower());
            coinDetailPage.Show();
        }

        private void coinMenuCoin1Name_Click(object sender, EventArgs e)
        {
            CoinDetailPage coinDetailPage = new CoinDetailPage(coinMenuCoin1Name.Text.ToLower());
            coinDetailPage.Show();

        }

        private void coinMenuCoin1Price_Click(object sender, EventArgs e)
        {
            CoinDetailPage coinDetailPage = new CoinDetailPage(coinMenuCoin1Name.Text.ToLower());
            coinDetailPage.Show();
        }

        private void coinMenuCoin124HPercentage_Click(object sender, EventArgs e)
        {
            CoinDetailPage coinDetailPage = new CoinDetailPage(coinMenuCoin1Name.Text.ToLower());
            coinDetailPage.Show();
        }

        private void coinMenuCoin1MarketCap_Click(object sender, EventArgs e)
        {
            CoinDetailPage coinDetailPage = new CoinDetailPage(coinMenuCoin1Name.Text.ToLower());
            coinDetailPage.Show();
        }

        private void coinMenuCoin1Volume_Click(object sender, EventArgs e)
        {
            CoinDetailPage coinDetailPage = new CoinDetailPage(coinMenuCoin1Name.Text.ToLower());
            coinDetailPage.Show();

        }

        private void coinMenuCoin1CirculatingSupply_Click(object sender, EventArgs e)
        {
            CoinDetailPage coinDetailPage = new CoinDetailPage(coinMenuCoin1Name.Text.ToLower());
            coinDetailPage.Show();

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
