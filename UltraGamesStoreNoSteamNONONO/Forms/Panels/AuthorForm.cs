using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UltraGamesStoreNoSteamNONONO
{
    public partial class AuthorForm : Form
    {
        public AuthorForm(IMarket market)
        {
            InitializeComponent();
            Controls.Add(new GamePanelAuthor(market));
        }
    }
}
