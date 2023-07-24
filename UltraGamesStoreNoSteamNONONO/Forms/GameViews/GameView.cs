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

namespace UltraGamesStoreNoSteamNONONO
{
    public partial class GameView : UserControl
    {
        protected Button Button1 { get => button1; }
        protected Button Button2 { get => button2; }
        public GameView(string name, string author, Image icon)
        {
            InitializeComponent();
            labelName.Text = name;
            labelAuthor.Text = author;
            pictureBox1.Image = icon;

        }
    }
}
