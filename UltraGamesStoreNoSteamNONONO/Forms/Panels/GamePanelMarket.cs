
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
            List<Game> list = Market.TopTenGamesFrom(cursor);
            base.AddToFlowPanel(list);
        }
    }
}
