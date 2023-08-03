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
    public partial class GameTabControl : UserControl,IView
    {
        protected Game game;
        public IMarket Market { get; set; }
        GameView gameView;
        public GameTabControl(GameView gameView, IMarket market, Game game)
        {
            this.Market = market;
            this.game = game;
            this.gameView = gameView;
            gameView.Enabled = false;

            InitializeComponent();
            panelForGameView.Controls.Add(gameView);
            UpdateView();
        }
        public void UpdateView()
        {
            labelAge.Text += game.RecAge;
            labelPower.Text += game.PowerOfPc;
            pictureBoxForMainImage.Image = game.ImageOfGame.FromByteArrayToImage();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            foreach (Control contorl in Parent.Controls)
            {
                contorl.Visible = true;
                contorl.Enabled = true;
            }
            gameView.Enabled = true;
            if (Parent is IView)
            {
                ((IView)Parent).UpdateView();
            }
            Parent.Controls.Remove(this);
        }
      
    }
}
