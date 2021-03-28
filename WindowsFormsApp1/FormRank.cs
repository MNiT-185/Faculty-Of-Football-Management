using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DAO;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1
{
    public partial class FormRank : Form
    {
        public object LisViewItem { get; private set; }

        public FormRank()
        {
            InitializeComponent();
            DisplayApp();
            ShowRank();
        }

        void DisplayApp()
        {
            btnMenu.TabStop = false;
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.FlatAppearance.BorderSize = 0;
            btnX.TabStop = false;
            btnX.FlatStyle = FlatStyle.Flat;
            btnX.FlatAppearance.BorderSize = 0;
            btnResult.TabStop = false;
            btnResult.FlatStyle = FlatStyle.Flat;
            btnResult.FlatAppearance.BorderSize = 0;
            btnRank.TabStop = false;
            btnRank.FlatStyle = FlatStyle.Flat;
            btnRank.FlatAppearance.BorderSize = 0;
            btnTeam.TabStop = false;
            btnTeam.FlatStyle = FlatStyle.Flat;
            btnTeam.FlatAppearance.BorderSize = 0;
            btnReport.TabStop = false;
            btnReport.FlatStyle = FlatStyle.Flat;
            btnReport.FlatAppearance.BorderSize = 0;
            btnRank.Enabled = false;
            panelMenu.Hide();
        }
        void ShowRank()
        {
            int i = 1;
            List<Doi> listRank = DoiDAO.Instance.GetRank();
            foreach(Doi item in listRank)
            {
                ListViewItem lsvItem = new ListViewItem(i.ToString());
                lsvItem.SubItems.Add(item.Lop.ToString());
                lsvItem.SubItems.Add(item.Diem.ToString());
                lsvItem.SubItems.Add(item.Sovongthang.ToString());
                lvRank.Items.Add(lsvItem);
                i = i + 1;
            }
                
        }
             

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void BtnMenu_Click_1(object sender, EventArgs e)
        {
            if (panelMenu.Visible)
            {
                panelMenu.Hide();
            }
            else
            {
                panelMenu.Show();
            }
        }

        private void BtnResult_Click_1(object sender, EventArgs e)
        {
            ResultForm f = new ResultForm();
            this.Hide();
            f.ShowDialog();
            f.Hide();
        }

        private void BtnRank_Click_1(object sender, EventArgs e)
        {

        }

        private void BtnTeam_Click_1(object sender, EventArgs e)
        {
            FormTeam f = new FormTeam();
            this.Hide();
            f.ShowDialog();
            f.Hide();
        }

        private void BtnReport_Click_1(object sender, EventArgs e)
        {
            FormReport f = new FormReport();
            this.Hide();
            f.ShowDialog();
            f.Hide();
        }

        private void BtnX_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            LoginForm f = new LoginForm();
            this.Hide();
            f.ShowDialog();
            f.Hide();
        }
    }
}
