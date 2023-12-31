﻿

namespace UltraGamesStoreNoSteamNONONO.Forms.AuthorForms
{
    public class CreateGameForm : AuthorGameForm
    {
        public CreateGameForm(IMarket market) : base(market)
        {
        }

        public override void UpdateView()
        {

        }

        protected override void Save()
        {
            if (myPictureBoxIcon != null && myPictureBoxImage != null && textBoxName.Text != "")
            {
                bool result = Market.CreateGame
                    (textBoxName.Text, numericUpDownPrice.Value, 0, Convert.ToInt32(numericUpDownAge.Value),
                     Convert.ToInt32(numericUpDownPower.Value),
                   Market.GetInfoAboutUser().UserName, myPictureBoxImage.Image, myPictureBoxIcon.Image, Market.SQLBase);
                if (!result)
                {
                    MessageBox.Show("ERROR");
                }

            }
            else
                MessageBox.Show("Заполните все поля");
        }
    }
}
