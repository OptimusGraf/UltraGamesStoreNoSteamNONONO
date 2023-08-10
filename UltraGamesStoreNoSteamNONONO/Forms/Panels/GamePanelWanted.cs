

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
            base.AddToFlowPanel(list);
       
        }
    }
}
