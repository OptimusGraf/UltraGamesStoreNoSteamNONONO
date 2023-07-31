using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UltraGamesStoreNoSteamNONONO;

namespace UltraGamesStoreNoSteamNONONO
{
    public abstract class GamePanel : Panel, IView
    {
        protected FlowLayoutPanel flowLayoutPanel;
        public GamePanel(IMarket market)
        {
            Market = market;
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
                GameView gameView = new GameView(game, Market);
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
            this.Controls.Add(new GameTabControl(view, Market, game));
        }
    
    }
}
