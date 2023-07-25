using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltraGamesStoreNoSteamNONONO
{
    public class GameViewUser : GameView
    {
        public GameViewUser(UserGame game, IMarket market) : base(game, market)
        {
           
        }
        protected override void MakeButtons(Game game, IMarket market)
        {
            Button1.Click += button1_Click;
            Button2.Click += button2_Click;
            Button1.Text = "Играть";
            if (((UserGame)game).IsLoaded == true)
            {
                Button1.Enabled = true;
                Button2.Text = "Удалить";
            }
            else
            {
                Button1.Enabled = false;
                Button2.Text = "Скачать";
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
                Button1.Enabled = true;
                Button2.Text = "Удалить";
            }
            else
            {
                Button1.Enabled = false;
                Button2.Text = "Скачать";
            }
        }
    }
}
