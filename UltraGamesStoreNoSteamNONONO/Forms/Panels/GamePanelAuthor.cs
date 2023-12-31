﻿

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
            ChangeGameForm form = new ChangeGameForm(Market, game);
            form.ShowDialog();
        }

    }
}
