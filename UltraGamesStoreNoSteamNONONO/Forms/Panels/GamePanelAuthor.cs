using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UltraGamesStoreNoSteamNONONO.Forms;

namespace UltraGamesStoreNoSteamNONONO
{
    public class GamePanelAuthor : GamePanel
    {
        public GamePanelAuthor(IMarket market) : base(market)
        {
            
        }
        public override void UpdateView()
        {
            List<Game> list=  Market.GetUserCreatedGames();
            flowLayoutPanel.Controls.Clear();

            foreach (Game game in list)
            {
                GameViewAuthor gameView = new GameViewAuthor(game, Market);
                gameView.DoubleClick += GameView_Click;

                flowLayoutPanel.Controls.Add(gameView);
            }

        }

        protected override void Click(GameView view, Game game)
        {
            AuthorGameForm form = new AuthorGameForm(Market, game);
            form.ShowDialog();
        }

    }
}
