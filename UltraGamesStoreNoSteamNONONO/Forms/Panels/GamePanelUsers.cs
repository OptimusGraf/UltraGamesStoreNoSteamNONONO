using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UltraGamesStoreNoSteamNONONO.Forms.GameViews;

namespace UltraGamesStoreNoSteamNONONO
{
    public class GamePanelUsers : GamePanel
    {
        public GamePanelUsers(IMarket market) : base(market)
        {
          
            
        }
        public override void UpdateView()
        {
            HashSet<Game> list=  Market.GetUsersListOfGames();
            foreach (UserGame game in list)
            {
                GameViewUser control = new GameViewUser(game.Name, game.Author, game.Icon,game.IsLoaded );
                this.Controls.Add(control);
            }
        }
    }
}
