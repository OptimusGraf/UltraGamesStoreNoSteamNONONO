using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltraGamesStoreNoSteamNONONO
{
    internal interface IUser
    {

        
        public SQLBase SQLBase { get; set; }
        public string UserName { get; }
        public int Age { get; }
        public int PowerOfPC { get; set; }
        public Image Image { get; set; }
        public decimal Money { get; set; }
        public void UpdateInfoAboutGames();
        public ListOfGames Basket { get; }
        public ListOfGames WantedGames { get; }
        public ListOfGames AvailableGames { get; }
        public ListOfGames CreatedGames { get; }

    }
}