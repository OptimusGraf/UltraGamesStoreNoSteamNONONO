﻿using System;
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
    public partial class CreatedGamesForm : Form
    {
        IMarket market;
        public CreatedGamesForm(IMarket market)
        {
            InitializeComponent();
            this.market = market;
        }

      
    }
}
