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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add(new testclass("as;lfj", "asf;a", 5));
            listBox1.Items.Add(new testclass("as;lfj", "asf;a", 6));
            listBox1.Items.Add(new testclass("as;lfj", "asf;a", 7));
            MessageBox.Show(new testclass("as;lfj", "asf;a", 5).ToString());
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
