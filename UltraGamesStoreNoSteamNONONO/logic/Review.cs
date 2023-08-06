using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace UltraGamesStoreNoSteamNONONO
{
    // с инкапсюляции что то сделать
    public class Review
    {
        SQLBase sqlBase;
        public readonly int id;
        public readonly string userName;
        public readonly string text;
        string authorComment;
        
        public Review(DataRow row,SQLBase sqlBase):
            this(sqlBase, (int)row["id"], (string)row["UserName"], (string)row["textOfReview"], (string)row["authorComment"])
        {

        }
        private Review(SQLBase sqlBase, int id, string userName, string text, string authorComment = null)
        {
            this.sqlBase = sqlBase;
            this.id = id;
            this.userName = userName;
            this.text = text;
            this.authorComment = authorComment;
        }

        public static void NewReview(Game game, string userName, string text, SQLBase sqlBase)
        {
            string query = "INSERT Reviews(UserName, GamesId, textOfReview) VALUES (@userName, @gameId, @text)";
            Tuple<string, object>[] parameters =
                   {
                    new Tuple<string, object>("userName", userName),
                    new Tuple<string, object>("gameId", game.GameId),
                    new Tuple<string, object>("text",text)
                };
            sqlBase.NoResultQuery(query, parameters);

        }

        public string AuthorComment
        {
            get => authorComment;
            set
            {
                string query = "UPDATE Reviews SET authorComment=@comment WHERE id = @id";
                Tuple<string, object>[] parameters =
                    {
                    new Tuple<string, object>("comment", value),
                    new Tuple<string, object>("id", id)
                };
                sqlBase.NoResultQuery(query, parameters);
                authorComment = value;
            }






    }
}
