﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace UltraGamesStoreNoSteamNONONO
{
    public partial class Form2 : Form
    {
        IMarket market;


        public Form2()
        {

            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string connection = ConfigurationManager.ConnectionStrings["base"].ConnectionString;
            market = new Market(connection);
            market.SQLBase.OpenConnection();
            signin signin = new signin(market);
            signin.ShowDialog();
            if (signin.DialogResult != DialogResult.OK)
                 this.Close();
            MessageBox.Show("Вы успешно вошли в аккаунт");

        }
    }

    class testclass
    {

        public string name;
        public string surname;
        public int id;

        public testclass(string name, string surname, int id)
        {
            this.name = name;
            this.surname = surname;
            this.id = id;
        }
        public override string ToString()
        {
            return name + surname + id.ToString();
        }
    }

}
