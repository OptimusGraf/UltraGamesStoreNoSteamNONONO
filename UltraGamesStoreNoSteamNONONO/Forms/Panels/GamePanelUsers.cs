using System;
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
            Controls.Clear();

            HashSet<Game> list=  Market.GetUsersListOfGames();
            foreach (UserGame game in list)
            {
                GameViewUser control = new GameViewUser(game,Market);
                this.Controls.Add(control);
            }
        }
    }
}
