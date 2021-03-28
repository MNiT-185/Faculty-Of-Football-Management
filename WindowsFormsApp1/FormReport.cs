using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormReport : Form
    {
        public FormReport()
        {
            InitializeComponent();
            DisplayApp();
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
            btnTeam.Enabled = false;
            panelMenu.Hide();
        }
        private void BtnResult_Click(object sender, EventArgs e)
        {
            ResultForm f = new ResultForm();
            this.Hide();
            f.ShowDialog();
            f.Hide();
        }

        private void BtnRank_Click(object sender, EventArgs e)
        {
            FormRank f = new FormRank();
            this.Hide();
            f.ShowDialog();
            f.Hide();
        }

        private void BtnTeam_Click(object sender, EventArgs e)
        {
            FormTeam f = new FormTeam();
            this.Hide();
            f.ShowDialog();
            f.Hide();
        }

        private void BtnMenu_Click(object sender, EventArgs e)
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

        private void BtnX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qlgbdDataSet.chitietvongdau' table. You can move, or remove it, as needed.
            this.chitietvongdauTableAdapter.Fill(this.qlgbdDataSet.chitietvongdau);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
