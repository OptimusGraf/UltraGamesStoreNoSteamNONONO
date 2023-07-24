 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltraGamesStoreNoSteamNONONO
{
    public interface IMarket
    {
        public User CurrentUser { get;  }
        public SQLBase SQLBase { get; set; }
        public void SignIn(string name, string pasword);
        public void SignOut();
        public void SignUp(string username, int age, string password, int powerOfPc);

        public List<Game> TopTenGamesFrom (int cursor);
        public HashSet<Game> GetBasketList();
        public HashSet<Game> GetWantedList();
        public HashSet<Game> GetUsersListOfGames();
        public void AddToBasketList(Game game);
        public void RemoveFromBasketList(Game game);
        public void AddToWantedList(Game game);
        public void RemoveFromWantedList(Game game);
        public void BuyGames();
        public void CreateGame(string nameOfGame, int money, int rate, int recAge, DateOnly date, int powerOfPc, string author, SQLBase sqlBase);
        public event Action ChangedUI;

     

    }
}
