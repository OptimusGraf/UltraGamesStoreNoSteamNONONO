
namespace UltraGamesStoreNoSteamNONONO
{
    public partial class NotificationForm : Form
    {
        IMarket market;
        public NotificationForm(IMarket market)
        {
            this.market = market;
            InitializeComponent();
        }

        private void NotificationForm_Load(object sender, EventArgs e)
        {
            List<string> notifications = market.GetNotifications();
            foreach (string notification in notifications)
            {
                listBox1.Items.Add(notification);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            market.RemoveNotififcations();
            listBox1.Items.Clear();
        }
    }
}
