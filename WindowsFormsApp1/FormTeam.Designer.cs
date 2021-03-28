namespace WindowsFormsApp1
{
    partial class FormTeam
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTeam));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnTeam = new System.Windows.Forms.Button();
            this.btnRank = new System.Windows.Forms.Button();
            this.btnResult = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnX = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelTeam = new System.Windows.Forms.Panel();
            this.dgvTeam = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnUpdateMember = new System.Windows.Forms.Button();
            this.btnDeleteMember = new System.Windows.Forms.Button();
            this.btnCreateMember = new System.Windows.Forms.Button();
            this.txbTeamName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txbName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txbID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbTeam = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAddTeam = new System.Windows.Forms.Button();
            this.cbbTeam = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelTeam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeam)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.btnReport);
            this.panelMenu.Controls.Add(this.btnTeam);
            this.panelMenu.Controls.Add(this.btnRank);
            this.panelMenu.Controls.Add(this.btnResult);
            this.panelMenu.Controls.Add(this.pictureBox1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(244, 529);
            this.panelMenu.TabIndex = 0;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelMenu_Paint);
            // 
            // btnReport
            // 
            this.btnReport.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.ForeColor = System.Drawing.Color.Gray;
            this.btnReport.Location = new System.Drawing.Point(0, 374);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(240, 67);
            this.btnReport.TabIndex = 5;
            this.btnReport.Text = "Report";
            this.btnReport.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.BtnReport_Click);
            // 
            // btnTeam
            // 
            this.btnTeam.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeam.ForeColor = System.Drawing.Color.Gray;
            this.btnTeam.Location = new System.Drawing.Point(-1, 301);
            this.btnTeam.Name = "btnTeam";
            this.btnTeam.Size = new System.Drawing.Size(240, 67);
            this.btnTeam.TabIndex = 4;
            this.btnTeam.Text = "Quản Lý Đội Bóng";
            this.btnTeam.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnTeam.UseVisualStyleBackColor = true;
            this.btnTeam.Click += new System.EventHandler(this.BtnTeam_Click);
            // 
            // btnRank
            // 
            this.btnRank.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRank.ForeColor = System.Drawing.Color.Gray;
            this.btnRank.Location = new System.Drawing.Point(0, 228);
            this.btnRank.Name = "btnRank";
            this.btnRank.Size = new System.Drawing.Size(240, 67);
            this.btnRank.TabIndex = 3;
            this.btnRank.Text = "Bảng Xếp Hạng";
            this.btnRank.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnRank.UseVisualStyleBackColor = true;
            this.btnRank.Click += new System.EventHandler(this.BtnRank_Click);
            // 
            // btnResult
            // 
            this.btnResult.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResult.ForeColor = System.Drawing.Color.Gray;
            this.btnResult.Location = new System.Drawing.Point(0, 155);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(240, 67);
            this.btnResult.TabIndex = 2;
            this.btnResult.Text = "Quản Lý Vòng Đấu";
            this.btnResult.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.BtnResult_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(239, 149);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Purple;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(899, 84);
            this.panel3.TabIndex = 0;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel3_Paint);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(0)))), ((int)(((byte)(85)))));
            this.panel4.Controls.Add(this.btnLogOut);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.btnX);
            this.panel4.Controls.Add(this.btnMenu);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(899, 39);
            this.panel4.TabIndex = 1;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel4_Paint);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Purple;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogOut.Location = new System.Drawing.Point(993, 4);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(83, 33);
            this.btnLogOut.TabIndex = 5;
            this.btnLogOut.Text = "Đăng xuất";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.BtnLogOut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Phần mềm quản lý giải bóng đá khoa CNTT";
            // 
            // btnX
            // 
            this.btnX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(0)))), ((int)(((byte)(85)))));
            this.btnX.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnX.Location = new System.Drawing.Point(848, 0);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(51, 39);
            this.btnX.TabIndex = 1;
            this.btnX.Text = "X";
            this.btnX.UseVisualStyleBackColor = false;
            this.btnX.Click += new System.EventHandler(this.BtnX_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(0)))), ((int)(((byte)(85)))));
            this.btnMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.Location = new System.Drawing.Point(0, 0);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(91, 38);
            this.btnMenu.TabIndex = 0;
            this.btnMenu.Text = "MENU";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panelTeam);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Location = new System.Drawing.Point(244, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(899, 529);
            this.panel2.TabIndex = 1;
            // 
            // panelTeam
            // 
            this.panelTeam.Controls.Add(this.dgvTeam);
            this.panelTeam.Controls.Add(this.label11);
            this.panelTeam.Controls.Add(this.label10);
            this.panelTeam.Controls.Add(this.btnUpdateMember);
            this.panelTeam.Controls.Add(this.btnDeleteMember);
            this.panelTeam.Controls.Add(this.btnCreateMember);
            this.panelTeam.Controls.Add(this.txbTeamName);
            this.panelTeam.Controls.Add(this.label9);
            this.panelTeam.Controls.Add(this.txbName);
            this.panelTeam.Controls.Add(this.label8);
            this.panelTeam.Controls.Add(this.txbID);
            this.panelTeam.Controls.Add(this.label7);
            this.panelTeam.Controls.Add(this.txbTeam);
            this.panelTeam.Controls.Add(this.label6);
            this.panelTeam.Controls.Add(this.btnAddTeam);
            this.panelTeam.Controls.Add(this.cbbTeam);
            this.panelTeam.Controls.Add(this.label5);
            this.panelTeam.Controls.Add(this.label4);
            this.panelTeam.Controls.Add(this.label3);
            this.panelTeam.Controls.Add(this.label2);
            this.panelTeam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTeam.Location = new System.Drawing.Point(0, 84);
            this.panelTeam.Name = "panelTeam";
            this.panelTeam.Size = new System.Drawing.Size(899, 445);
            this.panelTeam.TabIndex = 1;
            // 
            // dgvTeam
            // 
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvTeam.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTeam.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvTeam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeam.Location = new System.Drawing.Point(385, 53);
            this.dgvTeam.Name = "dgvTeam";
            this.dgvTeam.RowHeadersWidth = 51;
            this.dgvTeam.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTeam.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvTeam.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvTeam.Size = new System.Drawing.Size(763, 419);
            this.dgvTeam.TabIndex = 28;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Blue;
            this.label11.Location = new System.Drawing.Point(13, 189);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 25);
            this.label11.TabIndex = 27;
            this.label11.Text = "CẦU THỦ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(3, 168);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(363, 20);
            this.label10.TabIndex = 26;
            this.label10.Text = "-----------------------------------------------------------";
            // 
            // btnUpdateMember
            // 
            this.btnUpdateMember.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateMember.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnUpdateMember.Location = new System.Drawing.Point(240, 406);
            this.btnUpdateMember.Name = "btnUpdateMember";
            this.btnUpdateMember.Size = new System.Drawing.Size(110, 42);
            this.btnUpdateMember.TabIndex = 25;
            this.btnUpdateMember.Text = "Cập Nhật";
            this.btnUpdateMember.UseVisualStyleBackColor = true;
            this.btnUpdateMember.Click += new System.EventHandler(this.BtnUpdateMember_Click);
            // 
            // btnDeleteMember
            // 
            this.btnDeleteMember.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteMember.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDeleteMember.Location = new System.Drawing.Point(127, 406);
            this.btnDeleteMember.Name = "btnDeleteMember";
            this.btnDeleteMember.Size = new System.Drawing.Size(110, 42);
            this.btnDeleteMember.TabIndex = 24;
            this.btnDeleteMember.Text = "Xóa";
            this.btnDeleteMember.UseVisualStyleBackColor = true;
            this.btnDeleteMember.Click += new System.EventHandler(this.BtnDeleteMember_Click);
            // 
            // btnCreateMember
            // 
            this.btnCreateMember.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateMember.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCreateMember.Location = new System.Drawing.Point(11, 406);
            this.btnCreateMember.Name = "btnCreateMember";
            this.btnCreateMember.Size = new System.Drawing.Size(110, 42);
            this.btnCreateMember.TabIndex = 23;
            this.btnCreateMember.Text = "Thêm";
            this.btnCreateMember.UseVisualStyleBackColor = true;
            this.btnCreateMember.Click += new System.EventHandler(this.BtnCreateMember_Click);
            // 
            // txbTeamName
            // 
            this.txbTeamName.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTeamName.Location = new System.Drawing.Point(70, 349);
            this.txbTeamName.Name = "txbTeamName";
            this.txbTeamName.Size = new System.Drawing.Size(259, 33);
            this.txbTeamName.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(6, 352);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 25);
            this.label9.TabIndex = 21;
            this.label9.Text = "LỚP";
            // 
            // txbName
            // 
            this.txbName.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbName.Location = new System.Drawing.Point(70, 290);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(259, 33);
            this.txbName.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(6, 293);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 25);
            this.label8.TabIndex = 19;
            this.label8.Text = "TÊN";
            // 
            // txbID
            // 
            this.txbID.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbID.Location = new System.Drawing.Point(70, 232);
            this.txbID.Name = "txbID";
            this.txbID.Size = new System.Drawing.Size(259, 33);
            this.txbID.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(6, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 25);
            this.label7.TabIndex = 17;
            this.label7.Text = "MSSV";
            // 
            // txbTeam
            // 
            this.txbTeam.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTeam.Location = new System.Drawing.Point(70, 68);
            this.txbTeam.Name = "txbTeam";
            this.txbTeam.Size = new System.Drawing.Size(259, 33);
            this.txbTeam.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(6, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "LỚP";
            // 
            // btnAddTeam
            // 
            this.btnAddTeam.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTeam.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddTeam.Location = new System.Drawing.Point(70, 107);
            this.btnAddTeam.Name = "btnAddTeam";
            this.btnAddTeam.Size = new System.Drawing.Size(110, 42);
            this.btnAddTeam.TabIndex = 10;
            this.btnAddTeam.Text = "Thêm Đội";
            this.btnAddTeam.UseVisualStyleBackColor = true;
            this.btnAddTeam.Click += new System.EventHandler(this.BtnAddTeam_Click);
            // 
            // cbbTeam
            // 
            this.cbbTeam.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTeam.FormattingEnabled = true;
            this.cbbTeam.Location = new System.Drawing.Point(110, 7);
            this.cbbTeam.Name = "cbbTeam";
            this.cbbTeam.Size = new System.Drawing.Size(219, 33);
            this.cbbTeam.TabIndex = 9;
            this.cbbTeam.SelectedIndexChanged += new System.EventHandler(this.CbbTeam_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(2, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(363, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "-----------------------------------------------------------";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(2, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "ĐỘI BÓNG";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(419, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(297, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "------------------------------------------------";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(457, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "DANH SÁCH CẦU THỦ";
            // 
            // FormTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1143, 529);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormTeam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panelTeam.ResumeLayout(false);
            this.panelTeam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeam)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnTeam;
        private System.Windows.Forms.Button btnRank;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelTeam;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnUpdateMember;
        private System.Windows.Forms.Button btnDeleteMember;
        private System.Windows.Forms.Button btnCreateMember;
        private System.Windows.Forms.TextBox txbTeamName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbTeam;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAddTeam;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvTeam;
        private System.Windows.Forms.ComboBox cbbTeam;
        private System.Windows.Forms.Button btnLogOut;
    }
}

