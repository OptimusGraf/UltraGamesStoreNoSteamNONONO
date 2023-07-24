using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Data;


namespace UltraGamesStoreNoSteamNONONO
{
    public class ListOfGames
    {
        SQLBase sqlBase;
        private HashSet<IGame> games;
        int userId;
        string nameOfTable;
        public ListOfGames(SQLBase sqlBase, int userId, string nameOfTable)
        {
            this.sqlBase = sqlBase;
            this.userId = userId;
            this.nameOfTable = nameOfTable;
            LoadData();
        }

        public HashSet<IGame> Games => games;

        public void LoadData()
        {
            Tuple<string, object>[] parametrs = new Tuple<string, object>[] { new Tuple<string, object>("id", userId) };
            string query = $"SELECT * FROM Games WHERE Games.id IN (SELECT GamesId FROM {nameOfTable} WHERE UserId = @id )";

            DataTable table = sqlBase.DataQuery(query, parametrs).Tables[0];

            HashSet<IGame> set = new HashSet<IGame>();
            foreach (DataRow item in table.Rows)
            {
                Game game = new Game(item, sqlBase);
                set.Add(game);
            }
            games = set;
        }
        public void AddGame(IGame game)
        {
            if (!games.Contains(game))
            {
                // ТУТ НАДО ОБРАБОТКУ ИСКЛЮЧЕНИЙ 
                games.Add(game);
                Tuple<string, object>[] parametrs = { new Tuple<string, object>("userid", userId), new Tuple<string, object>("gameid", game.GameId) };
                string query = $"INSERT {nameOfTable} (UserId,GameId) VALUE (@userid, @gameid)";
                sqlBase.NoResultQuery(query, parametrs);

            }
        }
        public void DeleteGame(IGame game)
        {
            // А ЕСЛИ НЕ СОДЕРЖИТ
            if (games.Contains(game))
            {
                games.Remove(game);
                Tuple<string, object>[] parametrs = { new Tuple<string, object>("userid", userId), new Tuple<string, object>("gameid", game.GameId) };
                string query = $"DELETE FROM {nameOfTable} WHERE GamesId = @gameid AND  UserId = @userid";
                sqlBase.NoResultQuery(query, parametrs);
            }
        }

    }

}
