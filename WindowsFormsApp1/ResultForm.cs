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
    public partial class ResultForm : Form
    {
        int check = 0;
        int id = 1;
        int sobanThangYeuCau;
        public ResultForm()
        {
            InitializeComponent();
            DisplayApp();
            LoadVongDau();
            if (ChiTietVongDauDAO.Instance.CheckVongDau(id))
            {
                btnXepLich.Enabled = true;
            }
            else
            {
                btnXepLich.Enabled = false;
            }
            panelTeamDB.Hide();
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
            btnResult.Enabled = false;
            panelThemVongDau.Hide();
            panelMenu.Hide();
            panelResult.Hide();
        }
        private void cbbVongDau_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id;

            ComboBox cb = sender as ComboBox;

            if (cb.SelectedItem == null)
                return;

            VongDau selected = cb.SelectedItem as VongDau;
            id = selected.Mavongdau;
            LoadCTVD(id);
        }
        void LoadCTVD(int mavongdau)
        {
            dtgvLichThiDauKetQua.DataSource = ChiTietVongDauDAO.Instance.GetInforByVongDau(mavongdau);
            if (check > 0)
            {
                dtgvLichThiDauKetQua.Columns["mavongdau"].Width = 154;
                dtgvLichThiDauKetQua.Columns["doi1"].Width = 154;
                dtgvLichThiDauKetQua.Columns["doi2"].Width = 154;
                dtgvLichThiDauKetQua.Columns["tyso"].Width = 154;
                dtgvLichThiDauKetQua.Columns["doithang"].Width = 154;
                dtgvLichThiDauKetQua.Columns["san"].Width = 154;
                dtgvLichThiDauKetQua.Columns["thoigian"].Width = 156;
                dtgvLichThiDauKetQua.Columns["mavongdau"].HeaderText = "Mã Vòng";
                dtgvLichThiDauKetQua.Columns["doi1"].HeaderText = "Đội 1";
                dtgvLichThiDauKetQua.Columns["doi2"].HeaderText = "Đội 2";
                dtgvLichThiDauKetQua.Columns["tyso"].HeaderText = "Tỷ Số";
                dtgvLichThiDauKetQua.Columns["doithang"].HeaderText = "Đội Thắng";
                dtgvLichThiDauKetQua.Columns["san"].HeaderText = "Sân Đấu";
                dtgvLichThiDauKetQua.Columns["thoigian"].HeaderText = "Thời Gian";
            }
            else
            {

            }
        }
        void LoadVongDau()
        {
            List<VongDau> listCategory = VongDauDAO.Instance.GetListVongDau();
            cbbVongDau.DataSource = listCategory;
            cbbVongDau.DisplayMember = "Tenvongdau";
        }
        private void btnRank_Click(object sender, EventArgs e)
        {
            FormRank f = new FormRank();
            this.Hide();
            f.ShowDialog();
            f.Hide();
        }

        private void btnTeam_Click(object sender, EventArgs e)
        {
            
            FormTeam f = new FormTeam();
            this.Hide();
            f.ShowDialog();
            f.Hide();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            FormReport f = new FormReport();
            this.Hide();
            f.ShowDialog();
            f.Hide();
        }
        private void btnMenu_Click(object sender, EventArgs e)
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

        private void btnX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }




        private event EventHandler insertVongDau;
        public event EventHandler InsertVongDau
        {
            add { insertVongDau += value; }
            remove { insertVongDau -= value; }
        }



        
        private event EventHandler insertChiTietVongDau;
        public event EventHandler InsertChiTietVongDau
        {
            add { insertChiTietVongDau += value; }
            remove { insertChiTietVongDau -= value; }
        }

        private void BtnThemVongDau_Click_1(object sender, EventArgs e)
        {
            panelThemVongDau.Show();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            string vongDau = txbTenVongDau.Text;
            if (txbSoBanThangYeuCau.Text == "")
            {
                MessageBox.Show("Yêu cầu nhập số bàn thắng !");
                panelThemVongDau.Hide();
            }
            else
            {
                panelThemVongDau.Hide();
                int soBanThangYeuCau = Int32.Parse(txbSoBanThangYeuCau.Text);
                if (VongDauDAO.Instance.InsertVongDau(vongDau, soBanThangYeuCau))
                {
                    MessageBox.Show("Thêm vòng đấu thành công");
                    LoadVongDau();
                    if (insertVongDau != null)
                        insertVongDau(this, new EventArgs());
                }
                else
                {
                    MessageBox.Show("Có lỗi khi thêm vòng đấu");
                }
            }
        }

        private void CbbVongDau_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            

            ComboBox cb = sender as ComboBox;

            if (cb.SelectedItem == null)
                return;

            VongDau selected = cb.SelectedItem as VongDau;
            id = selected.Mavongdau;
            if(id != null)
            {
                check++;
            }
            if (ChiTietVongDauDAO.Instance.CheckVongDau(id))
            {
                btnXepLich.Enabled = true;
            }
            else
            {
                btnXepLich.Enabled = false;
            }
            if (DoiDacBietDAO.Instance.CheckDoiDacBiet(id))
            {
                panelTeamDB.Show();
                txbTemDB.Text = DoiDacBietDAO.Instance.GetDoiDacBiet(id);
            }
            else
            {
                panelTeamDB.Hide();
            }
            LoadCTVD(id);
        }

        private void BtnXepLich_Click_1(object sender, EventArgs e)
        {
            List<string> listDoi1 = new List<string>();
            List<string> listDoi2 = new List<string>();
            string query0 = string.Format("select diem from vongdau where mavongdau = {0}",id);
            int diem = (int)DataProvider.Instance.ExecuteScalar(query0);
            
            string query = string.Format("select count(*) from doi where diem >= {0}", diem);
            int n = (int)DataProvider.Instance.ExecuteScalar(query);
            if (n < 2)
            {
                MessageBox.Show("Không có team nào ");
                return;
            }
            int m = 0;
            //Số team là chẵn
            if (n % 2 == 0)
            {
                m = n / 2;
                while (listDoi1.Count < m)
                {
                    string query1 = string.Format("SELECT TOP 1 lop from doi where diem >= {0} ORDER BY NEWID()", diem);
                    string result1 = (string)DataProvider.Instance.ExecuteScalar(query1);
                    if (listDoi1.Contains(result1))
                    {
                        ;
                    }
                    else
                    {
                        listDoi1.Add(result1);
                    }

                }
                while (listDoi2.Count < m)
                {
                    string query2 = string.Format("SELECT TOP 1 lop from doi where diem >= {0} ORDER BY NEWID()", diem);
                    string result2 = (string)DataProvider.Instance.ExecuteScalar(query2);
                    if (listDoi2.Contains(result2))
                    {
                        ;
                    }
                    else
                    {
                        if (listDoi1.Contains(result2))
                        {
                            ;
                        }
                        else
                        {
                            listDoi2.Add(result2);
                        }
                    }

                }
            }
            //Số team lẻ
            else
            {
                m = (n + 1) / 2;
                while (listDoi1.Count < m)
                {
                    string query1 = string.Format("SELECT TOP 1 lop from doi where diem >= {0} ORDER BY NEWID()", diem);
                    string result1 = (string)DataProvider.Instance.ExecuteScalar(query1);
                    if (listDoi1.Contains(result1))
                    {
                        ;
                    }
                    else
                    {
                        listDoi1.Add(result1);
                    }

                }
                while (listDoi2.Count < m-1)
                {
                    string query2 = string.Format("SELECT TOP 1 lop from doi where diem >= {0} ORDER BY NEWID()", diem);
                    string result2 = (string)DataProvider.Instance.ExecuteScalar(query2);
                    if (listDoi2.Contains(result2))
                    {
                        ;
                    }
                    else
                    {
                        if (listDoi1.Contains(result2))
                        {
                            ;
                        }
                        else
                        {
                            if (listDoi2.Count == m - 1)
                            {
                                listDoi2.Add("");
                                break;
                            }
                            else
                            {

                                listDoi2.Add(result2);
                            }
                        }
                    }

                }
            }
            if (n % 2 != 0)
            {
                for (int i = 0; i < m - 1; i++)
                {
                    if (ChiTietVongDauDAO.Instance.InsertChiTietVongDau(id, listDoi1[i], listDoi2[i]))
                    {
                        if (insertChiTietVongDau != null)
                            insertChiTietVongDau(this, new EventArgs());
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi khi thêm vòng đấu");
                    }
                }
            }
            else
            {
                for (int i = 0; i < m - 1 ; i++)
                {
                    if (ChiTietVongDauDAO.Instance.InsertChiTietVongDau(id, listDoi1[i], listDoi2[i]))
                    {
                        if (insertChiTietVongDau != null)
                            insertChiTietVongDau(this, new EventArgs());
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi khi thêm vòng đấu");
                    }
                }
                panelTeamDB.Show();
                txbTemDB.Text = listDoi1[m - 1];
                if (DoiDacBietDAO.Instance.InsertDoiDacBiet(id, txbTemDB.Text))
                {
                    ;
                }
            }
           
            if (ChiTietVongDauDAO.Instance.CheckVongDau(id))
            {
                btnXepLich.Enabled = true;
            }
            else
            {
                btnXepLich.Enabled = false;
            }
            LoadCTVD(id);
        }

        private void BtnCapNhat_Click(object sender, EventArgs e)
        {
            panelResult.Show();
            txbDoi1.DataBindings.Clear();
            txbDoi2.DataBindings.Clear();
            txbSan.DataBindings.Clear();
            txbTS.DataBindings.Clear();
            dtP.DataBindings.Clear();
            AddTeamBlinding();
            
        }

        void CapNhatKetQua()
        {
            string doi1 = txbDoi1.Text;
            string doi2 = txbDoi2.Text;
            string san = txbSan.Text;
            string ts = txbTS.Text;
            string[] t = ts.Split(new string[] { ":" }, StringSplitOptions.None);
            int tsDoi1 = Int32.Parse(t[0]);
            int tsDoi2 = Int32.Parse(t[1]);
            int soVongThangDoi1 = DoiDAO.Instance.getSoVongThang(doi1);
            int soVongThangDoi2 = DoiDAO.Instance.getSoVongThang(doi2);
            int diemDoi1 = DoiDAO.Instance.getDiem(doi1);
            int diemDoi2 = DoiDAO.Instance.getDiem(doi2);
            string doithang;
            if (tsDoi1 == tsDoi2)
            {
                doithang = "Hòa";
                if (DoiDAO.Instance.UpdateDoi(doi1,diemDoi1+1,soVongThangDoi1))
                {
                    ;
                }
                if (DoiDAO.Instance.UpdateDoi(doi2, diemDoi2 + 1, soVongThangDoi2))
                {
                    ;
                }
            }
            else
            {
                if (tsDoi1 > tsDoi2)
                {
                    doithang = doi1;
                    if (DoiDAO.Instance.UpdateDoi(doi1, diemDoi1 + 3, soVongThangDoi1+1))
                    {
                        ;
                    }
                }
                else
                {
                    doithang = doi2;
                    if (DoiDAO.Instance.UpdateDoi(doi2, diemDoi2 + 3, soVongThangDoi2+1))
                    {
                        ;
                    }
                }
            }
            DateTime tg = dtP.Value;
            if (ChiTietVongDauDAO.Instance.UpdateCTVD(id, doi1, doi2,ts,doithang,san,tg))
            {
                MessageBox.Show("Sửa thành công");
                LoadCTVD(id);
                if (updateCTVD != null)
                    updateCTVD(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi Sửa");
            }
        }
        void AddTeamBlinding()
        {
            txbDoi1.DataBindings.Add(new Binding("Text", dtgvLichThiDauKetQua.DataSource, "doi1", true));
            txbDoi2.DataBindings.Add(new Binding("Text", dtgvLichThiDauKetQua.DataSource, "doi2", true));
            txbSan.DataBindings.Add(new Binding("Text", dtgvLichThiDauKetQua.DataSource, "san", true));
            txbTS.DataBindings.Add(new Binding("Text", dtgvLichThiDauKetQua.DataSource, "tyso", true));
            dtP.DataBindings.Add(new Binding("Value", dtgvLichThiDauKetQua.DataSource, "tyso", true));
        }
        private event EventHandler updateCTVD;
        public event EventHandler UpdateCTVD
        {
            add { updateCTVD += value; }
            remove { updateCTVD -= value; }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            CapNhatKetQua();
            panelResult.Hide();
        }

        private void DtgvLichThiDauKetQua_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnResult_Click(object sender, EventArgs e)
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
