using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace UltraGamesStoreNoSteamNONONO
{
    internal class UserGame : IUserGames
    {
        public UserGame(int userId, Game game)
        {
            Game = game;

            Tuple<string, object>[] parametrs = { new Tuple<string, object>("userId", userId), new Tuple<string, object>("gameId", game.Id) };
            DataSet userGameData = game.SQLBase.DataQuery
                (
                    "SELECT id,CountOfHour, Progress,isLoaded FROM UsersListOfGames WHERE UserId =@userId AND GamesId = @gameId;",
                        parametrs
                 );

            if (userGameData.Tables[0].Rows.Count>0)
            {
                DataRow row = userGameData.Tables[0].Rows[0];

                id = (int)row["id"];
                countOfHour = (int)row["CountOfHour"];
                progress = (int)row["Progress"];
                IsLoaded = (bool)row["isLoaded"];

            }
            else
            {
                game.SQLBase.NoResultQuery("INSERT UsersListOfGames VALUES(@userId, @gamesId,0,0,0)", parametrs);
            }
        }
  
        private readonly int id;
        public int Id { get => id; }
        public Game Game { get; set; }

        bool isLoaded;
        public bool IsLoaded
        {
            get { return isLoaded; }
            set
            {
                isLoaded = value;
                Tuple<string, object>[] parametrs = { new Tuple<string, object>("value", Convert.ToInt32(value)), new Tuple<string, object>("id", id) };
                Game.SQLBase.NoResultQuery("UPDATE UsersListOfGames SET isLoaded=@value WHERE @id=id ", parametrs);
            }
        }
        int progress;

        public int Progress
        {
            get
            {
                return progress;
            }
            set
            {
                //Тут проблема с тем что прогресс от 0 до 100, исключение надо выкидывать
                if (value <= 100 && value >= 0)
                {
                    Tuple<string, object>[] parametrs = { new Tuple<string, object>("value", value), new Tuple<string, object>("id", id) };
                    Game.SQLBase.NoResultQuery("UPDATE UsersListOfGames SET {Progress=@value WHERE @id=id ", parametrs);
                    progress = value;

                }

            }
        }
        int countOfHour;
        public int CountOfHour
        {
            get => countOfHour;
            set
            {
                Tuple<string, object>[] parametrs = { new Tuple<string, object>("value", value), new Tuple<string, object>("id", id) };
                Game.SQLBase.NoResultQuery("UPDATE UsersListOfGames SET {CountOfHour=@value WHERE @id=id ", parametrs);
                progress = value;
                countOfHour = value;
            }
        }


        public override bool Equals(object? obj)
        {

            return ((obj is UserGame) && ((UserGame)obj).id == this.id);
        }
        public override int GetHashCode()
        {
            return this.id.GetHashCode();
        }
    }
}
