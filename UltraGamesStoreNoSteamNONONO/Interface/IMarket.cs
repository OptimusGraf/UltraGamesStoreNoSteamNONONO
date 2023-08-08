 using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltraGamesStoreNoSteamNONONO
{
    public interface IMarket
    {
        public SQLBase SQLBase { get; set; }
        public void SignIn(string name, string pasword);
        public void SignOut();
        public void SignUp(string username, int age, string password, int powerOfPc);

        public List<Game> TopTenGamesFrom (int cursor);
        public HashSet<Game> GetBasketList();
        public HashSet<Game> GetWantedList();
        public HashSet<Game> GetUsersListOfGames();
        public List<Game> GetUserCreatedGames();
        public string AddToBasketList(Game game);
        public void RemoveFromBasketList(Game game);
        public string AddToWantedList(Game game);
        public void RemoveFromWantedList(Game game);

        public string BuyGames();
        public bool CreateGame(string nameOfGame, decimal money, int rate, int recAge, DateOnly date, int powerOfPc, string author, byte[] image, byte[] icon, SQLBase sqlBase);
        public event Action ChangedUI;

        public bool BassketContainGames(Game game);
        public bool WantedContainGames(Game game);
        public bool AvaibaleContainGames(Game game);
        public decimal UsersMoney { get; set; }
        public void SetInfoAboutUser(  int age, int powerOfPc, byte[] image);
        public UserInfo GetInfoAboutUser();

        public bool ChangeInfoAboutGame(Game game, byte[] image, byte[] icon, decimal price, int age, int power);
        public List<Review> GetReviews(Game game);
        public void NewReview(Game game, int grade, string text);
        public void AnwserReview(Review review, string text);
     
    }
}
