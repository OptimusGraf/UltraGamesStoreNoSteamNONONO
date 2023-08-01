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
    // Тут разобраться с искл
    internal partial class SignInControl : UserControl
    {
        IMarket market;
        public SignInControl(IMarket market)
        {
            this.market = market;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // try
            {
                market.SignIn(textBox1.Text, textBox2.Text);
                ParentForm.DialogResult = DialogResult.OK;
                ParentForm.Close();
            }
           // catch (Exception ex)
            {
          //      MessageBox.Show("Неверный логин или пароль");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("В целях безопасноти,мы не восстанавливаем пароль. ВСПОМИНАЙТЕ");

        }
    }
}
