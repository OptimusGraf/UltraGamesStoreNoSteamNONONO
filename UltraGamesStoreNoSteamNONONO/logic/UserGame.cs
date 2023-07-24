using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace UltraGamesStoreNoSteamNONONO
{
    public class UserGame : Game
    {

        public UserGame(int userId, DataRow row, SQLBase sqlBase) : base(row, sqlBase)
        {

            // тут проблема а если есть???7
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
                IsLoaded = (bool)usergamerow["isLoaded"];

            }
            else
            {
                sqlBase.NoResultQuery("INSERT UsersListOfGames VALUES(@userId, @gamesId,0,0,0)", parametrs);
            }
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
            SQLBase.NoResultQuery(query, parametrs);
            ChangedMaster();

        }
        public override bool Equals(object? obj) => ((obj is UserGame) && ((UserGame)obj).id == this.id);
        public override int GetHashCode() => this.id.GetHashCode();

    }
}
