using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltraGamesStoreNoSteamNONONO
{
    public class GamePanelBassket : GamePanel
    {
        public GamePanelBassket(IMarket market) : base(market)
        {
          
            
        }
        public override void UpdateView()
        {
            HashSet<Game> list=  Market.GetBasketList();
            base.AddToPanel(list);
        }
    }
}
