

namespace UltraGamesStoreNoSteamNONONO
{ 
    public class Market : IMarket
    {
        SQLBase sqlBase;
        public SQLBase SQLBase { get { return sqlBase; } set { sqlBase = value; } }

        public event Action ChangedUI;

        private User currentUser;
        public User CurrentUser => currentUser;

        public Market(string connection)
        {
            this.sqlBase = new SQLBase(connection);
            Game.SQLBase = this.sqlBase;
        }

        public decimal UsersMoney { get => currentUser.Money; set { currentUser.Money = value; ChangedUI?.Invoke(); } }

        public string AddToBasketList(Game game)
        {
            CurrentUser.Basket.AddGame(game);
            ChangedUI?.Invoke();
            return CheckAgeAndPower(game);
        }

        private string CheckAgeAndPower(Game game)
        {
            UserInfo userInfo = currentUser.UserInfo;
            string result = "";
            if (game.PowerOfPc > userInfo.PowerOfPC)
            {
                result += "Требуемая мощность игры выше вашей \n";
            }
            if (game.RecAge > userInfo.Age)
            {
                result += "Требуемый возвраст больше вашего, вы не сможете купить игру \n";
            }
            return result;

        }

        public string AddToWantedList(Game game)
        {
            CurrentUser.WantedGames.AddGame(game);
            ChangedUI?.Invoke();
            return CheckAgeAndPower(game);
        }

        public string BuyGames()
        {
            string result = "";
            decimal sum = 0;
            int recAge = -1;
            string nameRecAge = "";
            foreach (var game in CurrentUser.Basket.Games)
            {
                sum += game.Money;

                if (recAge < game.RecAge)
                {
                    recAge = game.RecAge;
                    nameRecAge = game.Name;
                }
            }

            if (currentUser.Age < recAge)
            {
                return $"Вам нельзя играть в \"{nameRecAge}\", проверьте возрастные ограничения";
            }
            if (currentUser.Money < sum)
            {
                return "Денег недостаточно";

            }

            CurrentUser.Money -= sum;
            foreach (var game in CurrentUser.Basket.Games)
            {
                //ИСКЛЮЧЕНИЯ
                CurrentUser.AvailableGames.AddGame(UserGame.NewUserGame(game, currentUser.id, sqlBase));
                currentUser.Basket.DeleteGame(game);
                currentUser.WantedGames.DeleteGame(game);
            }

            ChangedUI?.Invoke();
            return "Успешно";
        }

        public bool CreateGame(string nameOfGame, decimal money, int rate, int recAge, int powerOfPc, string author, byte[] image, byte[] icon, SQLBase sqlBase)
        {
            bool result;
            try
            {
                DateOnly date = DateOnly.FromDateTime(DateTime.Now);
                Game.newGame(nameOfGame, money, rate, recAge, date, powerOfPc, author, image, icon);
                result = true;
                ChangedUI?.Invoke();
            }
            catch (Exception)
            {
                result = false;
            }

            return result;
        }

        public HashSet<Game> GetBasketList()
        {
            return CurrentUser.Basket.Games;
        }

        public List<Game> TopTenGamesFrom(int cursor = 0)
        {
            return Game.GetTenGames(cursor, sqlBase);
        }

        public HashSet<Game> GetUsersListOfGames()
        {
            return CurrentUser.AvailableGames.Games;
        }

        public HashSet<Game> GetWantedList()
        {
            return CurrentUser.WantedGames.Games;
        }
        public List<Game> GetUserCreatedGames()
        {
            return currentUser.CreatedGames;
        }
        public void RemoveFromBasketList(Game game)
        {
            CurrentUser.Basket.DeleteGame(game);
            ChangedUI?.Invoke();
        }

        public void RemoveFromWantedList(Game game)
        {
            CurrentUser.WantedGames.DeleteGame(game);
            ChangedUI?.Invoke();
        }

        public bool SignIn(string name, string pasword)
        {
            try
            {
                currentUser = User.SingIn(name, pasword, sqlBase);
                ChangedUI?.Invoke();
                return true;
            }
            catch (Exception)
            {  
                return false;
            }
        }

        public void SignOut()
        {
            currentUser = null;
            ChangedUI?.Invoke();
        }

        public bool SignUp(string username, int age, string password, int powerOfPc)
        {
            try
            {
            
                currentUser = User.NewUser(username, age, password, powerOfPc, sqlBase);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool BassketContainGames(Game game)
        {
            return currentUser.Basket.ContainGame(game);
        }

        public bool WantedContainGames(Game game)
        {
            return currentUser.WantedGames.ContainGame(game);
        }

        public bool AvaibaleContainGames(Game game)
        {
            return currentUser.AvailableGames.ContainGame(game);

        }

        public void SetInfoAboutUser(int age, int powerOfPc, byte[] image)
        {
            currentUser.UserInfo = new UserInfo(age, powerOfPc, image);
            ChangedUI?.Invoke();
        }

        public UserInfo GetInfoAboutUser()
        {
            return currentUser.UserInfo;
        }

        public bool ChangeInfoAboutGame(Game game, byte[] image, byte[] icon, decimal price, int age, int power)
        {
            bool result;

            try
            {
                game.ChangeInfoAboutGame(image, icon, price, age, power);
                result = true;
                ChangedUI?.Invoke();
            }
            catch (Exception)
            {
                result = false;
            }

            return result;
        }

        public List<Review> GetReviews(Game game)
        {
            return game.GetReviews();
        }

        public void NewReview(Game game, int grade, string text)
        {
            Review.NewReview(game, CurrentUser.UserName, grade, text, sqlBase);
            game.ChangeRate();
            ChangedUI?.Invoke();
        }
        public void AnwserReview(Review review, string text)
        {
            review.AuthorComment = text;
            ChangedUI?.Invoke();
        }

        public List<string> GetNotifications()
        {
          return  CurrentUser.LoadNoatification();
        }
        public void RemoveNotififcations()
        {
            currentUser.RemoveNotififcations();
        }
    }
}
