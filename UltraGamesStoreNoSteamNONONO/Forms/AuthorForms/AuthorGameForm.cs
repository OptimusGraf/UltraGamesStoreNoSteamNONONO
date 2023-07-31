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
    public partial class AuthorGameForm : Form, IView
    {
        public IMarket Market { get; set; }
        Game game;
        public AuthorGameForm(IMarket market, Game game)
        {
            this.Market = market;
            this.game = game;
            InitializeComponent();
        }


        public void UpdateView()
        {
            pictureBox1.Image = game.ImageOfGame;
            pictureBox2.Image = game.Icon;
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
            ;
            Market.ChangeInfoAboutGame
                (game, pictureBox1.Image, pictureBox2.Image,
                numericUpDownPrice.Value, Convert.ToInt32(numericUpDownAge.Value),
                Convert.ToInt32(numericUpDownPower.Value));
        }
    }
}
