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
    public partial class InfoAboutUserForm : Form
    {
        IMarket market;
        byte[] image;
        public InfoAboutUserForm(IMarket market)
        {
            this.market = market;
            InitializeComponent();

        }

        private void InfoAboutUserForm_Load(object sender, EventArgs e)
        {
            UserInfo info = market.GetInfoAboutUser();
            label1.Text += " " + info.UserName;
            numericUpDownAge.Value = info.Age;
            numericUpDownPower.Value = info.PowerOfPC;
            pictureBox1.Image = info.Image.FromByteArrayToImage();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            market.SetInfoAboutUser(Convert.ToInt32(numericUpDownAge.Value), Convert.ToInt32(numericUpDownPower.Value), image);
        }

        private void buttonImage_Click(object sender, EventArgs e)
        { 

            image =Helper.GetPictureFromDialog();
            pictureBox1.Image = image.FromByteArrayToImage();
        }
    }
}
