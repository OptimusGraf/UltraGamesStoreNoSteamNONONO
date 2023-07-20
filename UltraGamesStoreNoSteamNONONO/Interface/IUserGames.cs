using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltraGamesStoreNoSteamNONONO
{
    internal interface IUserGames:IGame
    {
  
        public int Id { get; }

        public bool IsLoaded { get; set; }

        public int Progress { get; set; }

        public int CountOfHour { get; set; }


    }
}
