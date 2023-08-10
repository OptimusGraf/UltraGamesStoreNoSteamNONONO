using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;


namespace UltraGamesStoreNoSteamNONONO
{
    public class UserGame : Game
    {

        public UserGame(int userId, DataRow gameRow, SQLBase sqlBase) : base(gameRow, sqlBase)
        {
            id=userId;
            Tuple<string, object>[] parametrs = { new Tuple<string, object>("userId", userId), new Tuple<string, object>("gameId", GameId) };
            DataSet userGameData = sqlBase.DataQuery
                (
                    "SELECT id,CountOfHour, Progress,isLoaded FROM UsersListOfGames WHERE UserId =@userId AND GamesId = @gameId;",
                        parametrs
                 );

            if (userGameData.Tables[0].Rows.Count > 0)
            {
                DataRow usergamerow = userGameData.Tables[0].Rows[0];

                id = (int)usergamerow["id"];
                countOfHour = (int)usergamerow["CountOfHour"];
                progress = (int)usergamerow["Progress"];
                isLoaded = (bool)usergamerow["isLoaded"];

            }
            else
            {
              //  sqlBase.NoResultQuery("INSERT UsersListOfGames VALUES(@userId, @gameId,0,0,0)", parametrs);
            }
        }
   
        public static UserGame NewUserGame(Game game, int userId, SQLBase sqlBase)
        {

            Tuple<string, object>[] parametrs = { new Tuple<string, object>("userId", userId), new Tuple<string, object>("gameId", game.GameId) };

            string query = "INSERT UsersListOfGames (UserId,GamesId) VALUES (@userId, @gameId)";
            sqlBase.NoResultQuery(query, parametrs);

             query = $"SELECT * FROM Games WHERE Games.id = @gameId AND Games.id IN (SELECT GamesId FROM UsersListOfGames WHERE UserId = @userId )";
            DataTable table = sqlBase.DataQuery(query, parametrs).Tables[0];

            return new UserGame(userId, table.Rows[0], sqlBase);

            
        }

        private readonly int id;
        public int Id { get => id; }

        bool isLoaded;
        public bool IsLoaded { get => isLoaded; set { isLoaded = value; UpdateInfoAboutGames(); } }

        int progress;
        public int Progress
        {
            get => progress;

            set
            {
                //Тут проблема с тем что прогресс от 0 до 100, исключение надо выкидывать
                if (value <= 100 && value >= 0)
                {
                    progress = value;
                    UpdateInfoAboutUsersGames();
                }
            }
        }
        int countOfHour;
        public int CountOfHour { get => countOfHour; set { countOfHour = value; UpdateInfoAboutUsersGames(); } }

        protected void UpdateInfoAboutUsersGames()
        {
            string query = "UPDATE UsersListOfGames SET CountOfHour=@hours,Progress=@progress,isLoaded=@value   WHERE @id=id";
            Tuple<string, object>[] parametrs =
               { new Tuple<string, object>("hours", countOfHour),
                new Tuple<string, object>("progress", progress),
                new Tuple<string, object>("isLoaded", isLoaded),
                new Tuple<string, object>("id", id) };
            sqlBase.NoResultQuery(query, parametrs);
            ChangedMaster();

        }
      

    }
}
