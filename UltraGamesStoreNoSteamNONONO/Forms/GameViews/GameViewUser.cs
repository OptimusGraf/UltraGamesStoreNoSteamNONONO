using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltraGamesStoreNoSteamNONONO.Forms.GameViews
{
    public class GameViewUser : GameView
    {
        public GameViewUser(string name, string author, Image icon, bool isLoaded) : base(name, author, icon)
        {
            Button1.Text = "Играть";
            Button1.Text = "Скачать";
        }
    }
}
