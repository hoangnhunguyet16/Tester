namespace GUI
{
    partial class FrmDatBao
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.grbChiTietDB = new System.Windows.Forms.GroupBox();
            this.lsvDLCTDB = new System.Windows.Forms.ListView();
            this.colSTT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLoaiBao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSoKy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSoLuong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colThanhTien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDatBao = new System.Windows.Forms.Button();
            this.lblTongTienThanhToan = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.grbThongTinDB = new System.Windows.Forms.GroupBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.lblLoaiBao = new System.Windows.Forms.Label();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.cmbLoaiBao = new System.Windows.Forms.ComboBox();
            this.lblNgayBatDau = new System.Windows.Forms.Label();
            this.dtpNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.lblNgayKetThuc = new System.Windows.Forms.Label();
            this.dtpNgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.lblKH = new System.Windows.Forms.Label();
            this.cmbKhachHang = new System.Windows.Forms.ComboBox();
            this.grbThongTinKH = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.grbChiTietDB.SuspendLayout();
            this.grbThongTinDB.SuspendLayout();
            this.grbThongTinKH.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(76)))), ((int)(((byte)(80)))));
            this.pnlHeader.Controls.Add(this.lblHeader);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(844, 100);
            this.pnlHeader.TabIndex = 2;
            // 
            // lblHeader
            // 
            this.lblHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblHeader.Location = new System.Drawing.Point(0, 0);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(844, 100);
            this.lblHeader.TabIndex = 13;
            this.lblHeader.Text = "ĐĂNG KÝ ĐẶT BÁO";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlBody
            // 
            this.pnlBody.Controls.Add(this.grbChiTietDB);
            this.pnlBody.Controls.Add(this.grbThongTinDB);
            this.pnlBody.Controls.Add(this.btnXacNhan);
            this.pnlBody.Controls.Add(this.lblKH);
            this.pnlBody.Controls.Add(this.cmbKhachHang);
            this.pnlBody.Controls.Add(this.grbThongTinKH);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 100);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(844, 481);
            this.pnlBody.TabIndex = 3;
            // 
            // grbChiTietDB
            // 
            this.grbChiTietDB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbChiTietDB.Controls.Add(this.lsvDLCTDB);
            this.grbChiTietDB.Controls.Add(this.btnDatBao);
            this.grbChiTietDB.Controls.Add(this.lblTongTienThanhToan);
            this.grbChiTietDB.Controls.Add(this.lblTongTien);
            this.grbChiTietDB.Location = new System.Drawing.Point(12, 254);
            this.grbChiTietDB.Name = "grbChiTietDB";
            this.grbChiTietDB.Size = new System.Drawing.Size(820, 215);
            this.grbChiTietDB.TabIndex = 24;
            this.grbChiTietDB.TabStop = false;
            this.grbChiTietDB.Text = "Chi tiết đặt báo";
            // 
            // lsvDLCTDB
            // 
            this.lsvDLCTDB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsvDLCTDB.BackColor = System.Drawing.Color.Azure;
            this.lsvDLCTDB.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colSTT,
            this.colLoaiBao,
            this.colGia,
            this.colSoKy,
            this.colSoLuong,
            this.colThanhTien});
            this.lsvDLCTDB.FullRowSelect = true;
            this.lsvDLCTDB.GridLines = true;
            this.lsvDLCTDB.Location = new System.Drawing.Point(44, 35);
            this.lsvDLCTDB.MultiSelect = false;
            this.lsvDLCTDB.Name = "lsvDLCTDB";
            this.lsvDLCTDB.Size = new System.Drawing.Size(720, 143);
            this.lsvDLCTDB.TabIndex = 29;
            this.lsvDLCTDB.UseCompatibleStateImageBehavior = false;
            this.lsvDLCTDB.View = System.Windows.Forms.View.Details;
            // 
            // colSTT
            // 
            this.colSTT.Text = "STT";
            // 
            // colLoaiBao
            // 
            this.colLoaiBao.Text = "Loại báo";
            this.colLoaiBao.Width = 200;
            // 
            // colGia
            // 
            this.colGia.Text = "Giá";
            this.colGia.Width = 100;
            // 
            // colSoKy
            // 
            this.colSoKy.Text = "Số kỳ";
            this.colSoKy.Width = 100;
            // 
            // colSoLuong
            // 
            this.colSoLuong.Text = "Số lượng";
            this.colSoLuong.Width = 100;
            // 
            // colThanhTien
            // 
            this.colThanhTien.Text = "Thành tiền";
            this.colThanhTien.Width = 1200;
            // 
            // btnDatBao
            // 
            this.btnDatBao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDatBao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(76)))), ((int)(((byte)(80)))));
            this.btnDatBao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatBao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatBao.ForeColor = System.Drawing.Color.White;
            this.btnDatBao.Location = new System.Drawing.Point(689, 184);
            this.btnDatBao.Name = "btnDatBao";
            this.btnDatBao.Size = new System.Drawing.Size(75, 22);
            this.btnDatBao.TabIndex = 28;
            this.btnDatBao.Text = "Đặt báo";
            this.btnDatBao.UseVisualStyleBackColor = false;
            this.btnDatBao.Click += new System.EventHandler(this.btnDatBao_Click);
            // 
            // lblTongTienThanhToan
            // 
            this.lblTongTienThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTienThanhToan.ForeColor = System.Drawing.Color.Red;
            this.lblTongTienThanhToan.Location = new System.Drawing.Point(225, 187);
            this.lblTongTienThanhToan.Name = "lblTongTienThanhToan";
            this.lblTongTienThanhToan.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTongTienThanhToan.Size = new System.Drawing.Size(103, 16);
            this.lblTongTienThanhToan.TabIndex = 14;
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.ForeColor = System.Drawing.Color.Red;
            this.lblTongTien.Location = new System.Drawing.Point(41, 187);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTongTien.Size = new System.Drawing.Size(178, 16);
            this.lblTongTien.TabIndex = 19;
            this.lblTongTien.Text = "Tổng số tiền phải thanh toán:";
            // 
            // grbThongTinDB
            // 
            this.grbThongTinDB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grbThongTinDB.Controls.Add(this.btnSua);
            this.grbThongTinDB.Controls.Add(this.btnXoa);
            this.grbThongTinDB.Controls.Add(this.btnThem);
            this.grbThongTinDB.Controls.Add(this.lblLoaiBao);
            this.grbThongTinDB.Controls.Add(this.lblSoLuong);
            this.grbThongTinDB.Controls.Add(this.txtSoLuong);
            this.grbThongTinDB.Controls.Add(this.cmbLoaiBao);
            this.grbThongTinDB.Controls.Add(this.lblNgayBatDau);
            this.grbThongTinDB.Controls.Add(this.dtpNgayBatDau);
            this.grbThongTinDB.Controls.Add(this.lblNgayKetThuc);
            this.grbThongTinDB.Controls.Add(this.dtpNgayKetThuc);
            this.grbThongTinDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbThongTinDB.Location = new System.Drawing.Point(380, 48);
            this.grbThongTinDB.Name = "grbThongTinDB";
            this.grbThongTinDB.Size = new System.Drawing.Size(452, 200);
            this.grbThongTinDB.TabIndex = 23;
            this.grbThongTinDB.TabStop = false;
            this.grbThongTinDB.Text = "Thông tin đặt báo";
            // 
            // btnSua
            // 
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(76)))), ((int)(((byte)(80)))));
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(269, 117);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 22);
            this.btnSua.TabIndex = 27;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(76)))), ((int)(((byte)(80)))));
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(188, 117);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 22);
            this.btnXoa.TabIndex = 26;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(76)))), ((int)(((byte)(80)))));
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(107, 117);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 22);
            this.btnThem.TabIndex = 25;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lblLoaiBao
            // 
            this.lblLoaiBao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLoaiBao.AutoSize = true;
            this.lblLoaiBao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoaiBao.Location = new System.Drawing.Point(40, 40);
            this.lblLoaiBao.Name = "lblLoaiBao";
            this.lblLoaiBao.Size = new System.Drawing.Size(61, 16);
            this.lblLoaiBao.TabIndex = 15;
            this.lblLoaiBao.Text = "Loại báo";
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuong.Location = new System.Drawing.Point(223, 40);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(61, 16);
            this.lblSoLuong.TabIndex = 22;
            this.lblSoLuong.Text = "Số lượng";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Location = new System.Drawing.Point(294, 36);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(124, 22);
            this.txtSoLuong.TabIndex = 14;
            // 
            // cmbLoaiBao
            // 
            this.cmbLoaiBao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbLoaiBao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLoaiBao.FormattingEnabled = true;
            this.cmbLoaiBao.Location = new System.Drawing.Point(107, 36);
            this.cmbLoaiBao.Name = "cmbLoaiBao";
            this.cmbLoaiBao.Size = new System.Drawing.Size(110, 24);
            this.cmbLoaiBao.TabIndex = 10;
            this.cmbLoaiBao.SelectedIndexChanged += new System.EventHandler(this.cmbLoaiBao_SelectedIndexChanged);
            // 
            // lblNgayBatDau
            // 
            this.lblNgayBatDau.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNgayBatDau.AutoSize = true;
            this.lblNgayBatDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayBatDau.Location = new System.Drawing.Point(40, 80);
            this.lblNgayBatDau.Name = "lblNgayBatDau";
            this.lblNgayBatDau.Size = new System.Drawing.Size(57, 16);
            this.lblNgayBatDau.TabIndex = 8;
            this.lblNgayBatDau.Text = "Từ ngày";
            // 
            // dtpNgayBatDau
            // 
            this.dtpNgayBatDau.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpNgayBatDau.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayBatDau.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayBatDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayBatDau.Location = new System.Drawing.Point(107, 77);
            this.dtpNgayBatDau.Name = "dtpNgayBatDau";
            this.dtpNgayBatDau.Size = new System.Drawing.Size(110, 22);
            this.dtpNgayBatDau.TabIndex = 6;
            this.dtpNgayBatDau.ValueChanged += new System.EventHandler(this.dtpNgayBatDau_ValueChanged);
            // 
            // lblNgayKetThuc
            // 
            this.lblNgayKetThuc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNgayKetThuc.AutoSize = true;
            this.lblNgayKetThuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayKetThuc.Location = new System.Drawing.Point(223, 80);
            this.lblNgayKetThuc.Name = "lblNgayKetThuc";
            this.lblNgayKetThuc.Size = new System.Drawing.Size(65, 16);
            this.lblNgayKetThuc.TabIndex = 9;
            this.lblNgayKetThuc.Text = "Đến ngày";
            // 
            // dtpNgayKetThuc
            // 
            this.dtpNgayKetThuc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpNgayKetThuc.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayKetThuc.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayKetThuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayKetThuc.Location = new System.Drawing.Point(294, 77);
            this.dtpNgayKetThuc.Name = "dtpNgayKetThuc";
            this.dtpNgayKetThuc.Size = new System.Drawing.Size(124, 22);
            this.dtpNgayKetThuc.TabIndex = 7;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(76)))), ((int)(((byte)(80)))));
            this.btnXacNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXacNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhan.ForeColor = System.Drawing.Color.White;
            this.btnXacNhan.Location = new System.Drawing.Point(299, 13);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(75, 22);
            this.btnXacNhan.TabIndex = 18;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = false;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // lblKH
            // 
            this.lblKH.AutoSize = true;
            this.lblKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKH.Location = new System.Drawing.Point(9, 16);
            this.lblKH.Name = "lblKH";
            this.lblKH.Size = new System.Drawing.Size(78, 16);
            this.lblKH.TabIndex = 15;
            this.lblKH.Text = "Khách hàng";
            // 
            // cmbKhachHang
            // 
            this.cmbKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbKhachHang.FormattingEnabled = true;
            this.cmbKhachHang.Location = new System.Drawing.Point(96, 12);
            this.cmbKhachHang.Name = "cmbKhachHang";
            this.cmbKhachHang.Size = new System.Drawing.Size(197, 24);
            this.cmbKhachHang.TabIndex = 5;
            this.cmbKhachHang.SelectedIndexChanged += new System.EventHandler(this.cmbKhachHang_SelectedIndexChanged);
            // 
            // grbThongTinKH
            // 
            this.grbThongTinKH.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbThongTinKH.Controls.Add(this.label4);
            this.grbThongTinKH.Controls.Add(this.txtDiaChi);
            this.grbThongTinKH.Controls.Add(this.txtSoDienThoai);
            this.grbThongTinKH.Controls.Add(this.txtEmail);
            this.grbThongTinKH.Controls.Add(this.txtHoTen);
            this.grbThongTinKH.Controls.Add(this.label3);
            this.grbThongTinKH.Controls.Add(this.label2);
            this.grbThongTinKH.Controls.Add(this.label1);
            this.grbThongTinKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbThongTinKH.Location = new System.Drawing.Point(12, 48);
            this.grbThongTinKH.Name = "grbThongTinKH";
            this.grbThongTinKH.Size = new System.Drawing.Size(362, 200);
            this.grbThongTinKH.TabIndex = 4;
            this.grbThongTinKH.TabStop = false;
            this.grbThongTinKH.Text = "Thông tin khách hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Địa chỉ:";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(153, 157);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(169, 22);
            this.txtDiaChi.TabIndex = 11;
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSoDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoDienThoai.Location = new System.Drawing.Point(153, 117);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(168, 22);
            this.txtSoDienThoai.TabIndex = 10;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(153, 77);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(168, 22);
            this.txtEmail.TabIndex = 9;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.Location = new System.Drawing.Point(153, 37);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(169, 22);
            this.txtHoTen.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số điện thoại:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ tên:";
            // 
            // FrmDatBao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 581);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlHeader);
            this.Name = "FrmDatBao";
            this.Text = "Đặt báo";
            this.Load += new System.EventHandler(this.FrmDatBao_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlBody.ResumeLayout(false);
            this.pnlBody.PerformLayout();
            this.grbChiTietDB.ResumeLayout(false);
            this.grbChiTietDB.PerformLayout();
            this.grbThongTinDB.ResumeLayout(false);
            this.grbThongTinDB.PerformLayout();
            this.grbThongTinKH.ResumeLayout(false);
            this.grbThongTinKH.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.ComboBox cmbKhachHang;
        private System.Windows.Forms.GroupBox grbThongTinKH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpNgayKetThuc;
        private System.Windows.Forms.DateTimePicker dtpNgayBatDau;
        private System.Windows.Forms.Label lblNgayKetThuc;
        private System.Windows.Forms.Label lblNgayBatDau;
        private System.Windows.Forms.Label lblLoaiBao;
        private System.Windows.Forms.ComboBox cmbLoaiBao;
        private System.Windows.Forms.Label lblKH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.GroupBox grbThongTinDB;
        private System.Windows.Forms.GroupBox grbChiTietDB;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label lblTongTienThanhToan;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnDatBao;
        private System.Windows.Forms.ListView lsvDLCTDB;
        private System.Windows.Forms.ColumnHeader colSTT;
        private System.Windows.Forms.ColumnHeader colLoaiBao;
        private System.Windows.Forms.ColumnHeader colGia;
        private System.Windows.Forms.ColumnHeader colSoKy;
        private System.Windows.Forms.ColumnHeader colSoLuong;
        private System.Windows.Forms.ColumnHeader colThanhTien;
    }
}