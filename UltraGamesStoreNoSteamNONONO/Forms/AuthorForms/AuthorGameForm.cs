
namespace UltraGamesStoreNoSteamNONONO
{
    public abstract partial class AuthorGameForm : Form
    {
        public IMarket Market { get; set; }
        protected Game game;
        public AuthorGameForm(IMarket market)
        {
            this.Market = market;
            InitializeComponent();
        }

        public abstract void UpdateView();

        private void AuthorGameForm_Load(object sender, EventArgs e)
        {
            UpdateView();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Save();

        }
        protected abstract void Save();

        private void buttonIcon_Click(object sender, EventArgs e)
        {
            myPictureBoxIcon.SetImageFromDialog();

        }
        private void buttonImage_Click(object sender, EventArgs e)
        {
            myPictureBoxImage.SetImageFromDialog();
        }
    }
}
