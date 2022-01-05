using EcoCoinMarket.Models.LoginRegister;
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
        public bool isRegistered;


        public CoinRow(bool isRegistered)
        {
            this.isRegistered = isRegistered;
            InitializeComponent();


        }


        private void coinMenuCoin1Rank_Click(object sender, EventArgs e)
        {
            CoinDetailPage coinDetailPage = new CoinDetailPage(coinMenuCoin1Name.Text.ToLower());
            if (isRegistered) { 
            coinDetailPage.Show();}
            else
            {
                DialogResult res = MessageBox.Show("Please Login", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (res == DialogResult.OK)
                {
                    this.Hide();
                    
                    Login login = new Login();
                    login.ShowDialog();


                }
                if (res == DialogResult.Cancel)
                {
                    this.Hide();
                    
                }


            }
            
        }

        private void coinMenuCoin1Name_Click(object sender, EventArgs e)
        {
            CoinDetailPage coinDetailPage = new CoinDetailPage(coinMenuCoin1Name.Text.ToLower());
            if (isRegistered)
            {
                coinDetailPage.Show();
            }
            else
            {
                DialogResult res = MessageBox.Show("Please Login", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (res == DialogResult.OK)
                {
                    this.Hide();
                  
                    Login login = new Login();
                    login.ShowDialog();


                }
                if (res == DialogResult.Cancel)
                {
                    this.Hide();

                }


            }
            
        }

        private void coinMenuCoin1Price_Click(object sender, EventArgs e)
        {
            CoinDetailPage coinDetailPage = new CoinDetailPage(coinMenuCoin1Name.Text.ToLower());
            if (isRegistered)
            {
                coinDetailPage.Show();
            }
            else
            {
                DialogResult res = MessageBox.Show("Please Login", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (res == DialogResult.OK)
                {
                    this.Hide();
                    
                    Login login = new Login();
                    login.ShowDialog();


                }
                if (res == DialogResult.Cancel)
                {
                    this.Hide();

                }

                
            }
        }

        private void coinMenuCoin124HPercentage_Click(object sender, EventArgs e)
        {
            CoinDetailPage coinDetailPage = new CoinDetailPage(coinMenuCoin1Name.Text.ToLower());
            if (isRegistered)
            {
                coinDetailPage.Show();
            }
            else
            {
                DialogResult res = MessageBox.Show("Please Login", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (res == DialogResult.OK)
                {
                    this.Hide();
                    
                    Login login = new Login();
                    login.ShowDialog();


                }
                if (res == DialogResult.Cancel)
                {
                    this.Hide();

                }


            }
            
        }

        private void coinMenuCoin1MarketCap_Click(object sender, EventArgs e)
        {
            CoinDetailPage coinDetailPage = new CoinDetailPage(coinMenuCoin1Name.Text.ToLower());
            if (isRegistered)
            {
                coinDetailPage.Show();
            }
            else
            {
                DialogResult res = MessageBox.Show("Please Login", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (res == DialogResult.OK)
                {
                    this.Hide();
                    
                    Login login = new Login();
                    login.ShowDialog();


                }
                if (res == DialogResult.Cancel)
                {
                    this.Hide();

                }


            }
            
        }

        private void coinMenuCoin1Volume_Click(object sender, EventArgs e)
        {
            CoinDetailPage coinDetailPage = new CoinDetailPage(coinMenuCoin1Name.Text.ToLower());
            if (isRegistered)
            {
                coinDetailPage.Show();
            }
            else
            {
                DialogResult res = MessageBox.Show("Please Login", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (res == DialogResult.OK)
                {
                    this.Hide();
                    
                    Login login = new Login();
                    login.ShowDialog();


                }
                if (res == DialogResult.Cancel)
                {
                    this.Hide();

                }


            }
            
        }

        private void coinMenuCoin1CirculatingSupply_Click(object sender, EventArgs e)
        {
            CoinDetailPage coinDetailPage = new CoinDetailPage(coinMenuCoin1Name.Text.ToLower());
            if (isRegistered)
            {
                coinDetailPage.Show();
            }
            else
            {
                DialogResult res = MessageBox.Show("Please Login", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (res == DialogResult.OK)
                {
                    this.Hide();
                    
                    Login login = new Login();
                    login.ShowDialog();


                }
                if (res == DialogResult.Cancel)
                {
                    this.Hide();

                }


            }
           
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
