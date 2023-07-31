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
    public partial class GameTabControl : UserControl
    {
        protected Game game;
        protected IMarket market;
        GameView gameView;
        public GameTabControl(GameView gameView, IMarket market, Game game)
        {
            this.market = market;
            this.game = game;
            this.gameView = gameView;
            gameView.Enabled = false;

            InitializeComponent();
            labelAge.Text += game.RecAge;
            labelPower.Text += game.PowerOfPc;
            pictureBoxForMainImage.Image = game.ImageOfGame;
            panelForGameView.Controls.Add(gameView);
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
