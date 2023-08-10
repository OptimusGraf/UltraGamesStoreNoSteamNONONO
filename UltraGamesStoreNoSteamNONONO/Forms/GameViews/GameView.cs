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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace UltraGamesStoreNoSteamNONONO
{
    public abstract partial class GameView : UserControl, IView
    {

        public Game Game { get => game; }

        protected Game game;

        public IMarket Market { get; set; }
        public void UpdateView()
        {
            labelName.Text = game.Name;
            labelAuthor.Text = game.Author;
            pictureBox1.Image = game.Icon.FromByteArrayToImage();
            labelDate.Text = game.Release.ToString();
            labelRate.Text = game.Rate.ToString();
            MakeButtons();
        }
        public GameView(Game game, IMarket market)
        {
            this.game = game;
            this.Market = market;
            market.ChangedUI += UpdateView;
            this.Dock = DockStyle.Fill;
            InitializeComponent();
            UpdateView();
        }

        protected abstract void MakeButtons();


    }
}
