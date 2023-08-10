
using System.Data;

namespace UltraGamesStoreNoSteamNONONO
{
    public class ListOfGames
    {
        SQLBase sqlBase;
        private HashSet<Game> games;
        readonly int userId;
        string nameOfTable;
        public ListOfGames(SQLBase sqlBase, int userId, string nameOfTable)
        {
            this.sqlBase = sqlBase;
            this.userId = userId;
            this.nameOfTable = nameOfTable;
            LoadData();
        }

        public HashSet<Game> Games => games;

        public void LoadData()
        {
            Tuple<string, object>[] parametrs = new Tuple<string, object>[] { new Tuple<string, object>("id", userId) };
            string query = $"SELECT * FROM Games WHERE Games.id IN (SELECT GamesId FROM {nameOfTable} WHERE UserId = @id )";

            DataTable table = sqlBase.DataQuery(query, parametrs).Tables[0];

            HashSet<Game> set = new HashSet<Game>();
            foreach (DataRow item in table.Rows)
            {
                Game game;
                if (nameOfTable == "UsersListOfGames")
                {
                    game = new UserGame(userId, item, sqlBase);
                }
                else
                    game = new Game(item, sqlBase);
                set.Add(game);
            }
            games = set;
        }
        public void AddGame(UserGame game)
        {
            if (!games.Contains(game))
            {
                games.Add(game);
            }
        }
        public void AddGame(Game game)
        {
            if (!games.Contains(game))
            {
                games.Add(game);
                Tuple<string, object>[] parametrs = { new Tuple<string, object>("userid", userId), new Tuple<string, object>("gameid", game.GameId) };
                string query = $"INSERT {nameOfTable} (UserId,GamesId) VALUES (@userid, @gameid)";
                sqlBase.NoResultQuery(query, parametrs);

            }
        }
        public void DeleteGame(Game game)
        {
            if (games.Contains(game))
            {
                games.Remove(game);
                Tuple<string, object>[] parametrs = { new Tuple<string, object>("userid", userId), new Tuple<string, object>("gameid", game.GameId) };
                string query = $"DELETE FROM {nameOfTable} WHERE GamesId = @gameid AND  UserId = @userid";
                sqlBase.NoResultQuery(query, parametrs);
            }
        }

        public bool ContainGame(Game game)
        {
            return games.Contains(game);
        }

    }

}
