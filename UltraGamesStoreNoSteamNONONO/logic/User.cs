using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;
using System.Xml.Linq;

namespace UltraGamesStoreNoSteamNONONO
{
    internal class User : IUser
    {
        public User(DataRow row, SQLBase sqlBase):this(sqlBase, (int)row["id"], (string)row["username"], (int)row["age"], (int)row["PowerOfPC"], null, (int)row["moneyOfuser"] )
        {

            this.basket = LoadBasket();
            this.wantedGames = LoadWanted();
            this.listOfGames = LoadList();

            //ДОБАВИТЬ КАРТИНКИ;
        }

        private User(SQLBase sqlBase, int id, string userName, int age, int powerOfPC, Image image, int money)
        {
            this.sqlBase = sqlBase;
            this.id = id;
            this.userName = userName;
            this.age = age;
            this.powerOfPC = powerOfPC;
            this.image = image;
            this.money = money;
            this.basket = basket;
            this.wantedGames = wantedGames;
            this.listOfGames = listOfGames;
        }

        static public User NewUser(string username, int age, string password, int powerOfPc, SQLBase sqlBase)
        {
            //картинку потом
            //сюда тоже исключения
            Tuple<string, object>[] parametrs = { new Tuple<string, object> ("name",username),
                new Tuple<string, object>("password", password),
                new Tuple<string, object>("age",age),
                new Tuple<string,object> ("powerOfPC", powerOfPc)};

            sqlBase.NoResultQuery("INSERT Users VALUES(@name, @password,0,@age,@powerOfPC, null)", parametrs);

            int id = (int)(sqlBase.DataQuery("SELECT id FROM Users WHERE username = @name", parametrs).Tables[0].Rows[0]["id"]);
            User user = new User(sqlBase, id, username, age, powerOfPc, null, 0);
            user.basket = new HashSet<IGame>();
            user.wantedGames = new HashSet<IGame>();
            user.listOfGames = new HashSet<IUserGames>();

            return user;

        }
        public HashSet<IGame> LoadBasket()
        {
            Tuple<string, object>[] parametrs = new Tuple<string, object>[] { new Tuple<string, object>("id", id) };
            DataTable table = sqlBase.DataQuery("SELECT * FROM Games WHERE Games.id IN (SELECT GamersId FROM UsersListBasket WHERE Users.id = @id )", parametrs).Tables[0];
            HashSet<IGame> basket = new HashSet<IGame>();
            foreach (DataRow item in table.Rows)
            {
                Game game = new Game(item, sqlBase);
                basket.Add(game);
            }
            return basket;
        }
        public HashSet<IGame> LoadWanted()
        {
            Tuple<string, object>[] parametrs = new Tuple<string, object>[] { new Tuple<string, object>("id", id) };
            DataTable table = sqlBase.DataQuery("SELECT * FROM Games WHERE Games.id IN (SELECT GamersId FROM UsersListOfWanted WHERE Users.id = @id )", parametrs).Tables[0];
            HashSet<IGame> wanted = new HashSet<IGame>();
            foreach (DataRow item in table.Rows)
            {
                Game game = new Game(item, sqlBase);
                wanted.Add(game);
            }
            return basket;
        }

        public HashSet<IUserGames> LoadList()
        {
            Tuple<string, object>[] parametrs = new Tuple<string, object>[] { new Tuple<string, object>("id", id) };
            DataTable table = sqlBase.DataQuery("SELECT * FROM Games WHERE Games.id IN (SELECT GamersId FROM UsersListOfWanted WHERE Users.id = @id )", parametrs).Tables[0];
            HashSet<IUserGames> list = new HashSet<IUserGames>();
            foreach (DataRow item in table.Rows)
            {
                Game game = new Game(item, sqlBase);
                UserGame ugame =new UserGame(id, game);
                list.Add(ugame);
            }
            return list;
        }
        public HashSet<IGame> GetUsersCreatedGames()
        {
            Tuple<string, object>[] parametrs = new Tuple<string, object>[] { new Tuple<string, object>("name", userName) };
            DataTable table = sqlBase.DataQuery("SELECT * FROM Games WHERE Games.author = @userName )", parametrs).Tables[0];
            HashSet<IGame> list = new HashSet<IGame>();
            foreach (DataRow item in table.Rows)
            {
                Game game = new Game(item, sqlBase);
                list.Add(game);
            }
            return list;
        }

        SQLBase sqlBase;
        public SQLBase SQLBase { get => SQLBase; set => SQLBase = value; }
        readonly int id;
        string userName;
        public string UserName => userName;
        int age;
        public int Age => age;

        int powerOfPC;
        public int PowerOfPC
        {
            get { return powerOfPC; }
            set
            {
                Tuple<string, object>[] parameters
                    = { new Tuple<string, object>("newPower", value), new Tuple<string, object>("id", id) };
                sqlBase.NoResultQuery("UPDATE Users SET PowerOfPC = @newPower WHERE id=@id", parameters);
                powerOfPC = value;
            }
        }
        Image image;
        public Image Image
        {
            get { return image; }
            set
            {
                byte[] newImage = (value as Image).FromImageToByteArray();
                Tuple<string, object>[] parameters
                    = { new Tuple<string, object>("newPower", newImage), new Tuple<string, object>("id", id) };
                sqlBase.NoResultQuery("UPDATE Users SET image = @newImage WHERE id=@id", parameters);
                image = value;
            }
        }
        private decimal money;

        public decimal Money
        {
            get { return money; }

            set
            {
                Tuple<string, object>[] parameters
                  = { new Tuple<string, object>("money", value), new Tuple<string, object>("id", id) };
                sqlBase.NoResultQuery("UPDATE Users SET moneyOfuser = @money WHERE id=@id", parameters);
                money = value;
            }
        }


        HashSet<IGame> basket = null;
        public HashSet<IGame> Basket => basket;
        HashSet<IGame> wantedGames = null;
        public HashSet<IGame> WantedGames => wantedGames;
        HashSet<IUserGames> listOfGames = null;
        public HashSet<IUserGames> ListOfGames => listOfGames;

        public void AddGameToBasket(IGame game)
        {
            if (!basket.Contains(game))
            {
                basket.Add(game);
                Tuple<string, object>[] parametrs = { new Tuple<string, object>("userid", id), new Tuple<string, object>("gameid", game.Id) };
                sqlBase.NoResultQuery("INSERT UsersListBasket VALUES(@userid, @gameid)", parametrs);
            }

        }

        public void DeleteGameFromBasket(IGame game)
        {
            if (basket.Contains(game))
            {
                basket.Remove(game);
                Tuple<string, object>[] parametrs = { new Tuple<string, object>("userid", id), new Tuple<string, object>("gameid", game.Id) };
                sqlBase.NoResultQuery("DELETE FROM UsersListBasket WHERE GamesID = @gameid AND  UserID = @userid", parametrs);
            }



        }

        public void AddGameToWanted(IGame game)
        {

            if (!wantedGames.Contains(game))
            {
                wantedGames.Add(game);
                Tuple<string, object>[] parametrs = { new Tuple<string, object>("userid", id), new Tuple<string, object>("gameid", game.Id) };
                sqlBase.NoResultQuery("INSERT UsersListOfWanted VALUES(@userid, @gameid)", parametrs);
            }
        }

        public void DeleteGameFromwanted(IGame game)
        {
            wantedGames.Remove(game);

            if (wantedGames.Contains(game))
            {
                wantedGames.Remove(game);
                Tuple<string, object>[] parametrs = { new Tuple<string, object>("userid", id), new Tuple<string, object>("gameid", game.Id) };
                sqlBase.NoResultQuery("DELETE FROM UsersListOfWanted WHERE GamesID = @gameid AND  UserID = @userid", parametrs);
            }

        }

        public void AddGameToList(IGame game)
        {
            UserGame userGame = new UserGame(id, (Game)game);
            if (!listOfGames.Contains(userGame))
            {

                ListOfGames.Add(userGame);
            }

        }
        public void UpdateInfo()
        {
            this.basket = LoadBasket();
            this.wantedGames = LoadWanted();
            this.listOfGames = LoadList();
        }
    }
}