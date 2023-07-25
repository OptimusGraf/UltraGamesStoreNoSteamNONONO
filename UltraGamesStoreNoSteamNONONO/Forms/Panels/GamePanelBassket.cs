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
            Controls.Clear();
            HashSet<Game> list=  Market.GetBasketList();
            base.AddToPanel(list);
            Button buttonBuy = new Button();
            buttonBuy.Text = "Купить";
            buttonBuy.AutoSize = true;
            buttonBuy.Anchor = AnchorStyles.Left;
            buttonBuy.Click += ButtonBuy_Click;
            this.Controls.Add(buttonBuy);
        }

        private void ButtonBuy_Click(object? sender, EventArgs e)
        {
            Market.BuyGames();
        }
    }
}
