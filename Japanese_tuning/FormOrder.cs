using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Japanese_tuning
{
    public partial class FormOrder : Form
    {

        public FormOrder()
        {
            InitializeComponent();

            StylesCB.Items.AddRange(new string[] { "Grachan", "Kyusha style", "Shakotan", "VIP style", "Yanky style", "Liberty Walk", "Rocket Bunny" });
            logoPB.BackColor = Color.Transparent;
            FIOLB.BackColor = Color.Transparent;
            PassportLB.BackColor = Color.Transparent;
            PhoneNumLB.BackColor = Color.Transparent;
            StyleLB.BackColor = Color.Transparent;
            BrandLB.BackColor = Color.Transparent;
            ModelLB.BackColor = Color.Transparent;
            GenLB.BackColor = Color.Transparent;
            StateNumLB.BackColor = Color.Transparent;
        }

        private void SummaryBT_Click(object sender, EventArgs e)
        {
            if (FIOTX.Text == "" || PassportMTX.Text == "" || PhoneNumMTX.Text == "" || StylesCB.Text == "" || BrandTX.Text == "" || ModelTX.Text == "" || GenTX.Text == "" || StateNumMTX.Text == "")
            {
                MessageBox.Show("Заполните все поля информации!");
            }
            else
            {
                FormSummary sum = new FormSummary(FIOTX.Text, PassportMTX.Text, PhoneNumMTX.Text, StylesCB.Text, BrandTX.Text, ModelTX.Text, GenTX.Text, StateNumMTX.Text);
                sum.Show();
                Hide();
            }
        }

        private void FIOTX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
                FIOTX.Clear();

            if (e.KeyChar == 13)
                PassportMTX.Focus();
        }

        private void PassportMTX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
                PassportMTX.Clear();

            if (e.KeyChar == 13)
                PhoneNumMTX.Focus();
        }

        private void PhoneNumMTX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
                PhoneNumMTX.Clear();

            if (e.KeyChar == 13)
                StylesCB.Focus();
        }

        private void StylesCB_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == 13)
                BrandTX.Focus();
        }

        private void BrandTX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
                BrandTX.Clear();

            if (e.KeyChar == 13)
                ModelTX.Focus();
        }

        private void ModelTX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
                ModelTX.Clear();

            if (e.KeyChar == 13)
                GenTX.Focus();
        }

        private void GenTX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
                GenTX.Clear();

            if (e.KeyChar == 13)
                StateNumMTX.Focus();
        }

        private void StateNumMTX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
                StateNumMTX.Clear();

            if (e.KeyChar == 13)
                SummaryBT.Focus();
        }
    }
}
