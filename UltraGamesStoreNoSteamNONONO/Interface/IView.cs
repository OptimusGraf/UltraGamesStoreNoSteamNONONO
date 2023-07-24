using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltraGamesStoreNoSteamNONONO
{
    public interface IView
    {
        IMarket Market { get; set; }
        void UpdateView();

    }
}
