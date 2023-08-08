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
    public partial class AuthorReviewsForm : Form, IView
    {
        public IMarket Market { get; set; }
        Game game;
        public AuthorReviewsForm(IMarket market, Game game)
        {
            InitializeComponent();
            this.Market = market;
            this.game = game;
            UpdateView();
        }



        public void UpdateView()
        {
            if (this.game != null)
            {
                var reviews = Market.GetReviews(game);
                foreach (var review in reviews)
                {
                    flowLayoutPanel1.Controls.Add(new AuthorReviewView(Market, review, game.Author));
                }
            }
        }
    }
}
