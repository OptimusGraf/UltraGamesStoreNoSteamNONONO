
namespace UltraGamesStoreNoSteamNONONO
{
    public partial class InfoAboutUserForm : Form
    {
        IMarket market;
        public InfoAboutUserForm(IMarket market)
        {
            this.market = market;
            InitializeComponent();

        }

        private void InfoAboutUserForm_Load(object sender, EventArgs e)
        {
            UserInfo info = market.GetInfoAboutUser();
            label1.Text += " " + info.UserName;
            numericUpDownAge.Value = info.Age;
            numericUpDownPower.Value = info.PowerOfPC;

            myPictureBox1.Image = info.Image;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            market.SetInfoAboutUser(Convert.ToInt32(numericUpDownAge.Value), Convert.ToInt32(numericUpDownPower.Value), myPictureBox1.Image);
        }

        private void buttonImage_Click(object sender, EventArgs e)
        {
            myPictureBox1.SetImageFromDialog();
        }
    }
}
