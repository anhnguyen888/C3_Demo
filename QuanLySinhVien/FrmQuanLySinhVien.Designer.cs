namespace QuanLySinhVien
{
    partial class FrmQuanLySinhVien
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThemSua = new System.Windows.Forms.Button();
            this.cmbKhoa = new System.Windows.Forms.ComboBox();
            this.rboNu = new System.Windows.Forms.RadioButton();
            this.rboNam = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDiem = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenSinhVien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaSoSinhVien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDanhSachSinhVien = new System.Windows.Forms.DataGridView();
            this.colMaSinhVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenSinhVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSoLuongNam = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSoLuongNu = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachSinhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnThemSua);
            this.groupBox1.Controls.Add(this.cmbKhoa);
            this.groupBox1.Controls.Add(this.rboNu);
            this.groupBox1.Controls.Add(this.rboNam);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtDiem);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtTenSinhVien);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtMaSoSinhVien);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(42, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(509, 523);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sinh viên";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(272, 403);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(203, 62);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThemSua
            // 
            this.btnThemSua.Location = new System.Drawing.Point(30, 403);
            this.btnThemSua.Name = "btnThemSua";
            this.btnThemSua.Size = new System.Drawing.Size(203, 62);
            this.btnThemSua.TabIndex = 4;
            this.btnThemSua.Text = "Thêm/Sửa";
            this.btnThemSua.UseVisualStyleBackColor = true;
            this.btnThemSua.Click += new System.EventHandler(this.btnThemSua_Click);
            // 
            // cmbKhoa
            // 
            this.cmbKhoa.FormattingEnabled = true;
            this.cmbKhoa.Location = new System.Drawing.Point(172, 322);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(303, 37);
            this.cmbKhoa.TabIndex = 3;
            // 
            // rboNu
            // 
            this.rboNu.AutoSize = true;
            this.rboNu.Location = new System.Drawing.Point(383, 184);
            this.rboNu.Name = "rboNu";
            this.rboNu.Size = new System.Drawing.Size(71, 33);
            this.rboNu.TabIndex = 2;
            this.rboNu.TabStop = true;
            this.rboNu.Text = "Nữ";
            this.rboNu.UseVisualStyleBackColor = true;
            // 
            // rboNam
            // 
            this.rboNam.AutoSize = true;
            this.rboNam.Location = new System.Drawing.Point(233, 184);
            this.rboNam.Name = "rboNam";
            this.rboNam.Size = new System.Drawing.Size(92, 33);
            this.rboNam.TabIndex = 2;
            this.rboNam.TabStop = true;
            this.rboNam.Text = "Nam";
            this.rboNam.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 322);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 29);
            this.label6.TabIndex = 0;
            this.label6.Text = "Khoa";
            // 
            // txtDiem
            // 
            this.txtDiem.Location = new System.Drawing.Point(172, 250);
            this.txtDiem.Name = "txtDiem";
            this.txtDiem.Size = new System.Drawing.Size(303, 35);
            this.txtDiem.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 29);
            this.label5.TabIndex = 0;
            this.label5.Text = "Điểm TB";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "Giới tính";
            // 
            // txtTenSinhVien
            // 
            this.txtTenSinhVien.Location = new System.Drawing.Point(172, 119);
            this.txtTenSinhVien.Name = "txtTenSinhVien";
            this.txtTenSinhVien.Size = new System.Drawing.Size(303, 35);
            this.txtTenSinhVien.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Họ tên";
            // 
            // txtMaSoSinhVien
            // 
            this.txtMaSoSinhVien.Location = new System.Drawing.Point(172, 60);
            this.txtMaSoSinhVien.Name = "txtMaSoSinhVien";
            this.txtMaSoSinhVien.Size = new System.Drawing.Size(303, 35);
            this.txtMaSoSinhVien.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã số";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(638, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(422, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "QUẢN LÝ SINH VIÊN";
            // 
            // dgvDanhSachSinhVien
            // 
            this.dgvDanhSachSinhVien.AllowUserToAddRows = false;
            this.dgvDanhSachSinhVien.AllowUserToDeleteRows = false;
            this.dgvDanhSachSinhVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachSinhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaSinhVien,
            this.colTenSinhVien,
            this.colGioiTinh,
            this.colDiem,
            this.colKhoa});
            this.dgvDanhSachSinhVien.Location = new System.Drawing.Point(574, 87);
            this.dgvDanhSachSinhVien.Name = "dgvDanhSachSinhVien";
            this.dgvDanhSachSinhVien.ReadOnly = true;
            this.dgvDanhSachSinhVien.RowHeadersWidth = 62;
            this.dgvDanhSachSinhVien.RowTemplate.Height = 28;
            this.dgvDanhSachSinhVien.Size = new System.Drawing.Size(963, 511);
            this.dgvDanhSachSinhVien.TabIndex = 2;
            this.dgvDanhSachSinhVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachSinhVien_CellClick);
            // 
            // colMaSinhVien
            // 
            this.colMaSinhVien.HeaderText = "Mã Sinh Viên";
            this.colMaSinhVien.MinimumWidth = 8;
            this.colMaSinhVien.Name = "colMaSinhVien";
            this.colMaSinhVien.ReadOnly = true;
            // 
            // colTenSinhVien
            // 
            this.colTenSinhVien.HeaderText = "Tên";
            this.colTenSinhVien.MinimumWidth = 8;
            this.colTenSinhVien.Name = "colTenSinhVien";
            this.colTenSinhVien.ReadOnly = true;
            // 
            // colGioiTinh
            // 
            this.colGioiTinh.HeaderText = "Giới Tính";
            this.colGioiTinh.MinimumWidth = 8;
            this.colGioiTinh.Name = "colGioiTinh";
            this.colGioiTinh.ReadOnly = true;
            // 
            // colDiem
            // 
            this.colDiem.HeaderText = "Điểm";
            this.colDiem.MinimumWidth = 8;
            this.colDiem.Name = "colDiem";
            this.colDiem.ReadOnly = true;
            // 
            // colKhoa
            // 
            this.colKhoa.HeaderText = "Khoa";
            this.colKhoa.MinimumWidth = 8;
            this.colKhoa.Name = "colKhoa";
            this.colKhoa.ReadOnly = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1103, 617);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Nam";
            // 
            // txtSoLuongNam
            // 
            this.txtSoLuongNam.Location = new System.Drawing.Point(1174, 614);
            this.txtSoLuongNam.Name = "txtSoLuongNam";
            this.txtSoLuongNam.Size = new System.Drawing.Size(131, 26);
            this.txtSoLuongNam.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1353, 617);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Nữ";
            // 
            // txtSoLuongNu
            // 
            this.txtSoLuongNu.Location = new System.Drawing.Point(1406, 614);
            this.txtSoLuongNu.Name = "txtSoLuongNu";
            this.txtSoLuongNu.Size = new System.Drawing.Size(131, 26);
            this.txtSoLuongNu.TabIndex = 1;
            // 
            // FrmQuanLySinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1578, 684);
            this.Controls.Add(this.dgvDanhSachSinhVien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSoLuongNu);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtSoLuongNam);
            this.Controls.Add(this.label7);
            this.Name = "FrmQuanLySinhVien";
            this.Text = "QUẢN LÝ SINH VIÊN";
            this.Load += new System.EventHandler(this.FrmQuanLySinhVien_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachSinhVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThemSua;
        private System.Windows.Forms.ComboBox cmbKhoa;
        private System.Windows.Forms.RadioButton rboNu;
        private System.Windows.Forms.RadioButton rboNam;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDiem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTenSinhVien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaSoSinhVien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDanhSachSinhVien;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSoLuongNam;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSoLuongNu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaSinhVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenSinhVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKhoa;
    }
}

