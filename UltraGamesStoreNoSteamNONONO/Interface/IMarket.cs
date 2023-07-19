using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltraGamesStoreNoSteamNONONO
{
    internal interface IMarket
    {
        public IUser CurrentUser { get;  }
        public SQLBase SQLBase { get; set; }
        public void SignIn(string name, string pasword);
        public void SignOut();
        public void SignUp(string username, int age, string password, int powerOfPc, SQLBase sqlBase);

        public List<IGame> ListOfGames {  get; }
        public void NextTopTenGames();
        public List<IGame> GetBasketList();
        public List<IGame> GetWantedList();
        public List<IUserGames> GetUsersListOfGames();
        public void AddToBasketList(IGame game);
        public void RemoveFromBasketList(IGame game);
        public void AddToWantedList(IGame game);
        public void RemoveFromWantedList(IGame game);
        public void BuyGames();
        public void CreateGame(string nameOfGame, int money, int rate, int recAge, DateOnly date, int powerOfPc, string author, SQLBase sqlBase);
        public event Action ChangedUI;

     

    }
}
