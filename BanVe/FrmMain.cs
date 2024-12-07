using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BanVe.EntitiesDb;

namespace BanVe
{
    public partial class FrmMain : Form
    {
        // Tạo đối tượng kết nối đến CSDL
        QuanLyBanVeModel db = new QuanLyBanVeModel();

        List<Button> danhSachGheChon = new List<Button>();

        // Tạo danh sách lưu thông tin sản phẩm 
        List<SanPham> danhSachSanPham = new List<SanPham>();

        public FrmMain()
        {
            InitializeComponent();
            // cấu hình hiển thị dữ liệu cho Combobox KhuVuc
            cmbKhuVuc.DisplayMember = "TenKV";
            cmbKhuVuc.ValueMember = "MaKV";

            // cấu hình chọn cho radiobutton
            rboNam.Checked = true;
            // cấu hình không cho thay đổi giá trị của cmbKhuVuc
            cmbKhuVuc.DropDownStyle = ComboBoxStyle.DropDownList;
            // cấu hình không cho thay đổi textbox tổng tiền 
            txtTongTien.Enabled = false;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            // Lấy dữ liệu KhuVuc từ CSDL
            cmbKhuVuc.DataSource = db.KhuVuc.ToList();
            // Lấy dữ liệu sản phẩm từ CSDL
            danhSachSanPham = db.SanPham.ToList();

            LoadThongTinHoaDon();
            LoadThongTinSanPhamDaMua();
        }

        private void LoadThongTinSanPhamDaMua()
        {
            // Lấy thông tin sản phẩm đã mua từ CSDL
            var danhSachSanPhamDaMua = db.ChiTietHoaDon.ToList().Select(p => p.SanPham.MaSP).ToList();
            // Lặp qua danh sách ghế để hiển thị màu vàng
            foreach (Button btn in pnlGhe.Controls.OfType<Button>())
            {
                if (danhSachSanPhamDaMua.Contains(int.Parse(btn.Text)))
                {
                    btn.BackColor = Color.Yellow;
                }
            }
        }

        private void btnGheChon_Click(object sender, EventArgs e)
        {
            // Chuyển sender thành Button
            Button btnGheChon = sender as Button;
            // Xác định trạng thái ghế
            if (btnGheChon.BackColor == Color.Yellow)
            {
                //Ghế đã bán 
                MessageBox.Show("Ghế đã bán", "Thông báo");
                return;
            }
            if (btnGheChon.BackColor == Color.White)
            {
                //Ghế đang chọn
                btnGheChon.BackColor = Color.Blue;
                danhSachGheChon.Add(btnGheChon);
            }
            else
            {
                //Ghế chưa chọn
                btnGheChon.BackColor = Color.White;
                danhSachGheChon.Remove(btnGheChon);
            }
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem người dùng đã chọn ghế chưa
            if (danhSachGheChon.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ghế", "Thông báo");
                return;
            }
            // Kiểm tra thông tin khách đã nhập đầy đủ chưa
            if (txtHoTen.Text == "" || txtSDT.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin khách hàng", "Thông báo");
                return;
            }
            // Hiển thị tổng tiền
            decimal tongTien = TinhTongTien();
            txtTongTien.Text = tongTien.ToString("C0");
            // Tạo Khách hàng mới
            KhachHang khachHang = new KhachHang()
            {
                HoTen = txtHoTen.Text,
                SDT = txtSDT.Text,
                GioiTinh = rboNam.Checked ? "Nam" : "Nữ",
                MaKV = int.Parse(cmbKhuVuc.SelectedValue.ToString())
            };
            // tạo tiếp hóa đơn cho khách hàng với thông tin tổng tiền đã tính ở trên 
            HoaDon hoaDon = new HoaDon()
            {
                MaKH = khachHang.MaKH,
                NgayMua = DateTime.Now,
                TongTien = tongTien
            };
            // Tạo tiếp chi tiết hóa đơn cho từng sản phẩm khách hàng mua
            foreach (Button btn in danhSachGheChon)
            {
                ChiTietHoaDon chiTietHoaDon = new ChiTietHoaDon()
                {
                    MaHD = hoaDon.MaHD,
                    MaSP = int.Parse(btn.Text)
                };
                // Thêm chi tiết hóa đơn vào hóa đơn
                hoaDon.ChiTietHoaDon.Add(chiTietHoaDon);
            }
            // Thêm các thông tin khách hàng, hóa đơn, chi tiết hóa đơn vào CSDL
            db.KhachHang.Add(khachHang);
            db.HoaDon.Add(hoaDon);
            db.SaveChanges();
            // Hiển thị thông báo
            MessageBox.Show("Đã mua hàng thành công", "Thông báo");
            // Xóa thông tin khách hàng
            txtHoTen.Text = "";
            txtSDT.Text = "";
            // Xóa thông tin ghế chọn
            txtTongTien.Text = "";
            danhSachSanPham.Clear();
            // Load danh sách hóa đơn đã bán    
            LoadThongTinHoaDon();

        }

        private void LoadThongTinHoaDon()
        {
            // Lấy thông tin hóa đơn từ CSDL
            var danhSachHoaDon = db.HoaDon.ToList();
            // Hiển thị thông tin hóa đơn lên datagridview theo thứ tự cột
            dgvHoaDon.Rows.Clear();
            foreach (var item in danhSachHoaDon)
            {
                int index = dgvHoaDon.Rows.Add();
                dgvHoaDon.Rows[index].Cells[0].Value = item.KhachHang.MaKH;
                dgvHoaDon.Rows[index].Cells[1].Value = item.KhachHang.HoTen;
                dgvHoaDon.Rows[index].Cells[2].Value = item.NgayMua;
                dgvHoaDon.Rows[index].Cells[3].Value = item.TongTien;
            }
        }

        private decimal TinhTongTien()
        {
            // Tính tiền các ghế được chọn trong danh sách
            decimal tongTien = 0;
            foreach (Button btn in danhSachGheChon)
            {
                tongTien += danhSachSanPham.Where(p => p.MaSP == int.Parse(btn.Text)).FirstOrDefault().GiaSP;
                btn.BackColor = Color.Yellow;
            }
            return tongTien;
        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Lấy thông tin những ghế đã mua của khách hàng được chọn 
            // Kiểm tra xem người dùng có click vào dòng header không
            if (e.RowIndex < 0)
            {
                return;
            }
           
        }
    }
}
