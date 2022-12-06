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
    public partial class FormSummary : Form
    {
        public static string connect = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source = Users\\LogPassInfo.mdb";

        private OleDbConnection myCon;

        public FormSummary(string FIOTX, string PassportMTX, string PhoneNumMTX, string StylesCB, string BrandTX, string ModelTX, string GenTX, string StateNumMTX)
        {
            InitializeComponent();

            myCon = new OleDbConnection(connect);

            FinalLBX.Items.Add("ФИО: " + FIOTX);
            FinalLBX.Items.Add("Паспортные данные: " + PassportMTX);
            FinalLBX.Items.Add("Номер телефона: "+ PhoneNumMTX);
            FinalLBX.Items.Add("Стиль тюнинга: " + StylesCB);
            FinalLBX.Items.Add("Марка машины: " + BrandTX);
            FinalLBX.Items.Add("Модель машины: " + ModelTX);
            FinalLBX.Items.Add("Поколение: " + GenTX);
            FinalLBX.Items.Add("Гос. номер: " + StateNumMTX);

            if (StylesCB.Equals("Grachan"))
            {
                SummaTX.Text = "200000 руб.";
            }

            if (StylesCB.Equals("Kyusha style"))
            {
                SummaTX.Text = "250000 руб.";
            }

            if (StylesCB.Equals("Shakotan"))
            {
                SummaTX.Text = "150000 руб.";
            }

            if (StylesCB.Equals("VIP style"))
            {
                SummaTX.Text = "200000 руб.";
            }

            if (StylesCB.Equals("Yanky style"))
            {
                SummaTX.Text = "400000 руб.";
            }

            if (StylesCB.Equals("Liberty Walk"))
            {
                SummaTX.Text = "650000 руб.";
            }

            if (StylesCB.Equals("Rocket Bunny"))
            {
                SummaTX.Text = "750000 руб.";
            }
            string query = "INSERT INTO `Orders` (`FIO`, `Passport`, `Phone`, `Style of tuning`, `Brand`, `Model`, `Gen`, `State`) VALUES (@fio, @passp, @phone, @style, @brand, @model, @gen, @state)";
            OleDbCommand com = new OleDbCommand(query, myCon);
            com.Parameters.Add("@fio", FIOTX);
            com.Parameters.Add("@passp", PassportMTX);
            com.Parameters.Add("@phone", PhoneNumMTX);
            com.Parameters.Add("@style", StylesCB);
            com.Parameters.Add("@brand", BrandTX);
            com.Parameters.Add("@model", ModelTX);
            com.Parameters.Add("@gen", GenTX);
            com.Parameters.Add("@state", StateNumMTX);
            myCon.Open();
            com.ExecuteNonQuery();

        }

        private void FormSummary_FormClosing(object sender, FormClosingEventArgs e)
        {
            myCon.Close();
        }

        private void SaveBT_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Спасибо что выбрали наше тюнинг-ателье!", "Спасибо за заказ!");
            FormMenu menu = new FormMenu();
            menu.Focus();
            Close();
        }
    }
}
