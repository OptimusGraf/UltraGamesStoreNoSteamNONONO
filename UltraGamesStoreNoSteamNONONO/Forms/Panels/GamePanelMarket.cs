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
        public int Cursor { get=>cursor; set=>cursor=value; }
        public override void UpdateView()
        {
            Controls.Clear();
            List<Game> list = Market.TopTenGamesFrom(cursor);
            base.AddToPanel(list);
        }
    }
}
