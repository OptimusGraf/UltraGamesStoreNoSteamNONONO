using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UltraGamesStoreNoSteamNONONO.Forms
{
    public partial class AuthorGameForm : Form
    {
        public IMarket Market { get; set; }
        Game game;
        byte[] imageOfGame;
        byte[] icon;
        public AuthorGameForm(IMarket market, Game game)
        {
            this.Market = market;
            this.game = game;
            InitializeComponent();
        }


        public void UpdateView()
        {
            imageOfGame = game.ImageOfGame ;
            icon = game.Icon;
            pictureBoxImage.Image = game.ImageOfGame.FromByteArrayToImage();
            pictureBoxIcon.Image = game.Icon.FromByteArrayToImage();
            labelRate.Text += game.Rate.ToString();
            labelRealese.Text = game.Release.ToString();
            labelName.Text += game.Name.ToString();
            numericUpDownPrice.Text = game.Money.ToString();
            numericUpDownPower.Text = game.PowerOfPc.ToString();
            numericUpDownAge.Text = game.RecAge.ToString();


        }

        private void AuthorGameForm_Load(object sender, EventArgs e)
        {
            UpdateView();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Market.ChangeInfoAboutGame
                (game, imageOfGame, icon,
                numericUpDownPrice.Value, Convert.ToInt32(numericUpDownAge.Value),
                Convert.ToInt32(numericUpDownPower.Value));
        }

        private void buttonIcon_Click(object sender, EventArgs e)
        {
            icon = Helper.GetPictureFromDialog();
            pictureBoxIcon.Image = icon.FromByteArrayToImage();
        }
        private void buttonImage_Click(object sender, EventArgs e)
        {
            imageOfGame = Helper.GetPictureFromDialog();
            pictureBoxImage.Image = imageOfGame.FromByteArrayToImage();
        }
    


    }
}
