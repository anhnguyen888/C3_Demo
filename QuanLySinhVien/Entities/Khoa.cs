using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.Entities
{
    public class Khoa
    {
        // Thuộc tính Mã Khoa
        public string MaKhoa { get; set; }

        // Thuộc tính Tên Khoa
        public string TenKhoa { get; set; }

        // Constructor không tham số
        public Khoa()
        {
        }

        // Constructor có tham số để khởi tạo giá trị
        public Khoa(string maKhoa, string tenKhoa)
        {
            MaKhoa = maKhoa;
            TenKhoa = tenKhoa;
        }

        // Phương thức để hiển thị thông tin Khoa
        public override string ToString()
        {
            return $"Mã Khoa: {MaKhoa}, Tên Khoa: {TenKhoa}";
        }
    }

}
