
namespace UltraGamesStoreNoSteamNONONO
{
    public partial class AuthorForm : Form
    {
        public AuthorForm(IMarket market)
        {
            InitializeComponent();
            Controls.Add(new GamePanelAuthor(market));
        }
    }
}
