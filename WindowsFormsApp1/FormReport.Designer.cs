namespace WindowsFormsApp1
{
    partial class FormReport
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReport));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.chitietvongdauBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qlgbdDataSet = new WindowsFormsApp1.qlgbdDataSet();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnX = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnTeam = new System.Windows.Forms.Button();
            this.btnRank = new System.Windows.Forms.Button();
            this.btnResult = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chitietvongdauTableAdapter = new WindowsFormsApp1.qlgbdDataSetTableAdapters.chitietvongdauTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.chitietvongdauBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlgbdDataSet)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // chitietvongdauBindingSource
            // 
            this.chitietvongdauBindingSource.DataMember = "chitietvongdau";
            this.chitietvongdauBindingSource.DataSource = this.qlgbdDataSet;
            // 
            // qlgbdDataSet
            // 
            this.qlgbdDataSet.DataSetName = "qlgbdDataSet";
            this.qlgbdDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.panel4.Size = new System.Drawing.Size(1143, 39);
            this.panel4.TabIndex = 1;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Purple;
            this.btnLogOut.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogOut.Location = new System.Drawing.Point(1003, 3);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(83, 33);
            this.btnLogOut.TabIndex = 3;
            this.btnLogOut.Text = "Đăng xuất";
            this.btnLogOut.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
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
            this.btnX.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnX.Location = new System.Drawing.Point(1092, 0);
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
            this.btnMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMenu.Location = new System.Drawing.Point(0, 0);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(91, 38);
            this.btnMenu.TabIndex = 0;
            this.btnMenu.Text = "MENU";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Purple;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1143, 84);
            this.panel3.TabIndex = 2;
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.btnReport);
            this.panelMenu.Controls.Add(this.btnTeam);
            this.panelMenu.Controls.Add(this.btnRank);
            this.panelMenu.Controls.Add(this.btnResult);
            this.panelMenu.Controls.Add(this.pictureBox1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 84);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(241, 445);
            this.panelMenu.TabIndex = 4;
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
            this.pictureBox1.Location = new System.Drawing.Point(1, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(239, 149);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // chitietvongdauTableAdapter
            // 
            this.chitietvongdauTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "Quydata";
            reportDataSource2.Value = this.chitietvongdauBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApp1.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(241, 84);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(902, 445);
            this.reportViewer1.TabIndex = 5;
            // 
            // FormReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 529);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormReport";
            this.Load += new System.EventHandler(this.FormReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chitietvongdauBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlgbdDataSet)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnTeam;
        private System.Windows.Forms.Button btnRank;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource chitietvongdauBindingSource;
        private qlgbdDataSet qlgbdDataSet;
        private qlgbdDataSetTableAdapters.chitietvongdauTableAdapter chitietvongdauTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button btnLogOut;
    }
}