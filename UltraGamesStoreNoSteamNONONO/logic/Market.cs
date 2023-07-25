using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace UltraGamesStoreNoSteamNONONO
{// асинки добавить, изменение инфомрации об акке и играх, передлать в бул
    public class Market : IMarket
    {
        SQLBase sqlBase;
        public SQLBase SQLBase { get { return sqlBase; } set { sqlBase = value; } }


        public event Action ChangedUI;
        private User currentUser;

        public Market(string connection)
        {
            this.sqlBase = new SQLBase(connection);
        }

        public User CurrentUser => currentUser;


        public void AddToBasketList(Game game)
        {
                                                                                                                                                                                       
            CurrentUser.Basket.AddGame(game);
            ChangedUI?.Invoke();
        }

        public void AddToWantedList(Game game)
        {
            CurrentUser.WantedGames.AddGame(game);
            ChangedUI?.Invoke();
        }

        
        public void BuyGames()
        {

            decimal sum = 0;
            int recAge = 0;
            foreach (var item in CurrentUser.Basket.Games)
            {
                sum += item.Money;
                recAge = Math.Max(recAge, item.RecAge);
            }

            if (CurrentUser.Money >= sum && CurrentUser.Age>= recAge)
            {
                CurrentUser.Money -= sum;
                foreach (var item in CurrentUser.Basket.Games)
                {
                    //ИСКЛЮЧЕНИЯ
                    CurrentUser.AvailableGames.AddGame(item);
                    currentUser.Basket.DeleteGame(item);
                    currentUser.WantedGames.DeleteGame(item);
                }
            }

            ChangedUI?.Invoke();
        }

        public void CreateGame(string nameOfGame, int money, int rate, int recAge, DateOnly date, int powerOfPc, string author, SQLBase sqlBase)
        {
            Game.newGame(nameOfGame, money, rate, recAge, date, powerOfPc, author, sqlBase);
            ChangedUI?.Invoke();
        }

        public HashSet<Game> GetBasketList()
        {
            return CurrentUser.Basket.Games;
        }
      
        public List<Game> TopTenGamesFrom(int cursor = 0)
        {
        return Game.GetTenGames(cursor, sqlBase);
        }
   
        public HashSet<Game> GetUsersListOfGames()
        {
            return CurrentUser.AvailableGames.Games;
        }

        public HashSet<Game> GetWantedList()
        {
            return CurrentUser.WantedGames.Games;
        }

        public void RemoveFromBasketList(Game game)
        {
            CurrentUser.Basket.DeleteGame(game);

            ChangedUI?.Invoke();
        }

        public void RemoveFromWantedList(Game game)
        {
            CurrentUser.WantedGames.DeleteGame(game);
            ChangedUI?.Invoke();

        }

        public void SignIn(string name, string pasword)
        {
            currentUser = User.SingIn(name, pasword, sqlBase);

            ChangedUI?.Invoke();

        }

        public void SignOut()
        {
            currentUser = null;

            ChangedUI?.Invoke();
        }

        public void SignUp(string username, int age, string password, int powerOfPc)
        {
            //ИСКЛЮЧЕНИЯ
           currentUser= User.NewUser(username, age, password, powerOfPc, sqlBase);
            
        }

     
    }
}
