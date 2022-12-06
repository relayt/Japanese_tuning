using System;
using System.Windows.Forms;
using System.Drawing;

namespace Japanese_tuning
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
            LogoMenu.BackColor = Color.Transparent;
        }

        private void OrderBT_Click(object sender, EventArgs e)
        {

        }

        private void MyOrderBT_Click(object sender, EventArgs e)
        {
            FormOrder ord = new FormOrder();
            ord.Show();
        }

        private void JDMsiteLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void FormMenu_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void VIPBT_Click(object sender, EventArgs e)
        {

        }

        private void FormMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (MessageBox.Show("Вы точно хотите выйти?", "Подтверждение отмены", MessageBoxButtons.YesNo) == DialogResult.Yes)

                Application.Exit();
        }

        private void FormMenu_FormClosing_1(object sender, FormClosingEventArgs e)
        {

        }

        private void rocketBunnyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRocketB rb = new FormRocketB();
            rb.Show();
        }

        private void vIPStyleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVIP vip = new FormVIP();
            vip.Show();
        }

        private void grachanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGrachan gr = new FormGrachan();
            gr.Show();
        }

        private void kyushaStyleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKyusha kyusha = new FormKyusha();
            kyusha.Show();
        }

        private void shakotanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormShakotan sh = new FormShakotan();
            sh.Show();
        }

        private void yankyStyleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormYanky yan = new FormYanky();
            yan.Show();
        }

        private void libertyWalkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLiberty lib = new FormLiberty();
            lib.Show();
        }
    }
}
