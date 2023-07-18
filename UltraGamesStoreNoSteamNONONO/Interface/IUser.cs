using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltraGamesStoreNoSteamNONONO
{
    internal interface IUser
    {
        public SQLBase SQLBase { get; set; }
        public string UserName { get; }
        public int Age { get; }
        public int PowerOfPC { get; set; }
        public Image Image { get; set; }
        public HashSet<IGame> Basket { get; }
        public void AddGameToBasket(IGame game);
        public void DeleteGameFromBasket(IGame game);
        public HashSet<IGame> WantedGames { get; }
        public void AddGameToWanted(IGame game);
        public void DeleteGameFromwanted(IGame game);
        public HashSet<IUserGames> ListOfGames { get; }
        public void AddGameToList(IGame game);
        public int Money { get; set; }
    }
}