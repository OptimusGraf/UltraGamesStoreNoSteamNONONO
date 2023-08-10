

namespace UltraGamesStoreNoSteamNONONO
{
    public partial class GameTabControl : UserControl, IView
    {
        protected Game game;
        public IMarket Market { get; set; }
        GameView gameView;
        public GameTabControl(GameView gameView, IMarket market, Game game)
        {
            this.Market = market;
            market.ChangedUI += UpdateView;
            this.game = game;
            this.gameView = gameView;
            gameView.Enabled = false;

            InitializeComponent();
            panelForGameView.Controls.Add(gameView);
            UpdateView();
        }
        public void UpdateView()
        {
            labelAge.Text += game.RecAge;
            labelPower.Text += game.PowerOfPc;
            pictureBoxForMainImage.Image = game.ImageOfGame.FromByteArrayToImage();
            AddReviews();
        }

        public void AddReviews()
        {
            flowLayoutPanel1.Controls.Clear();
            List<Review> reviews = Market.GetReviews(game);
            foreach (Review review in reviews)
            {
                flowLayoutPanel1.Controls.Add(new ReviewView(Market, review, game.Author));
            }
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            foreach (Control contorl in Parent.Controls)
            {
                contorl.Visible = true;
                contorl.Enabled = true;
            }
            gameView.Enabled = true;
            if (Parent is IView)
            {
                ((IView)Parent).UpdateView();
            }
            Parent.Controls.Remove(this);
        }

        private void buttonSaveReview_Click(object sender, EventArgs e)
        {
            Market.NewReview(game, Convert.ToInt32(numericUpDown1.Value), richTextBoxNewReview.Text);
        }
    }
}
