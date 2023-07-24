using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UltraGamesStoreNoSteamNONONO;

namespace UltraGamesStoreNoSteamNONONO
{
    public abstract class GamePanel:FlowLayoutPanel, IView
    {
        public GamePanel(IMarket market)
        {
            Market = market;
            Dock = DockStyle.Fill;
            WrapContents = false;
            FlowDirection = FlowDirection.TopDown;
            UpdateView();
        }

        public IMarket Market { get; set; }
        public abstract void UpdateView();
        protected virtual void AddToPanel(IEnumerable<Game> list)
        {
            foreach (Game game in list)
            {
                GameView control = new GameView(game.Name, game.Author, game.Icon);
                this.Controls.Add(control);
            }
        }
     

    }
}
