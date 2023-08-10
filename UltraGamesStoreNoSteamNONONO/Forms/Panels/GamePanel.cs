

namespace UltraGamesStoreNoSteamNONONO
{
    public abstract class GamePanel : Panel, IView
    {
        protected FlowLayoutPanel flowLayoutPanel;
        public GamePanel(IMarket market)
        {
            Market = market;
            market.ChangedUI += this.UpdateView;
            Dock = DockStyle.Fill;
            flowLayoutPanel = new FlowLayoutPanel();
            flowLayoutPanel.Dock = DockStyle.Fill;
            flowLayoutPanel.WrapContents = false;
            flowLayoutPanel.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel.AutoScroll = true;
            this.Controls.Add(flowLayoutPanel);
            UpdateView();
        }

        public IMarket Market { get; set; }
        public abstract void UpdateView();
        protected virtual void AddToFlowPanel(IEnumerable<Game> list)
        {
            flowLayoutPanel.Controls.Clear();

            foreach (Game game in list)
            {
                GameView gameView = new GameViewMarket(game, Market);
                gameView.DoubleClick += GameView_Click;
                
                flowLayoutPanel.Controls.Add(gameView);
            }
        }

        protected void GameView_Click(object? sender, EventArgs e)
        {
            Click((GameView)sender, ((GameView)sender).Game);
        }
        protected virtual void Click(GameView view, Game game)
        {
            flowLayoutPanel.Enabled = false;
            flowLayoutPanel.Visible = false;
            Control control = new GameTabControl(view, Market, game);
            control.Dock = DockStyle.Fill;
            this.Controls.Add(control);
        }
     
    }
}
