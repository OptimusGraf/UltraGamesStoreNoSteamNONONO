using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltraGamesStoreNoSteamNONONO
{
    public class GameViewAuthor : GameView
    {
        public GameViewAuthor(Game game, IMarket market) : base(game,market)
        {

            Button1.Text = "Информация";
            Button2.Text = "Отредактировать";
        }
        
    }
}
