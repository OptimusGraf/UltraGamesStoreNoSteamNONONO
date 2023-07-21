using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace UltraGamesStoreNoSteamNONONO
{
    internal partial class SignUpControl : UserControl
    {
        IMarket market;
        public SignUpControl(IMarket market)
        {
            this.market = market;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                market.SignUp(textBox1.Text, Convert.ToInt32(numericUpDown1.Value), textBox2.Text, Convert.ToInt32(numericUpDown2.Value));
                market.SignIn(textBox1.Text, textBox2.Text);
                MessageBox.Show("Вы успешно зарегистрировались");
                ParentForm.DialogResult = DialogResult.OK;
                ParentForm.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Неверные данные");
            }
        }
    }
}
