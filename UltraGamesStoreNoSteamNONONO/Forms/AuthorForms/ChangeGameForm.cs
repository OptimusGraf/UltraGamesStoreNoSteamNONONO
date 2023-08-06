using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltraGamesStoreNoSteamNONONO
{
    internal class ChangeGameForm : AuthorGameForm
    {
        Label labelRate;
        Label labelRealese;
        public ChangeGameForm(IMarket market, Game game) : base(market)
        {
            this.game = game;
            textBoxName.ReadOnly = true;
            labelRate = new Label();
            labelRealese = new Label();
            flowLayoutPanelForInfo.Controls.Add(labelRate);
            flowLayoutPanelForInfo.Controls.Add(labelRealese);
        }
        public override void UpdateView()
        {
            myPictureBoxImage.Image = game.ImageOfGame;
            myPictureBoxIcon.Image = game.Icon;
            textBoxName.Text = game.Name;
            numericUpDownPrice.Text = game.Money.ToString();
            numericUpDownPower.Text = game.PowerOfPc.ToString();
            numericUpDownAge.Text = game.RecAge.ToString();
            labelRate.Text += game.Rate.ToString();
            labelRealese.Text = game.Release.ToString();
            labelName.Text = game.Name.ToString();
        }
        protected override void Save()
        {
            bool result = Market.ChangeInfoAboutGame
                 (game, myPictureBoxImage.Image, myPictureBoxIcon.Image,
                 numericUpDownPrice.Value, Convert.ToInt32(numericUpDownAge.Value),
                 Convert.ToInt32(numericUpDownPower.Value));
            if (!result)
            {
                MessageBox.Show("ERROR");
            }
        }
    }
}
