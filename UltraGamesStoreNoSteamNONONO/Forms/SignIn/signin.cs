
namespace UltraGamesStoreNoSteamNONONO
{
    internal partial class SignIn : Form
    {
        IMarket market;
        UserControl control;
        public SignIn(IMarket market) : base()
        {
            this.market = market;
            InitializeComponent();
        }

        private void signin_Load(object sender, EventArgs e)
        {
            control = new SignInControl(market);
            control.Dock = DockStyle.Fill;
            panel1.Controls.Add(control);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // можно будет добавить возвращение назад
            panel1.Controls.Remove(control);
            control = new SignUpControl(market);
            control.Dock = DockStyle.Fill;
            panel1.Controls.Add(control);
            linkLabel2.Text = "";
        }
    }
}
