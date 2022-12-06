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
using System.IO;

namespace Japanese_tuning
{
    public partial class PassLogForm : Form
    {
        public static string connect = "Provider=Microsoft.JET.OLEDB.4.0; Data Source = Users\\LogPassInfo.mdb";

        private OleDbConnection myCon;

        public PassLogForm()
        {
            InitializeComponent();
            LogoEnt.BackColor = Color.Transparent;
            LoginLB.BackColor = Color.Transparent;
            PasswordLB.BackColor = Color.Transparent;
        }

        private void RegistrationBT_Click(object sender, EventArgs e)
        {
            RegisrtationForm reg = new RegisrtationForm();
            reg.Show();
        }

        private void PassLogForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void EntranceBT_Click(object sender, EventArgs e)
        {
            myCon = new OleDbConnection(connect);

            myCon.Open();

            string loginUsr = LoginTX.Text;
                string passwordUsr = PasswordTX.Text;
                string query = "SELECT * FROM `Entrance` WHERE `Login` = @log AND `Password` = @pass";
                DataTable table = new DataTable();
                OleDbDataAdapter adapt = new OleDbDataAdapter();
                OleDbCommand com = new OleDbCommand(query, myCon);
                com.Parameters.Add("@log", loginUsr);
                com.Parameters.Add("@pass", passwordUsr);
                myCon.Close();
                adapt.SelectCommand = com;
                adapt.Fill(table);
                if (table.Rows.Count > 0)
                {
                    MessageBox.Show("Добро пожаловать!");
                    FormMenu menu = new FormMenu();
                    menu.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Проверьте логин или пароль!");
                    LoginTX.Clear();
                    PasswordTX.Clear();
                }
        }

        private void LoginTX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
                LoginTX.Clear();

            if (e.KeyChar == 13)
                PasswordTX.Focus();
        }

        private void PasswordTX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
                PasswordTX.Clear();

            if (e.KeyChar == 13)
                EntranceBT.Focus();
        }
    }
}
