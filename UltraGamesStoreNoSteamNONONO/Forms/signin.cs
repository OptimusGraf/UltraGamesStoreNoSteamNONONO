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
    internal partial class signin : Form
    {
        IMarket market;
        UserControl control;
        public signin(IMarket market) : base()
        {
            this.market = market;
            InitializeComponent();
        }

        private void signin_Load(object sender, EventArgs e)
        {
            control = new SignInControl(market);
            control.Dock = DockStyle.Fill;
            panel1.Controls.Add(control);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel1.Controls.Remove(control);
            control = new SignUpControl(market);
            control.Dock = DockStyle.Fill;
            panel1.Controls.Add(control);

        }
    }
}
