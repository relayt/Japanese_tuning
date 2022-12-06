using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Japanese_tuning
{
    public partial class RegisrtationForm : Form
    {
        public static string connect = "Provider=Microsoft.JET.OLEDB.4.0; Data Source = Users\\LogPassInfo.mdb";

        private OleDbConnection myCon;

        public RegisrtationForm()
        {
            InitializeComponent();
            LogoReg.BackColor = Color.Transparent;
            EntLoginLB.BackColor = Color.Transparent;
            EntPasswordLB.BackColor = Color.Transparent;
            EntPasswordSecLB.BackColor = Color.Transparent;
        }
        public Boolean CheckingUsers()
        {
            myCon = new OleDbConnection(connect);

            myCon.Open();

            string query = "SELECT * FROM `Entrance` WHERE `Login` = @log";
            DataTable table1 = new DataTable();
            OleDbDataAdapter adapt = new OleDbDataAdapter();
            OleDbCommand com = new OleDbCommand(query, myCon);
            com.Parameters.Add("@log", EntLoginTX.Text);
            adapt.SelectCommand = com;
            adapt.Fill(table1);
            if (table1.Rows.Count > 0)
            {
                MessageBox.Show("Такой логин уже используется!");
                return true;
            }
            else
            {
                return false;
            }
        }
        private void RegBT_Click(object sender, EventArgs e)
        {
            if (EntLoginTX.Text == "")
            {
                MessageBox.Show("Введите логин!");
                return;
            }
            if (EntPasswordTX.Text == "")
            {
                MessageBox.Show("Введите пароль!");
                return;
            }
            if (EntPasswordSecTX.Text == "")
            {
                MessageBox.Show("Введите пароль повторно!");
                return;
            }
            if (EntLoginTX.Text.Length < 3 || EntLoginTX.Text.Length > 40)
            {
                MessageBox.Show("Минимальная длина логина - 3 (Макс. - 40)!");
                return;
            }
            if (EntPasswordTX.Text.Length < 6 || EntPasswordTX.Text.Length > 40)
            {
                MessageBox.Show("Минимальная длина пароля - 6 (Макс. - 40)!");
                return;
            }
            if (EntPasswordSecTX.Text.Length < 6 || EntPasswordSecTX.Text.Length > 40)
            {
                MessageBox.Show("Минимальная длина пароля - 6 (Макс. - 40)!");
                return;
            }
            if (CheckingUsers())
            {
                return;
            }
            if (EntPasswordTX.Text != EntPasswordSecTX.Text)
            {
                MessageBox.Show("Пароли не совпадают!");
                EntPasswordTX.Clear();
                EntPasswordSecTX.Clear();
            }
            else
            {
                string query = "INSERT INTO `Entrance` (`Login`, `Password`) VALUES (@log, @pass)";
                OleDbCommand com = new OleDbCommand(query, myCon);
                com.Parameters.Add("@log", EntLoginTX.Text);
                com.Parameters.Add("@pass", EntPasswordTX.Text);
                com.ExecuteNonQuery();
                myCon.Close();
                MessageBox.Show("Вы успешно зарегистрировались!");
                Hide();
                Close();
            }
        }

        private void EntLoginTX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
                EntLoginTX.Clear();

            if (e.KeyChar == 13)
                EntPasswordTX.Focus();
        }

        private void EntPasswordTX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
                EntPasswordTX.Clear();

            if (e.KeyChar == 13)
                EntPasswordSecTX.Focus();
        }

        private void EntPasswordSecTX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
                EntPasswordSecTX.Clear();

            if (e.KeyChar == 13)
                RegBT.Focus();
        }
    }
}
