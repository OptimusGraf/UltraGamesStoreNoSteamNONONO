using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;

namespace UltraGamesStoreNoSteamNONONO.logic
{// асинки добавить
    internal class Market : IMarket
    {
        SQLBase sqlBase;
        public SQLBase SQLBase { get { return sqlBase; } set { sqlBase = value; } }


        public event Action ChangedUI;
        private User currentUser;

        public IUser CurrentUser => currentUser;


        public void AddToBasketList(IGame game)
        {
            CurrentUser.AddGameToBasket(game);
            ChangedUI?.Invoke();
        }

        public void AddToWantedList(IGame game)
        {
            CurrentUser.AddGameToWanted(game);
            ChangedUI?.Invoke();
        }

        public void BuyGames()
        {

            decimal sum = 0;
            foreach (var item in CurrentUser.Basket)
            {
                sum += item.Money;
            }

            if (CurrentUser.Money >= sum)
            {
                CurrentUser.Money -= sum;
                foreach (var item in CurrentUser.Basket)
                {
                    CurrentUser.AddGameToList(item);
                    CurrentUser.DeleteGameFromwanted(item);
                    CurrentUser.DeleteGameFromBasket(item);
                }


            }


            ChangedUI?.Invoke();
        }

        public void CreateGame(string nameOfGame, int money, int rate, int recAge, DateOnly date, int powerOfPc, string author, SQLBase sqlBase)
        {
            Game.newGame(nameOfGame, money, rate, recAge, date, powerOfPc, author, sqlBase);



            ChangedUI?.Invoke();
        }

        public List<IGame> GetBasketList()
        {
            return CurrentUser.Basket.ToList();
        }

        List<IGame> listOfGames;
        public List<IGame> ListOfGames { get { return listOfGames; } }
        int cursor = 0;
        public void NextTopTenGames()
        {
            listOfGames = Game.GetTenGames(cursor, sqlBase);
            cursor += 10;
        }
        private void UpdateListOFGames()
        {
            listOfGames = Game.GetTenGames(cursor, sqlBase);
        }
        private void UpdateInfo()
        {
            UpdateListOFGames();
            CurrentUser.UpdateInfo();
        }

        public List<IUserGames> GetUsersListOfGames()
        {
            return CurrentUser.ListOfGames.ToList();
        }

        public List<IGame> GetWantedList()
        {
            return CurrentUser.WantedGames.ToList();
        }

        public void RemoveFromBasketList(IGame game)
        {
            CurrentUser.DeleteGameFromBasket(game);


            ChangedUI?.Invoke();
        }

        public void RemoveFromWantedList(IGame game)
        {
            CurrentUser.DeleteGameFromwanted(game);
            ChangedUI?.Invoke();

        }

        public void SignIn(string name, string pasword)
        {
            /// сюда исключение добавить
            string query = "SELECT * FROM Users WHERE username=@name and pasword= @pasword";

            Tuple<string, object>[] parametres = { new Tuple<string, object>("name", name), new Tuple<string, object>("pasword", pasword) };

            DataTable table = sqlBase.DataQuery(query, parametres).Tables[0];
            if (table.Rows.Count == 0)
            {
                throw new NotImplementedException();
            }

            currentUser = new User(table.Rows[0], sqlBase);


            ChangedUI?.Invoke();

        }

        public void SignOut()
        {
            currentUser = null;

            ChangedUI?.Invoke();
        }

        public void SignUp(string username, int age, string password, int powerOfPc, SQLBase sqlBase)
        {
            //ИСКЛЮЧЕНИЯ
            User.NewUser(username, age, password, powerOfPc, sqlBase);
            
        }

     
    }
}
