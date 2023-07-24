using Microsoft.VisualBasic.ApplicationServices;

namespace UltraGamesStoreNoSteamNONONO
{
    public interface IGame
    {
        static public event Action Changed;
        public SQLBase SQLBase { get; set; }
        public int GameId { get; }
        public string Name { get; set; }
        public string Author { get; }
        public DateOnly Release { get; }
        public int PowerOfPc { get; }
        public int Rate { get; set; }
        public Image Icon { get; set; }

        public Image ImageOfGame { get; set; }
        public bool Equals(object? obj);

        public int GetHashCode();
        public decimal Money { get; set; }
        public int RecAge { get; set; }

    }
}
