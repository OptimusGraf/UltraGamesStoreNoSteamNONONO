
namespace UltraGamesStoreNoSteamNONONO
{
    public class GameViewMarket : GameView
    {
        public GameViewMarket(Game game, IMarket market) : base(game, market)
        {
        }
        protected override void MakeButtons()
        {
            if (Market.AvaibaleContainGames(game) == false)
            {
                if (Market.BassketContainGames(game))
                {
                    button1.Text = "Удалить из коризны";
                    button1.Click += Button1_ClickRemove;

                }
                else
                {
                    button1.Text = "В коризну";
                    button1.Click += button1_ClickAdd;
                }

                if (Market.WantedContainGames(game))
                {
                    button2.Text = "Удалить из желаемого";
                    button2.Click += Button2_ClickRemove;

                }
                else
                {
                    button2.Enabled = true;
                    button2.Click += Button2_ClickAdd;
                }
            }
            else
            {
                button1.Text = "Куплена";
                button2.Text = "Куплена";
                button1.Enabled = false;
                button2.Enabled = false;
            }


            labelName.Text += " цена: " + game.Money.ToString();
        }

        private void Button2_ClickAdd(object? sender, EventArgs e)
        {
            string result = Market.AddToWantedList(game);
            if (result != "")
            {
                MessageBox.Show(result);
            }
        }

        private void Button2_ClickRemove(object? sender, EventArgs e)
        {
            Market.RemoveFromWantedList(game);
        }

        private void Button1_ClickRemove(object? sender, EventArgs e)
        {
            Market.RemoveFromBasketList(game);
        }

        protected virtual void button1_ClickAdd(object sender, EventArgs e)
        {
            string result = Market.AddToBasketList(game);
            if (result != "")
            {
                MessageBox.Show(result);
            }

        }
    }
}
