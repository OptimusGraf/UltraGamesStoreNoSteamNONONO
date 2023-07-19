using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;


namespace UltraGamesStoreNoSteamNONONO
{
    internal class Game : IGame
    {
        //реализовать метод newgame
        public Game(DataRow row, SQLBase sqlBase) : this((string)row["nameOfGame"], (int)row["id"], (string)row["author"], new DateOnly(2003,7,12), (int)row["powerOfPC"], (int)row["rate"], (int)row["recAge"], null, (decimal)row["price"], null, sqlBase)
        {
            // ДАТЫ И КАРТИНКИ РЕАЛЬЗИВАТЬ
        }

       static public Game newGame(string nameOfGame, int money, int rate, int recAge,DateOnly date, int powerOfPc, string author,SQLBase sqlBase)
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

            sqlBase.NoResultQuery("INSERT Games VALUES(@name, @price,@rate,@recAge,@date,@author,@powerOfPC, null,null)", parametrs);
            int id = (int)(sqlBase.DataQuery("SELECT id FROM Games WHERE nameOfGame = @name", parametrs).Tables[0].Rows[0]["id"]);
            Game game = new Game(nameOfGame, id, author, date, powerOfPc, rate, recAge, null, money, null, sqlBase);
       

            return game;
        }
        private Game(string name, int id, string author, DateOnly date, int powerOfPc, int rate, int recAge,Image icon, decimal money, Image imageOfGame, SQLBase sqlBase)
        {
            this.name = name;
            this.id = id;
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

        public string name;
        readonly int id;
        public int Id => id;
        public string Name
        {
            get { return name; }
            set
            {
                string query = "UPDATE Games SET name=@newname WHERE id=@id";
                Tuple<string, object>[] parameters
                      = { new Tuple<string, object>("newname", value), new Tuple<string, object>("id", id) };
                sqlBase.NoResultQuery(query, parameters);
                name = value;
            }
        }
        string author;
        public string Author { get => author; }
        DateOnly date;
        public DateOnly Release { get => date; }
        int powerOfPc;
        public int PowerOfPc { get => powerOfPc; }
        int rate;
        public int Rate
        {
            get { return rate; }
            set
            {
                string query = "UPDATE Games SET rate=@newrate WHERE id=@id";
                Tuple<string, object>[] parameters
                      = { new Tuple<string, object>("newrate", value), new Tuple<string, object>("id", id) };
                sqlBase.NoResultQuery(query, parameters);
                rate = value;
            }
        }
        private int recAge;

        public int RecAge
        {
            get { return recAge; }
            set
            {
                string query = "UPDATE Games SET recAge=@newrec WHERE id=@id";
                Tuple<string, object>[] parameters
                      = { new Tuple<string, object>("newrec", value), new Tuple<string, object>("id", id) };
                sqlBase.NoResultQuery(query, parameters);
                recAge = value;
            }
        }

        Image icon;
        public Image Icon
        {
            get { return icon; }
            set
            {
                byte[] newIcon = (value as Image).FromImageToByteArray();
                string query = "UPDATE Games SET icon=@newicone WHERE  WHERE id=@id";
                Tuple<string, object>[] parameters
                      = { new Tuple<string, object>("newicone", newIcon), new Tuple<string, object>("id", id) };
                sqlBase.NoResultQuery(query, parameters);
                icon = value;
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
                sqlBase.NoResultQuery("UPDATE Games SET price = @money WHERE id=@id", parameters);
                money = value;
            }
        }

        Image imageOfGame;
        public Image ImageOfGame
        {
            get { return imageOfGame; }
            set
            {
                byte[] newimageOfGame = (value as Image).FromImageToByteArray();
                string query = "UPDATE Games SET imageOfGame=@newimageOfGame WHERE WHERE id=@id";
                Tuple<string, object>[] parameters
                      = { new Tuple<string, object>("newimageOfGame", newimageOfGame), new Tuple<string, object>("id", id) };
                sqlBase.NoResultQuery(query, parameters);
                imageOfGame = value;
            }

        }
        SQLBase sqlBase;
        public SQLBase SQLBase { get => SQLBase; set => SQLBase = value; }


        public override bool Equals(object? obj)
        {

            return ((obj is Game) && ((Game)obj).id == this.id);
        }
        public override int GetHashCode()
        {
            return this.id.GetHashCode();
        }

        static public List<IGame> GetTenGames(int cursor,SQLBase sqlBase)
        {
            string query = "SELECT * FROM Games ORDER BY ID OFFSET @cursor ROWS NEXT 10 ROWS ONLY";
            Tuple<string, object>[] parameters = { new Tuple<string, object>("cursor", cursor) };
            DataTable table = sqlBase.DataQuery(query, parameters).Tables[0];

            List<IGame> list = new List<IGame>();
            foreach (DataRow row in table.Rows) 
            {
                list.Add(new Game(row, sqlBase));
            }
            return list;

        }

     
  
    }
}
