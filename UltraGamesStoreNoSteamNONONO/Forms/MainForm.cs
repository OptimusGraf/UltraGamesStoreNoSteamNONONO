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
using UltraGamesStoreNoSteamNONONO.Forms.AuthorForms;

namespace UltraGamesStoreNoSteamNONONO
{
    public partial class MainForm : Form
    {
        // уведомления; отзывы; исключения; асинхи; фильтрация; даты выхода ; если база данных меняется, то нужно чтобы прога видела эти обнволения;
        // если игра есть в корзине (или другом списке) сделать чтобы кнопка менялась, если при добавлении игры мощности недостаточно, уведомить пользователя об этом;
        // в классе маркет для добавления игр в списки реализовать проверки:
        // если при покупке не получается купить (возраст или нет денег), уведомить
        // в сингин контрол разобраться с искл, так же добавить возможность с окна регестрации вернуться назад на окно авторизации
        // списки игр можно попробовать сделать через generic 
        // поменять гамевью, сделать основной класс абстрактным
        // добавить на гаймвьюшку в магазине рейтинг
        // сделать чтобы рейтинг вычислялся на основе отзывов 
        // переделать AddtoflowPanel в gameviews

        IMarket market;

        public MainForm()
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
                market.ChangedUI += () => userToolStripMenuItem.Text = market.GetInfoAboutUser().UserName; ;
            }

        }


        private void AddViewOnPanel(IView userPanel, Panel panel)
        {
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
                this.Show();
                return true;
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

        private void CreatedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form authorForm = new AuthorForm(market);
            authorForm.ShowDialog();
        }

        private void CreateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form createForm = new CreateGameForm(market);
            createForm.ShowDialog();
        }
    }



}
