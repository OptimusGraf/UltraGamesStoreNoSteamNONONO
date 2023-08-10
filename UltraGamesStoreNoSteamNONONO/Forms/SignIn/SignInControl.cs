
namespace UltraGamesStoreNoSteamNONONO
{
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
            if (market.SignIn(textBox1.Text, textBox2.Text))
            {
                ParentForm.DialogResult = DialogResult.OK;
                ParentForm.Close();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("В целях безопасноти,мы не восстанавливаем пароль. ВСПОМИНАЙТЕ");
        }
    }
}
