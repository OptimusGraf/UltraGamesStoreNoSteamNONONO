﻿using System;
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

namespace UltraGamesStoreNoSteamNONONO
{
    public partial class GameView : UserControl
    {
        protected Button Button1 { get => button1; }
        protected Button Button2 { get => button2; }
        public Game Game { get => game;  }

        protected Game game;


        protected IMarket market;
        public GameView(Game game, IMarket market)
        {
            this.game = game;
            this.market = market;
            InitializeComponent();
            labelName.Text = game.Name;
            labelAuthor.Text = game.Author;
            pictureBox1.Image = game.Icon;
            this.Dock = DockStyle.Fill;
            MakeButtons(game, market);
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
            market.AddToWantedList(game);     
        }

        private void Button2_ClickRemove(object? sender, EventArgs e)
        {
            market.RemoveFromWantedList(game);
        }

        private void Button1_ClickRemove(object? sender, EventArgs e)
        {
            market.RemoveFromBasketList(game);
        }

        protected virtual void button1_ClickAdd(object sender, EventArgs e)
        {
            market.AddToBasketList(game);

        }


    }
}