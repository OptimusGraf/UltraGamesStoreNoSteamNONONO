using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace UltraGamesStoreNoSteamNONONO.logic
{
    public partial class GameView : UserControl
    {
         public GameView(string name, string author, Image icon) : base()
        {
            InitializeComponent();
            labelName.Text = name;
            labelAuthor.Text = author;
            pictureBox1.Image = icon;
        }
    }
}
