﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltraGamesStoreNoSteamNONONO
{
    public class GamePanelUsers : GamePanel
    {
        public GamePanelUsers(IMarket market) : base(market)
        {
          
            
        }
        public override void UpdateView()
        {
            flowLayoutPanel.Controls.Clear();

            HashSet<Game> list=  Market.GetUsersListOfGames();
            foreach (Game game in list)
            {
                GameViewUser gameView = new GameViewUser((UserGame)game,Market);
                gameView.DoubleClick += GameView_Click;

                flowLayoutPanel.Controls.Add(gameView);
            }
        }
    }
}