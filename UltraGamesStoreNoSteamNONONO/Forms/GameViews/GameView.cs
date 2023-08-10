
namespace UltraGamesStoreNoSteamNONONO
{
    public abstract partial class GameView : UserControl, IView
    {
        public Game Game { get => game; }
        protected Game game;
        public IMarket Market { get; set; }
        public void UpdateView()
        {
            labelName.Text = game.Name;
            labelAuthor.Text = game.Author;
            pictureBox1.Image = game.Icon.FromByteArrayToImage();
            labelDate.Text = game.Release.ToString();
            labelRate.Text = game.Rate.ToString();
            MakeButtons();
        }
        public GameView(Game game, IMarket market)
        {
            this.game = game;
            this.Market = market;
            market.ChangedUI += UpdateView;
            this.Dock = DockStyle.Fill;
            InitializeComponent();
            UpdateView();
        }

        protected abstract void MakeButtons();
    }
}
