using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace UltraGamesStoreNoSteamNONONO
{
    public partial class GameView : UserControl, IView
    {
        protected Button Button1 { get => button1; }
        protected Button Button2 { get => button2; }
        public Game Game { get => game; }

        protected Game game;


        public IMarket Market { get; set; }
        public void UpdateView()
        {
            labelName.Text = game.Name;
            labelAuthor.Text = game.Author;
            pictureBox1.Image = game.Icon.FromByteArrayToImage();
            MakeButtons(game, Market);
        }
        public GameView(Game game, IMarket market)
        {
            this.game = game;
            market.ChangedUI += UpdateView;
            this.Market = market;
            this.Dock = DockStyle.Fill;
            InitializeComponent();
            UpdateView();
        }

        protected virtual void MakeButtons(Game game, IMarket market)
        {
            if (market.AvaibaleContainGames(game) == false)
            {
                if (market.BassketContainGames(game))
                {
                    button1.Text = "Удалить из коризны";
                    button1.Click += Button1_ClickRemove;

                }
                else
                {
                    button1.Text = "В коризну";
                    button1.Click += button1_ClickAdd;
                }

                if (market.WantedContainGames(game))
                {
                    button2.Text = "Удалить из желаемого";
                    button2.Click += Button2_ClickRemove;

                }
                else
                {
                    button2.Enabled = true;
                    button2.Click += Button2_ClickAdd;
                }
            }
            else
            {
                button1.Text = "Куплена";
                button2.Text = "Куплена";
                button1.Enabled = false;
                button2.Enabled = false;
            }


            labelName.Text += " цена: " + game.Money.ToString();
        }

        private void Button2_ClickAdd(object? sender, EventArgs e)
        {
            Market.AddToWantedList(game);
        }

        private void Button2_ClickRemove(object? sender, EventArgs e)
        {
            Market.RemoveFromWantedList(game);
        }

        private void Button1_ClickRemove(object? sender, EventArgs e)
        {
            Market.RemoveFromBasketList(game);
        }

        protected virtual void button1_ClickAdd(object sender, EventArgs e)
        {
            Market.AddToBasketList(game);

        }


    }
}
