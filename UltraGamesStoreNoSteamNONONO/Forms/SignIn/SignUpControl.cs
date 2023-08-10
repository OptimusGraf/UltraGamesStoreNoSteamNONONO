
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

            if (market.SignIn(textBox1.Text, textBox2.Text))
            {
                market.SignUp(textBox1.Text, Convert.ToInt32(numericUpDown1.Value), textBox2.Text, Convert.ToInt32(numericUpDown2.Value));
                market.SignIn(textBox1.Text, textBox2.Text);
                MessageBox.Show("Вы успешно зарегистрировались");
                ParentForm.DialogResult = DialogResult.OK;
                ParentForm.Close();
            }
            else
            {
                MessageBox.Show("Неверные данные");
            }

        }
    }
}
