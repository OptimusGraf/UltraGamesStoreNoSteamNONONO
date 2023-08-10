
namespace UltraGamesStoreNoSteamNONONO
{
    public class GameViewUser : GameView
    {
        public GameViewUser(UserGame game, IMarket market) : base(game, market)
        {
        }
        protected override void MakeButtons()
        {
            button1.Click += button1_Click;
            button2.Click += button2_Click;
            button1.Text = "Играть";
            if (((UserGame)game).IsLoaded == true)
            {
                button1.Enabled = true;
                button2.Text = "Удалить";
            }
            else
            {
                button1.Enabled = false;
                button2.Text = "Скачать";
            }
        }
        protected  void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Игра запускается");
            MessageBox.Show("В игре запланированные техработы");
        }
        protected  void button2_Click(object sender, EventArgs e)
        {
        
            ((UserGame)game).IsLoaded = !((UserGame)game).IsLoaded;
            if (((UserGame)game).IsLoaded)
            {
                button1.Enabled = true;
                button2.Text = "Удалить";
            }
            else
            {
                button1.Enabled = false;
                button2.Text = "Скачать";
            }
        }
    }
}
