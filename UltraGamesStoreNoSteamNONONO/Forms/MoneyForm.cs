using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UltraGamesStoreNoSteamNONONO
{
    public partial class MoneyForm : Form
    {
        IMarket market;
        public MoneyForm(IMarket market)
        {
            InitializeComponent();
            this.market = market;
            label1.Text = "Ваш счет равен: " + market.UsersMoney.ToString();
        }

        private void buttonAddMoney_Click(object sender, EventArgs e)
        {
            market.UsersMoney += numericUpDownMoney.Value;
            MessageBox.Show("Счет успешно пополен и равен: " + market.UsersMoney.ToString());
            this.Close();
        }
    }
}
