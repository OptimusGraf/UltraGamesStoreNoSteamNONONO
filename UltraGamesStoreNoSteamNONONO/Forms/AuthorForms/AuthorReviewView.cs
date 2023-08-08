using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltraGamesStoreNoSteamNONONO
{
    internal class AuthorReviewView : ReviewView
    {
        public AuthorReviewView(IMarket market, Review review, string authorName) : base(market, review, authorName)
        {
            Button button = new Button();
            button.Dock = DockStyle.Fill;
            button.Text = "Сохранить";
            button.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button.Click += Button_Click;
            panel1.Controls.Add(button);

        


        }
        protected override void ReviewView_Load(object sender, EventArgs e)
        {
            base.ReviewView_Load(sender, e);
            richTextBoxAuthor.ReadOnly = false;
            labelAuthor.Visible = true;
            richTextBoxAuthor.Visible = true;
            this.Height = 356;
            labelAuthor.Text = authorName;
            richTextBoxAuthor.Text = review.AuthorComment;
        }

        private void Button_Click(object? sender, EventArgs e)
        {
            market.AnwserReview(review, richTextBoxAuthor.Text);
        }
    }
}
