using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltraGamesStoreNoSteamNONONO.Forms
{
    public interface IView
    {
        IMarket market { get; set; }
        void UpdateView();

    }
}
