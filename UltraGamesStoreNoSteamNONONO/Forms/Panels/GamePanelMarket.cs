using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltraGamesStoreNoSteamNONONO
{
    public class GamePanelMarket : GamePanel
    {
        public GamePanelMarket(IMarket market) : base(market)
        {
        }
        int cursor = 0;
        public override void UpdateView()
        {
            List<Game> list = Market.TopTenGamesFrom(0);
            base.AddToPanel(list);
        }
    }
}
