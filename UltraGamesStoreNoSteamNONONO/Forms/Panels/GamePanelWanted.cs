using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltraGamesStoreNoSteamNONONO
{
    public class GamePanelWanted : GamePanel
    {
        public GamePanelWanted(IMarket market) : base(market)
        {


        }
        public override void UpdateView()
        {
            HashSet<Game> list = Market.GetWantedList();
            base.AddToPanel(list);
        }
    }
}
