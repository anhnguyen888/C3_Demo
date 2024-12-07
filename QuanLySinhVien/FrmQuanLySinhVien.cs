using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLySinhVien.Entities;

namespace QuanLySinhVien
{
    public partial class FrmQuanLySinhVien : Form
    {
        List<Khoa> lstKhoa;
        List<SinhVien> lstSinhVien = new List<SinhVien>();

        public FrmQuanLySinhVien()
        {
            InitializeComponent();
            // cấu hình hiển thị dữ liệu cho Combobox Khoa 
            cmbKhoa.DisplayMember = "TenKhoa";
            cmbKhoa.ValueMember = "MaKhoa";
        }

        private void FrmQuanLySinhVien_Load(object sender, EventArgs e)
        {
            // Khởi tạo dữ liệu cho ComboBox Khoa (cmbKhoa)
            lstKhoa = new List<Khoa>()
            {
                new Khoa() { MaKhoa = "CNTT", TenKhoa = "Công nghệ thông tin"},
                new Khoa() { MaKhoa = "QTKD", TenKhoa = "Quản trị kinh doanh"},
                new Khoa() { MaKhoa = "KT", TenKhoa = "Kế toán"},
            };
            cmbKhoa.DataSource = lstKhoa;
        }

        private void btnThemSua_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ các control trên form để tạo mới SinhVien
            string maSinhVien = txtMaSoSinhVien.Text;
            string tenSinhVien = txtTenSinhVien.Text;
            double diem = double.Parse(txtDiem.Text);
            string maKhoa = cmbKhoa.SelectedValue.ToString();
            string gioiTinh = rboNam.Checked ? "Nam" : "Nữ";

            // Kiểm tra xem SinhVien đã tồn tại trong danh sách chưa
            SinhVien sv = lstSinhVien.FirstOrDefault(s => s.MaSinhVien == maSinhVien);
            if (sv == null)
            {
                // Tạo mới SinhVien
                sv = new SinhVien(maSinhVien, tenSinhVien, diem, maKhoa, gioiTinh);
                lstSinhVien.Add(sv);
            }
            else
            {
                // Cập nhật thông tin SinhVien
                sv.TenSinhVien = tenSinhVien;
                sv.Diem = diem;
                sv.MaKhoa = maKhoa;
                sv.GioiTinh = gioiTinh;
            }
            // Hiển thị danh sách SinhVien lên DataGridView
            HienThiDanhSachSinhVien();
            // Thống kê số lượng sinh viên Nam và Nữ
            int soLuongNam = lstSinhVien.Count(s => s.GioiTinh == "Nam");
            int soLuongNu = lstSinhVien.Count(s => s.GioiTinh == "Nữ");
            // Thống kê số lượng sinh viên có điểm >= 5
            int soLuongSVCoDiemTB = lstSinhVien.Count(s => s.Diem >= 5);
            // Thống kê số lượng sinh viên của khoa cntt 
            int soLuongSVKhoaCNTT = lstSinhVien.Count(s => s.MaKhoa == "CNTT");

            txtSoLuongNam.Text = soLuongNam.ToString();
            txtSoLuongNu.Text = soLuongNu.ToString();
            // Reset form
            txtMaSoSinhVien.Text = "";
            txtTenSinhVien.Text = "";
            txtDiem.Text = "";
            cmbKhoa.SelectedIndex = 0;
            rboNam.Checked = true;
        }

        private void HienThiDanhSachSinhVien()
        {
            // Xóa dữ liệu cũ trên DataGridView
            dgvDanhSachSinhVien.Rows.Clear();
            // Hiển thị dữ liệu mới lên DataGridView
            foreach (SinhVien sv in lstSinhVien)
            {
                int index = dgvDanhSachSinhVien.Rows.Add();
                dgvDanhSachSinhVien.Rows[index].Cells[0].Value = sv.MaSinhVien;
                dgvDanhSachSinhVien.Rows[index].Cells[1].Value = sv.TenSinhVien;
                dgvDanhSachSinhVien.Rows[index].Cells[2].Value = sv.GioiTinh;
                dgvDanhSachSinhVien.Rows[index].Cells[3].Value = sv.Diem;
                string tenKhoa = lstKhoa.FirstOrDefault(k => k.MaKhoa == sv.MaKhoa).TenKhoa;
                dgvDanhSachSinhVien.Rows[index].Cells[4].Value = tenKhoa;
            }
        }

        private void dgvDanhSachSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem người dùng có click vào dòng header không
            if (e.RowIndex < 0) return;
            // Lấy thông tin SinhVien từ dòng được click
            string maSinhVien = dgvDanhSachSinhVien.Rows[e.RowIndex].Cells[0].Value.ToString();
            SinhVien sv = lstSinhVien.FirstOrDefault(s => s.MaSinhVien == maSinhVien);
            if (sv != null)
            {
                // Hiển thị thông tin SinhVien lên form
                txtMaSoSinhVien.Text = sv.MaSinhVien;
                txtTenSinhVien.Text = sv.TenSinhVien;
                txtDiem.Text = sv.Diem.ToString();
                cmbKhoa.SelectedValue = sv.MaKhoa;
                rboNam.Checked = sv.GioiTinh == "Nam";
                rboNu.Checked = sv.GioiTinh == "Nữ";
            }

        }
    }
}
