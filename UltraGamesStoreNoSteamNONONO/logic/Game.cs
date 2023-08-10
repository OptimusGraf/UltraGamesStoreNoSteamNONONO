using System.Configuration;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace UltraGamesStoreNoSteamNONONO
{
    public class Game
    {
        // sqlBase сделать статичным
        // подумать об инкапсюляции 

        public Game(DataRow row, SQLBase sqlBase) :
            this((string)row["nameOfGame"], (int)row["id"], (string)row["author"], DateOnly.FromDateTime((DateTime)row["release"]), (int)row["powerOfPC"], (int)row["rate"], (int)row["recAge"], (row["icon"] as byte[]), (decimal)row["price"], (row["imageOfGame"] as byte[]), sqlBase)
        {
            // ДАТЫ И КАРТИНКИ РЕАЛЬЗИВАТЬ
        }

        static public void newGame(string nameOfGame, decimal money, int rate, int recAge, DateOnly date, int powerOfPc, string author, byte[] image, byte[] icon, SQLBase sqlBase)
        {
            //картинки потом
            //сюда тоже исключения
            //дата
            // а если есть игра с таким названием
            Tuple<string, object>[] parametrs = {
                new Tuple<string, object> ("name",nameOfGame),
                new Tuple<string, object>("price", money),
                new Tuple<string, object>("rate",rate),
                new Tuple<string, object>("recAge",recAge),
                new Tuple<string, object>("date",date.ToString()),
                new Tuple<string, object>("author",author),
                new Tuple<string, object>("image",image),
                new Tuple<string, object>("icon",icon),
                new Tuple<string,object> ("powerOfPC", powerOfPc)};

            string query = "INSERT Games VALUES(@name, @price,@rate,@recAge, @date,@author,@powerOfPC, @icon,@image)";
            sqlBase.NoResultQuery(query, parametrs);

            //query = "SELECT id FROM Games WHERE nameOfGame = @name";
            //int id = (int)(sqlBase.DataQuery(query, parametrs).Tables[0].Rows[0]["id"]);

            //Game game = new Game(nameOfGame, id, author, date, powerOfPc, rate, recAge, icon, money, image, sqlBase);
            //return game;
        }
        protected Game(string name, int id, string author, DateOnly date, int powerOfPc, int rate, int recAge, byte[] icon, decimal money, byte[] imageOfGame, SQLBase sqlBase)
        {
            this.name = name;
            this.gameId = id;
            this.author = author;
            this.date = date;
            this.powerOfPc = powerOfPc;
            this.rate = rate;
            this.recAge = recAge;
            this.icon = icon;
            this.money = money;
            this.imageOfGame = imageOfGame;
            this.sqlBase = sqlBase;
        }

        readonly int gameId;
        public int GameId => gameId;

        string name;
        public string Name { get => name; set { name = value; UpdateInfoAboutGames(); MakeNotification(modificatons.others); } }

        public void ChangeInfoAboutGame(byte[] image, byte[] icon, decimal price, int age, int power)
        {
            MakeNotification(modificatons.others);

            imageOfGame = image;
            this.icon = icon;
            money = price;
            recAge = age;
            powerOfPc = power;
            UpdateInfoAboutGames();
        }

        string author;
        public string Author { get => author; }

        DateOnly date;
        public DateOnly Release { get => date; }

        int powerOfPc;
        public int PowerOfPc { get => powerOfPc; }

        int rate;
        public int Rate { get => rate; set { rate = value; UpdateInfoAboutGames(); MakeNotification(modificatons.rate); } }

        private int recAge;
        public int RecAge { get => recAge; }

        byte[] icon;
        public byte[] Icon { get => icon; }

        private decimal money;
        public decimal Money { get => money; }

        byte[] imageOfGame;
        public byte[] ImageOfGame { get => imageOfGame; }

        SQLBase sqlBase;
        public SQLBase SQLBase { get => SQLBase; set => SQLBase = value; }

        public override bool Equals(object? obj) => ((obj is Game) && ((Game)obj).gameId == this.gameId);
        public override int GetHashCode() => this.gameId.GetHashCode();

        static public List<Game> GetTenGames(int cursor, SQLBase sqlBase)
        {
            string query = "SELECT * FROM Games ORDER BY Id OFFSET @cursor ROWS FETCH NEXT 10 ROWS ONLY";
            Tuple<string, object>[] parameters = { new Tuple<string, object>("cursor", cursor) };
            DataTable table = sqlBase.DataQuery(query, parameters).Tables[0];

            List<Game> list = new List<Game>();
            foreach (DataRow row in table.Rows)
            {
                list.Add(new Game(row, sqlBase));
            }
            return list;

        }
        public List<Review> GetReviews()
        {
            string query = "SELECT * FROM Reviews WHERE GamesId = @gameId";
            Tuple<string, object>[] parameters = { new Tuple<string, object>("gameId", GameId) };

            DataTable table = sqlBase.DataQuery(query, parameters).Tables[0];
            List<Review> list = new List<Review>();
            foreach (DataRow row in table.Rows)
            {
                list.Add(new Review(row, sqlBase));
            }
            return list;
        }



        public void ChangeRate()
        {
            int rate = 0;

            List<Review> Reviews = this.GetReviews();
            for (int i = 0; i < Reviews.Count; i++)
            {
                rate += Reviews[i].grade;
            }
            rate /= Reviews.Count;

            this.Rate = rate;
        }

        static public event Action Changed;

        [Flags]
        private enum modificatons
        {
            rate = 1, others = 2
        }
        private void MakeNotification(modificatons mod)
        {
            StringBuilder notification = new StringBuilder($"игра: {name} содержит следующие изменения:  ");
            if ((mod & modificatons.rate) == modificatons.rate)
            {
                notification.Append($"Поменялся рейтинг. Новое значение{rate}");
            }
            if ((mod & modificatons.others) == modificatons.others)
            {
                notification.Append($"Поменялась информация об игре, посмотрите изменения в магазине");
            }

            string query
                = "SELECT username FROM Users WHERE Users.id in (SELECT UserId FROM UsersListOfWanted WHERE GamesId = @gameid) OR  Users.id in (SELECT UserId FROM UsersListBasket WHERE GamesId =  @gameid )";
            Tuple<string, object>[] parameters = { new Tuple<string, object>("gameid", GameId) };
            DataTable table = sqlBase.DataQuery(query, parameters).Tables[0];
            foreach (DataRow row in table.Rows)
            {
                query = "INSERT Notifications VALUES (@username, @text)";
                parameters = new Tuple<string, object>[]
                  {
                  new Tuple<string, object>("username", row["username"]),
                  new Tuple<string, object>("text", notification.ToString())
                  };
                sqlBase.NoResultQuery(query, parameters);
            }


        }
        protected virtual void UpdateInfoAboutGames()
        {

            string query = "UPDATE Games SET nameOfGame=@name, price=@price, recAge=@recAge, powerOfPC= @powerOfPc, icon=@newicon, imageOfGame=@newimageOfGame  WHERE id=@id";
            Tuple<string, object>[] parameters = {
                new Tuple<string, object> ("name",name),
                new Tuple<string, object>("price", money),
                new Tuple<string, object>("recAge",recAge),
                new Tuple<string,object> ("powerOfPC", powerOfPc),
                new Tuple<string, object>("newimageOfGame", imageOfGame),
                new Tuple<string, object>("newicon", icon),
                new Tuple<string, object>("id", GameId)
            };

            sqlBase.NoResultQuery(query, parameters);
            ChangedMaster();
        }
        protected void ChangedMaster()
        {
            Changed?.Invoke();

        }

    }
}
