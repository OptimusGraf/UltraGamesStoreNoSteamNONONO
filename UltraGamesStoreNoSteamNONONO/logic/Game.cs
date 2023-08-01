﻿using System.Configuration;
using System.Data;

namespace UltraGamesStoreNoSteamNONONO
{
    public class Game 
    {

        public Game(DataRow row, SQLBase sqlBase) : 
            this((string)row["nameOfGame"], (int)row["id"], (string)row["author"], new DateOnly(2003,7,12), (int)row["powerOfPC"], (int)row["rate"], (int)row["recAge"], Helper.FromByteArrayToImage(row["icon"] as byte[]), (decimal)row["price"], Helper.FromByteArrayToImage(row["imageOfGame"] as byte[]), sqlBase)
        {
            // ДАТЫ И КАРТИНКИ РЕАЛЬЗИВАТЬ
        }

       static public Game newGame(string nameOfGame, decimal money, int rate, int recAge,DateOnly date, int powerOfPc, string author,SQLBase sqlBase)
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
                new Tuple<string, object>("date",date),
                new Tuple<string, object>("author",author),
                new Tuple<string,object> ("powerOfPC", powerOfPc)};

            string query = "INSERT Games VALUES(@name, @price,@rate,@recAge,@date,@author,@powerOfPC, null,null)";
            sqlBase.NoResultQuery(query, parametrs);

            query = "SELECT id FROM Games WHERE nameOfGame = @name";
            int id = (int)(sqlBase.DataQuery(query, parametrs).Tables[0].Rows[0]["id"]);

            Game game = new Game(nameOfGame, id, author, date, powerOfPc, rate, recAge, null, money, null, sqlBase);
            return game;
        }
        protected Game(string name, int id, string author, DateOnly date, int powerOfPc, int rate, int recAge,Image icon, decimal money, Image imageOfGame, SQLBase sqlBase)
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
        public string Name { get => name; set { name = value; UpdateInfoAboutGames(); } }

        string author;
        public string Author { get => author; }

        DateOnly date;
        public DateOnly Release { get => date; }

        int powerOfPc;
        public int PowerOfPc { get => powerOfPc; set { powerOfPc = value; UpdateInfoAboutGames(); } }

        int rate;
        public int Rate { get => rate; set { rate = value; UpdateInfoAboutGames(); } }

        private int recAge;
        public int RecAge { get => recAge; set { recAge = value; UpdateInfoAboutGames(); } }

        Image icon;
        public Image Icon { get => icon; set { icon = value; UpdateInfoAboutGames(); } }

        private decimal money;
        public decimal Money { get => money; set { money = value; UpdateInfoAboutGames(); } }

        Image imageOfGame;
        public Image ImageOfGame { get => imageOfGame; set { imageOfGame = value; UpdateInfoAboutGames(); } }

        SQLBase sqlBase;
        public SQLBase SQLBase { get => SQLBase; set => SQLBase = value; }

        public override bool Equals(object? obj) => ((obj is Game) && ((Game)obj).gameId == this.gameId);
        public override int GetHashCode() =>  this.gameId.GetHashCode();

        static public List<Game> GetTenGames(int cursor,SQLBase sqlBase)
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
        static public event Action Changed;

        protected virtual void UpdateInfoAboutGames()
        {
            byte[] newimageOfGame = imageOfGame.FromImageToByteArray();
            byte[] newIcon = icon.FromImageToByteArray();
            string query = "UPDATE Games SET nameOfGame=@name, price=@price, recAge=@recAge, powerOfPC= @powerOfPc, icon=@newicon, imageOfGame=@newimageOfGame  WHERE id=@id";
            Tuple<string, object>[] parameters = {
                new Tuple<string, object> ("name",name),
                new Tuple<string, object>("price", money),
                new Tuple<string, object>("recAge",recAge),
                new Tuple<string,object> ("powerOfPC", powerOfPc),
                new Tuple<string, object>("newimageOfGame", newimageOfGame),
                  new Tuple<string, object>("newicon", newIcon),
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
