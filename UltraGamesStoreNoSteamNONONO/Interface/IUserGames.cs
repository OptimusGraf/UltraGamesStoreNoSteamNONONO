using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltraGamesStoreNoSteamNONONO
{
    internal interface IUserGames
    {
  
        public int Id { get; }


        public Game Game { get; set; }

        public bool IsLoaded { get; set; }

        public int Progress { get; set; }

        public int CountOfHour { get; set; }

        public bool Equals(object? obj);

        public int GetHashCode();
    }
}
