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
    public partial class ReviewView : UserControl
    {
        protected IMarket market;
        protected Review review;
        protected string authorName;
        public ReviewView(IMarket market, Review review, string authorName)
        {
            this.market = market;
            this.review = review;
            this.authorName = authorName;
            InitializeComponent();
        }

        protected virtual void ReviewView_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = review.image.FromByteArrayToImage();
            labelName.Text = review.userName;
            labelRate.Text = review.grade.ToString();

            richTextBoxReview.Text = review.text;

            if (review.AuthorComment == null)
            {
                this.Height = 240;
                labelAuthor.Visible = false;
                richTextBoxAuthor.Visible = false;
            }

            else
            {
                this.Height = 356;
                labelAuthor.Text = authorName;
                richTextBoxAuthor.Text = review.AuthorComment;
            }

        }


    }
}
