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
    public partial class FormTeam : System.Windows.Forms.Form
    {
        BindingSource teamList = new BindingSource();
        public FormTeam()
        {
            InitializeComponent();
            dgvTeam.DataSource = teamList;
            DisplayApp();
            GiaoDienQuanLyDoiBong();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

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
        #region QuanLyDoiBong
        //Xử lý khi chọn button quản lý đội bóng
        private void BtnTeam_Click(object sender, EventArgs e)
        {
            if (panelTeam.Visible)
            {
                panelTeam.Hide();
            }
            else
            {
                panelTeam.Show();
                btnTeam.Enabled = false;
                btnResult.Enabled = true;
                btnReport.Enabled = true;
                btnRank.Enabled = true;
                GiaoDienQuanLyDoiBong();
            }
        }
        void GiaoDienQuanLyDoiBong()
        {
            LoadTeam();
            loadTeamBlinding();
            dgvTeam.Columns["Lop"].Width = 230;
            dgvTeam.Columns["Mssv"].Width = 244;
            dgvTeam.Columns["Ten"].Width = 255;
            dgvTeam.Columns["Lop"].HeaderText = "Lớp";
            dgvTeam.Columns["Mssv"].HeaderText = "Mã Số Sinh Viên";
            dgvTeam.Columns["Ten"].HeaderText = "Họ Tên";             
        }

        //Xử lý combobox Lớp
        private void CbbTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = "";

            ComboBox cb = sender as ComboBox;

            if (cb.SelectedItem == null)
                return;

            Doi selected = cb.SelectedItem as Doi;
            id = selected.Lop;
            txbID.DataBindings.Clear();
            txbName.DataBindings.Clear();
            txbTeamName.DataBindings.Clear();

            LoadListThanhVienByLop(id);
            AddTeamBlinding();
        }
        //Xử lý DatagridView
        void LoadTeam()
        {
            List<Doi> listCategory = DoiDAO.Instance.GetDoi();
            cbbTeam.DataSource = listCategory;
            cbbTeam.DisplayMember = "Lop";
        }
        void LoadListMember()
        {
            teamList.DataSource = ThanhVienDAO.Instance.GetListThanhVien();
        }
        void LoadListThanhVienByLop(string lop)
        {
            dgvTeam.DataSource = ThanhVienDAO.Instance.GetThanhVienByDoi(lop);
        }
        //Datablinding
        void AddTeamBlinding()
        {
            txbID.DataBindings.Add(new Binding("Text", dgvTeam.DataSource, "Mssv", true, DataSourceUpdateMode.Never));
            txbName.DataBindings.Add(new Binding("Text", dgvTeam.DataSource, "Ten", true, DataSourceUpdateMode.Never));
            txbTeamName.DataBindings.Add(new Binding("Text", dgvTeam.DataSource, "Lop", true, DataSourceUpdateMode.Never));
        }
        void loadTeamBlinding()
        {
            txbTeam.DataBindings.Add(new Binding("Text", cbbTeam.DataSource, "Lop"));
        }
        //Thêm lớp
        private void BtnAddTeam_Click(object sender, EventArgs e)
        {
            string name = txbTeam.Text;
            if (DoiDAO.Instance.CheckLop(name))
            {
                if (name == null || name.Length < 8)
                {
                    MessageBox.Show("Có lỗi khi thêm Team");
                }
                else
                {
                    if (DoiDAO.Instance.InsertTeam(name))
                    {
                        MessageBox.Show("Thêm team thành công");
                        LoadTeam();
                        if (insertTeam != null)
                            insertTeam(this, new EventArgs());
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi khi thêm Team");
                    }
                }
            }
            else
            {
                MessageBox.Show("Lớp đã tồn tại");
            }
        }
        private event EventHandler insertTeam;
        public event EventHandler InsertTeam
        {
            add { insertTeam += value; }
            remove { insertTeam -= value; }
        }
        //Thêm thành viên
        private void BtnCreateMember_Click(object sender, EventArgs e)
        {
            string mssv = txbID.Text;
            string ten = txbName.Text;
            string lop = txbTeam.Text;
            if (ThanhVienDAO.Instance.CheckThanhVien(mssv))
            {
                if (ThanhVienDAO.Instance.InsertMembers(mssv, ten, lop))
                {
                    MessageBox.Show("Thêm thành viên thành công");
                    LoadTeam();
                    if (insertMembers != null)
                        insertMembers(this, new EventArgs());
                }
                else
                {
                    MessageBox.Show("Có lỗi khi thêm thành viên");
                }
            }
            else
            {
                MessageBox.Show("Thành viên đã tồn tại");
            }
        }
        private event EventHandler insertMembers;
        public event EventHandler InsertMembers
        {
            add { insertMembers += value; }
            remove { insertMembers -= value; }
        }
        //Xóa thành viên
        private void BtnDeleteMember_Click(object sender, EventArgs e)
        {
            string mssv = txbID.Text;
            if (ThanhVienDAO.Instance.DeleteMembers(mssv))
            {
                MessageBox.Show("Xóa thành công");
                LoadTeam();
                if (deleteMembers != null)
                    deleteMembers(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi Xóa");
            }
        }
        private event EventHandler deleteMembers;
        public event EventHandler DeleteMembers
        {
            add { deleteMembers += value; }
            remove { deleteMembers -= value; }
        }
        //Cập nhật thành viên
        private void BtnUpdateMember_Click(object sender, EventArgs e)
        {
            string mssv = txbID.Text;
            string ten = txbName.Text;
            string lop = txbTeamName.Text;
            if (ThanhVienDAO.Instance.UpdateMembers(mssv, ten, lop))
            {
                MessageBox.Show("Sữa thành công");
                LoadTeam();
                if (updateMembers != null)
                    updateMembers(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi Sữa");
            }
        }
        private event EventHandler updateMembers;
        public event EventHandler UpdateMembers
        {
            add { updateMembers += value; }
            remove { updateMembers -= value; }
        }
        #endregion

        #region LichThiDau-KetQua
        private void BtnResult_Click(object sender, EventArgs e)
        {
            ResultForm f = new ResultForm();
            this.Hide();
            f.ShowDialog();
            f.Hide();
        }
        #endregion
        private void BtnRank_Click(object sender, EventArgs e)
        {
            FormRank f = new FormRank();           
            this.Hide();
            f.ShowDialog();
            f.Hide();
        }
        private void BtnX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnReport_Click(object sender, EventArgs e)
        {
            FormReport f = new FormReport();
            this.Hide();
            f.ShowDialog();
            f.Hide();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void PanelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {

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
