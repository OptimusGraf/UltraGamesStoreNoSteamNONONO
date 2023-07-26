using System;
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
        // уведомления; отзывы; исключения; асинхи; фильтрация; даты выхода и изображения; если база данных меняется, то нужно чтобы прога видела эти обнволения;
        // если игра есть в корзине (или другом списке) сделать чтобы кнопка менялась, если при добавлении игры мощности недостаточно, уведомить пользователя об этом;
        // если при покупке не получается купить (возвраст), уведомить
        // в сингин контрол разобраться с искл, так же добавить возможность с окна регестрации вернуться назад на окно авторизации
        // КАРТИНКИ
        // списки игр можно попробовать сделать через generic 

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

            if (SignIn())
            {
                AddViewOnPanel(new GamePanelMarket(market), marketPanel);
                AddViewOnPanel(new GamePanelBassket(market), panelBassket);
                AddViewOnPanel(new GamePanelWanted(market), panelWanted);
                AddViewOnPanel(new GamePanelUsers(market), panelLibary);
                moneytoolStripMenuItem.Text = "Cчет: " + market.UsersMoney.ToString();
                userToolStripMenuItem.Text = market.GetInfoAboutUser().UserName;
                market.ChangedUI += () => moneytoolStripMenuItem.Text = "Cчет: " + market.UsersMoney.ToString();
            }

        }


        private void AddViewOnPanel(IView userPanel, Panel panel)
        {
            market.ChangedUI += userPanel.UpdateView;
            panel?.Controls.Add(userPanel as Control);
        }

        private bool SignIn()
        {
            SignIn signin = new SignIn(market);

            this.Hide();
            signin.ShowDialog();
            if (signin.DialogResult != DialogResult.OK)
            {
                this.Close();
                return false;
            }
            else
            {
                MessageBox.Show("Вы успешно вошли в аккаунт");
                return true;
                this.Show();
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SignIn();
        }

        private void moneytoolStripMenuItem_Click(object sender, EventArgs e)
        {
            MoneyForm moneyForm = new MoneyForm(market);
            moneyForm.ShowDialog();

        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form infoForm = new InfoAboutUserForm(market);
            infoForm.ShowDialog();
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
