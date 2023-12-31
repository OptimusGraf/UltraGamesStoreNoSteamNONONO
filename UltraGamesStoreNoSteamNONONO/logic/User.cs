﻿
using System.Data;


namespace UltraGamesStoreNoSteamNONONO
{
    public class User
    {
        public User(DataRow row, SQLBase sqlBase) :
            this(sqlBase, (int)row["id"], (string)row["username"], (int)row["age"], (int)row["PowerOfPC"], row["image"] as byte[], (decimal)row["moneyOfuser"])
        {
            availableGames = new ListOfGames(sqlBase, id, "UsersListOfGames");
            basket = new ListOfGames(sqlBase, id, "UsersListBasket");
            wantedGames = new ListOfGames(sqlBase, id, "UsersListOfWanted");
            createdGames = new List<Game>();
            UpdateInfoAboutGames();
        }

        private User(SQLBase sqlBase, int id, string userName, int age, int powerOfPc, byte[] image, decimal money)
        {
            this.sqlBase = sqlBase;
            this.id = id;
            this.userName = userName;
            this.age = age;
            this.powerOfPc = powerOfPc;
            this.money = money;
            this.image = image;

        }
        string userName;
        public string UserName => userName;
        private decimal money;
        int age;
        public int Age { get => age; }
        int powerOfPc;
        public int PowerOfPc { get => powerOfPc; }
        byte[] image;
        public byte[] Image { get => image; }
        public decimal Money { get => money; set { money = value; UpdateInfoAboutUser(); } }
        public UserInfo UserInfo
        {
            get => new UserInfo(UserName, age, powerOfPc, image);
            set
            {
                age = (value as UserInfo).Age;
                powerOfPc = (value as UserInfo).PowerOfPC;
                image = (value as UserInfo).Image;
                UpdateInfoAboutUser();
            }
        }
        static public User SingIn(string name, string pasword, SQLBase sqlBase)
        {
            string query = "SELECT * FROM Users WHERE username=@name and pasword= @pasword";

            Tuple<string, object>[] parametres = { new Tuple<string, object>("name", name), new Tuple<string, object>("pasword", pasword) };

            DataTable table = sqlBase.DataQuery(query, parametres).Tables[0];
            if (table.Rows.Count == 0)
            {
                throw new NotImplementedException();
            }

            return new User(table.Rows[0], sqlBase);
        }
        static public User NewUser(string username, int age, string password, int powerOfPc, SQLBase sqlBase)
        {
         
            Tuple<string, object>[] parametrs = { new Tuple<string, object> ("name",username),
                new Tuple<string, object>("password", password),
                new Tuple<string, object>("age",age),
                new Tuple<string,object> ("powerOfPC", powerOfPc)};

            string query = "INSERT Users VALUES(@name, @password,0,@age,@powerOfPC, null)";
            sqlBase.NoResultQuery(query, parametrs);

            query = "SELECT Id FROM Users WHERE username= @name";
            int id = (int)(sqlBase.DataQuery(query, parametrs).Tables[0].Rows[0]["id"]);
            User user = new User(sqlBase, id, username, age, powerOfPc, null, 0);
            return user;

        }

        SQLBase sqlBase;
        public SQLBase SQLBase { get => SQLBase; set => SQLBase = value; }
        public readonly int id;


        private ListOfGames basket;
        public ListOfGames Basket => basket;

        private ListOfGames wantedGames;
        public ListOfGames WantedGames => wantedGames;

        private ListOfGames availableGames;
        public ListOfGames AvailableGames => availableGames;

        private List<Game> createdGames;
        public List<Game> CreatedGames => createdGames;


        private void LoadDataCreatedGames()
        {
            Tuple<string, object>[] parametrs = new Tuple<string, object>[] { new Tuple<string, object>("name", userName) };
            string query = $"SELECT * FROM Games WHERE author =@name";

            DataTable table = sqlBase.DataQuery(query, parametrs).Tables[0];

            List<Game> list = new List<Game>();
            foreach (DataRow item in table.Rows)
            {
                Game game = new Game(item, sqlBase);
                list.Add(game);
            }
            createdGames = list;
        }

        private void UpdateInfoAboutUser()
        {

            Tuple<string, object>[] parameters
                = {
                new Tuple<string, object>("id", id),
                new Tuple<string, object>("newImage", image),
                new Tuple<string, object>("newPower", powerOfPc),
                new Tuple<string, object>("age", age),
                new Tuple<string, object>("money", money)
             };
            string query = "UPDATE Users SET image = @newImage,PowerOfPC=@newPower, moneyofuser = @money, age = @age  WHERE id=@id";
            sqlBase.NoResultQuery(query, parameters);
        }

        public List<string> LoadNoatification()
        {
            string query = "SELECT * FROM Notifications WHERE username = @name";
            Tuple<string, object>[] parameters = { new Tuple<string, object>("name", userName) };

            DataTable table = sqlBase.DataQuery(query, parameters).Tables[0];

            List<string> notification= new List<string>();
            foreach (DataRow row in table.Rows)
            {
                notification.Add((string)row["text"] );
            }

            return notification;
        }


        public void UpdateInfoAboutGames()
        {
            basket.LoadData();
            wantedGames.LoadData();
            availableGames.LoadData();
            LoadDataCreatedGames();
        }
        public void RemoveNotififcations()
        {
            string query = "DELETE Notifications WHERE UserName=@name";
            Tuple<string, object>[] parameters = { new Tuple<string, object>("name", userName) };

            sqlBase.NoResultQuery(query, parameters);
        }
    }
}