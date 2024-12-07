using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.Entities
{
    public class SinhVien
    {
        // Thuộc tính Mã Sinh Viên
        public string MaSinhVien { get; set; }

        // Thuộc tính Tên Sinh Viên
        public string TenSinhVien { get; set; }

        // Thuộc tính Điểm
        public double Diem { get; set; }

        // Thuộc tính Mã Khoa (liên kết đến lớp Khoa)
        public string MaKhoa { get; set; }

        // Thuộc tính Giới Tính
        public string GioiTinh { get; set; }

        // Constructor không tham số
        public SinhVien()
        {
        }

        // Constructor có tham số để khởi tạo giá trị
        public SinhVien(string maSinhVien, string tenSinhVien, double diem, string maKhoa, string gioiTinh)
        {
            MaSinhVien = maSinhVien;
            TenSinhVien = tenSinhVien;
            Diem = diem;
            MaKhoa = maKhoa;
            GioiTinh = gioiTinh;
        }

        // Phương thức để hiển thị thông tin Sinh Viên
        public override string ToString()
        {
            return $"Mã Sinh Viên: {MaSinhVien}, Tên Sinh Viên: {TenSinhVien}, Điểm: {Diem}, Mã Khoa: {MaKhoa}, Giới Tính: {GioiTinh}";
        }
    }

}
