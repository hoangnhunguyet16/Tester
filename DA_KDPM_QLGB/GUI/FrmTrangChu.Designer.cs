namespace GUI
{
    partial class FrmTrangChu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTrangChu));
            this.pnlSideMenu = new System.Windows.Forms.Panel();
            this.pnlHeThongSubMenu = new System.Windows.Forms.Panel();
            this.btnTaiKhoan = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.btnBackup = new System.Windows.Forms.Button();
            this.btnHeThong = new System.Windows.Forms.Button();
            this.pnlChucNangSubMenu = new System.Windows.Forms.Panel();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnDatBao = new System.Windows.Forms.Button();
            this.btnChucNang = new System.Windows.Forms.Button();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.pnlQuanLySubMenu = new System.Windows.Forms.Panel();
            this.btnKhachHang = new System.Windows.Forms.Button();
            this.btnNhanVien = new System.Windows.Forms.Button();
            this.btnLoaiBao = new System.Windows.Forms.Button();
            this.btnQuanLy = new System.Windows.Forms.Button();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblTaiKhoan = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlSideMenu.SuspendLayout();
            this.pnlHeThongSubMenu.SuspendLayout();
            this.pnlChucNangSubMenu.SuspendLayout();
            this.pnlQuanLySubMenu.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSideMenu
            // 
            this.pnlSideMenu.AutoScroll = true;
            this.pnlSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(50)))), ((int)(((byte)(51)))));
            this.pnlSideMenu.Controls.Add(this.pnlHeThongSubMenu);
            this.pnlSideMenu.Controls.Add(this.btnHeThong);
            this.pnlSideMenu.Controls.Add(this.pnlChucNangSubMenu);
            this.pnlSideMenu.Controls.Add(this.btnChucNang);
            this.pnlSideMenu.Controls.Add(this.btnDangXuat);
            this.pnlSideMenu.Controls.Add(this.pnlQuanLySubMenu);
            this.pnlSideMenu.Controls.Add(this.btnQuanLy);
            this.pnlSideMenu.Controls.Add(this.pnlLogo);
            this.pnlSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSideMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlSideMenu.Name = "pnlSideMenu";
            this.pnlSideMenu.Size = new System.Drawing.Size(250, 681);
            this.pnlSideMenu.TabIndex = 3;
            // 
            // pnlHeThongSubMenu
            // 
            this.pnlHeThongSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(76)))), ((int)(((byte)(80)))));
            this.pnlHeThongSubMenu.Controls.Add(this.btnTaiKhoan);
            this.pnlHeThongSubMenu.Controls.Add(this.btnRestore);
            this.pnlHeThongSubMenu.Controls.Add(this.btnBackup);
            this.pnlHeThongSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeThongSubMenu.Location = new System.Drawing.Point(0, 435);
            this.pnlHeThongSubMenu.Name = "pnlHeThongSubMenu";
            this.pnlHeThongSubMenu.Size = new System.Drawing.Size(250, 120);
            this.pnlHeThongSubMenu.TabIndex = 11;
            // 
            // btnTaiKhoan
            // 
            this.btnTaiKhoan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTaiKhoan.FlatAppearance.BorderSize = 0;
            this.btnTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaiKhoan.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnTaiKhoan.Image = ((System.Drawing.Image)(resources.GetObject("btnTaiKhoan.Image")));
            this.btnTaiKhoan.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTaiKhoan.Location = new System.Drawing.Point(0, 80);
            this.btnTaiKhoan.Name = "btnTaiKhoan";
            this.btnTaiKhoan.Padding = new System.Windows.Forms.Padding(35, 0, 27, 0);
            this.btnTaiKhoan.Size = new System.Drawing.Size(250, 40);
            this.btnTaiKhoan.TabIndex = 2;
            this.btnTaiKhoan.Text = "Tài khoản";
            this.btnTaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaiKhoan.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnTaiKhoan.UseVisualStyleBackColor = true;
            this.btnTaiKhoan.Click += new System.EventHandler(this.btnTaiKhoan_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRestore.FlatAppearance.BorderSize = 0;
            this.btnRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestore.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnRestore.Image = ((System.Drawing.Image)(resources.GetObject("btnRestore.Image")));
            this.btnRestore.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRestore.Location = new System.Drawing.Point(0, 40);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Padding = new System.Windows.Forms.Padding(35, 0, 27, 0);
            this.btnRestore.Size = new System.Drawing.Size(250, 40);
            this.btnRestore.TabIndex = 1;
            this.btnRestore.Text = "Restore";
            this.btnRestore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRestore.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // btnBackup
            // 
            this.btnBackup.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBackup.FlatAppearance.BorderSize = 0;
            this.btnBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackup.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnBackup.Image = ((System.Drawing.Image)(resources.GetObject("btnBackup.Image")));
            this.btnBackup.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBackup.Location = new System.Drawing.Point(0, 0);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Padding = new System.Windows.Forms.Padding(35, 0, 27, 0);
            this.btnBackup.Size = new System.Drawing.Size(250, 40);
            this.btnBackup.TabIndex = 0;
            this.btnBackup.Text = "Backup";
            this.btnBackup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBackup.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // btnHeThong
            // 
            this.btnHeThong.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHeThong.FlatAppearance.BorderSize = 0;
            this.btnHeThong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHeThong.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnHeThong.Image = ((System.Drawing.Image)(resources.GetObject("btnHeThong.Image")));
            this.btnHeThong.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHeThong.Location = new System.Drawing.Point(0, 390);
            this.btnHeThong.Name = "btnHeThong";
            this.btnHeThong.Padding = new System.Windows.Forms.Padding(10, 0, 25, 0);
            this.btnHeThong.Size = new System.Drawing.Size(250, 45);
            this.btnHeThong.TabIndex = 10;
            this.btnHeThong.Text = "Hệ thống";
            this.btnHeThong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHeThong.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnHeThong.UseVisualStyleBackColor = true;
            this.btnHeThong.Click += new System.EventHandler(this.btnHeThong_Click);
            // 
            // pnlChucNangSubMenu
            // 
            this.pnlChucNangSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(76)))), ((int)(((byte)(80)))));
            this.pnlChucNangSubMenu.Controls.Add(this.btnThongKe);
            this.pnlChucNangSubMenu.Controls.Add(this.btnDatBao);
            this.pnlChucNangSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlChucNangSubMenu.Location = new System.Drawing.Point(0, 310);
            this.pnlChucNangSubMenu.Name = "pnlChucNangSubMenu";
            this.pnlChucNangSubMenu.Size = new System.Drawing.Size(250, 80);
            this.pnlChucNangSubMenu.TabIndex = 9;
            // 
            // btnThongKe
            // 
            this.btnThongKe.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThongKe.FlatAppearance.BorderSize = 0;
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKe.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnThongKe.Image = ((System.Drawing.Image)(resources.GetObject("btnThongKe.Image")));
            this.btnThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThongKe.Location = new System.Drawing.Point(0, 40);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Padding = new System.Windows.Forms.Padding(35, 0, 23, 0);
            this.btnThongKe.Size = new System.Drawing.Size(250, 40);
            this.btnThongKe.TabIndex = 1;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKe.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnDatBao
            // 
            this.btnDatBao.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDatBao.FlatAppearance.BorderSize = 0;
            this.btnDatBao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatBao.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDatBao.Image = ((System.Drawing.Image)(resources.GetObject("btnDatBao.Image")));
            this.btnDatBao.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDatBao.Location = new System.Drawing.Point(0, 0);
            this.btnDatBao.Name = "btnDatBao";
            this.btnDatBao.Padding = new System.Windows.Forms.Padding(35, 0, 27, 0);
            this.btnDatBao.Size = new System.Drawing.Size(250, 40);
            this.btnDatBao.TabIndex = 0;
            this.btnDatBao.Text = "Đặt báo";
            this.btnDatBao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDatBao.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDatBao.UseVisualStyleBackColor = true;
            this.btnDatBao.Click += new System.EventHandler(this.btnDatBao_Click);
            // 
            // btnChucNang
            // 
            this.btnChucNang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChucNang.FlatAppearance.BorderSize = 0;
            this.btnChucNang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChucNang.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnChucNang.Image = ((System.Drawing.Image)(resources.GetObject("btnChucNang.Image")));
            this.btnChucNang.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChucNang.Location = new System.Drawing.Point(0, 265);
            this.btnChucNang.Name = "btnChucNang";
            this.btnChucNang.Padding = new System.Windows.Forms.Padding(10, 0, 25, 0);
            this.btnChucNang.Size = new System.Drawing.Size(250, 45);
            this.btnChucNang.TabIndex = 8;
            this.btnChucNang.Text = "Chức năng";
            this.btnChucNang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChucNang.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnChucNang.UseVisualStyleBackColor = true;
            this.btnChucNang.Click += new System.EventHandler(this.btnChucNang_Click);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDangXuat.FlatAppearance.BorderSize = 0;
            this.btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangXuat.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDangXuat.Image = ((System.Drawing.Image)(resources.GetObject("btnDangXuat.Image")));
            this.btnDangXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDangXuat.Location = new System.Drawing.Point(0, 636);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnDangXuat.Size = new System.Drawing.Size(250, 45);
            this.btnDangXuat.TabIndex = 6;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangXuat.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDangXuat.UseVisualStyleBackColor = true;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // pnlQuanLySubMenu
            // 
            this.pnlQuanLySubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(76)))), ((int)(((byte)(80)))));
            this.pnlQuanLySubMenu.Controls.Add(this.btnKhachHang);
            this.pnlQuanLySubMenu.Controls.Add(this.btnNhanVien);
            this.pnlQuanLySubMenu.Controls.Add(this.btnLoaiBao);
            this.pnlQuanLySubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlQuanLySubMenu.Location = new System.Drawing.Point(0, 145);
            this.pnlQuanLySubMenu.Name = "pnlQuanLySubMenu";
            this.pnlQuanLySubMenu.Size = new System.Drawing.Size(250, 120);
            this.pnlQuanLySubMenu.TabIndex = 5;
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKhachHang.FlatAppearance.BorderSize = 0;
            this.btnKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhachHang.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnKhachHang.Image = ((System.Drawing.Image)(resources.GetObject("btnKhachHang.Image")));
            this.btnKhachHang.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKhachHang.Location = new System.Drawing.Point(0, 80);
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.Padding = new System.Windows.Forms.Padding(35, 0, 23, 0);
            this.btnKhachHang.Size = new System.Drawing.Size(250, 40);
            this.btnKhachHang.TabIndex = 3;
            this.btnKhachHang.Text = "Khách hàng";
            this.btnKhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKhachHang.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnKhachHang.UseVisualStyleBackColor = true;
            this.btnKhachHang.Click += new System.EventHandler(this.btnKhachHang_Click);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNhanVien.FlatAppearance.BorderSize = 0;
            this.btnNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhanVien.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnNhanVien.Image = ((System.Drawing.Image)(resources.GetObject("btnNhanVien.Image")));
            this.btnNhanVien.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNhanVien.Location = new System.Drawing.Point(0, 40);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Padding = new System.Windows.Forms.Padding(35, 0, 23, 0);
            this.btnNhanVien.Size = new System.Drawing.Size(250, 40);
            this.btnNhanVien.TabIndex = 1;
            this.btnNhanVien.Text = "Nhân viên";
            this.btnNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhanVien.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnNhanVien.UseVisualStyleBackColor = true;
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // btnLoaiBao
            // 
            this.btnLoaiBao.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLoaiBao.FlatAppearance.BorderSize = 0;
            this.btnLoaiBao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoaiBao.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnLoaiBao.Image = ((System.Drawing.Image)(resources.GetObject("btnLoaiBao.Image")));
            this.btnLoaiBao.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLoaiBao.Location = new System.Drawing.Point(0, 0);
            this.btnLoaiBao.Name = "btnLoaiBao";
            this.btnLoaiBao.Padding = new System.Windows.Forms.Padding(35, 0, 27, 0);
            this.btnLoaiBao.Size = new System.Drawing.Size(250, 40);
            this.btnLoaiBao.TabIndex = 2;
            this.btnLoaiBao.Text = "Loại báo";
            this.btnLoaiBao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoaiBao.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLoaiBao.UseVisualStyleBackColor = true;
            this.btnLoaiBao.Click += new System.EventHandler(this.btnLoaiBao_Click);
            // 
            // btnQuanLy
            // 
            this.btnQuanLy.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQuanLy.FlatAppearance.BorderSize = 0;
            this.btnQuanLy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLy.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnQuanLy.Image = ((System.Drawing.Image)(resources.GetObject("btnQuanLy.Image")));
            this.btnQuanLy.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQuanLy.Location = new System.Drawing.Point(0, 100);
            this.btnQuanLy.Name = "btnQuanLy";
            this.btnQuanLy.Padding = new System.Windows.Forms.Padding(10, 0, 25, 0);
            this.btnQuanLy.Size = new System.Drawing.Size(250, 45);
            this.btnQuanLy.TabIndex = 4;
            this.btnQuanLy.Text = "Quản lý";
            this.btnQuanLy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLy.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnQuanLy.UseVisualStyleBackColor = true;
            this.btnQuanLy.Click += new System.EventHandler(this.btnQuanLy_Click);
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(50)))), ((int)(((byte)(51)))));
            this.pnlLogo.Controls.Add(this.picLogo);
            this.pnlLogo.Controls.Add(this.lblTaiKhoan);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(250, 100);
            this.pnlLogo.TabIndex = 0;
            // 
            // picLogo
            // 
            this.picLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picLogo.BackgroundImage")));
            this.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picLogo.Location = new System.Drawing.Point(0, 12);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(250, 51);
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // lblTaiKhoan
            // 
            this.lblTaiKhoan.ForeColor = System.Drawing.Color.White;
            this.lblTaiKhoan.Location = new System.Drawing.Point(12, 70);
            this.lblTaiKhoan.Name = "lblTaiKhoan";
            this.lblTaiKhoan.Size = new System.Drawing.Size(232, 20);
            this.lblTaiKhoan.TabIndex = 1;
            this.lblTaiKhoan.Text = "Tài khoản";
            this.lblTaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(250, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1134, 681);
            this.pnlMain.TabIndex = 4;
            // 
            // FrmTrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 681);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlSideMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(1400, 720);
            this.Name = "FrmTrangChu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang chủ";
            this.Load += new System.EventHandler(this.FrmTrangChu_Load);
            this.pnlSideMenu.ResumeLayout(false);
            this.pnlHeThongSubMenu.ResumeLayout(false);
            this.pnlChucNangSubMenu.ResumeLayout(false);
            this.pnlQuanLySubMenu.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSideMenu;
        private System.Windows.Forms.Panel pnlHeThongSubMenu;
        private System.Windows.Forms.Button btnTaiKhoan;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Button btnHeThong;
        private System.Windows.Forms.Panel pnlChucNangSubMenu;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnDatBao;
        private System.Windows.Forms.Button btnChucNang;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Panel pnlQuanLySubMenu;
        private System.Windows.Forms.Button btnNhanVien;
        private System.Windows.Forms.Button btnLoaiBao;
        private System.Windows.Forms.Button btnQuanLy;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblTaiKhoan;
        private System.Windows.Forms.Button btnKhachHang;
        private System.Windows.Forms.Panel pnlMain;



    }
}