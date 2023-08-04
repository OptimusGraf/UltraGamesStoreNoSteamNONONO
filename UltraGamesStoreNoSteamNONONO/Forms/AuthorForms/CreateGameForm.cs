using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            if (myPictureBoxIcon != null && myPictureBoxImage != null && textBoxName.Text != "" )
            {
                Market.CreateGame
                    (textBoxName.Text, numericUpDownPrice.Value, 0, Convert.ToInt32(numericUpDownAge.Value),
                   DateOnly.FromDateTime( DateTime.Now), Convert.ToInt32(numericUpDownPower.Value), Market.GetInfoAboutUser().UserName, myPictureBoxImage.Image, myPictureBoxIcon.Image, Market.SQLBase);
            }
        }
    }
}
