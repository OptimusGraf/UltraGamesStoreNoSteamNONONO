﻿
namespace UltraGamesStoreNoSteamNONONO
{
    public class GameViewAuthor : GameView
    {
        public GameViewAuthor(Game game, IMarket market) : base(game,market)
        {
            this.Controls.Remove(button1);
            this.Controls.Remove(button2);  
        }
        protected override void MakeButtons()
        {
        }

    }
}
