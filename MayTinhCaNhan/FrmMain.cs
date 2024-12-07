using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MayTinhCaNhan
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnPhepTinh_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem các ô textbox có chứa giá trị hợp lệ không thông qua ErrorProvider
            if(errNhapSo.GetError(txtSoA) != string.Empty || errNhapSo.GetError(txtSoB) != string.Empty)
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin đã nhập!");
                return;
            }


            // Lấy giá trị từ các ô textbox
            double a = double.Parse(txtSoA.Text);
            double b = double.Parse(txtSoB.Text);
            // Xác định phép toán từ sender
            System.Windows.Forms.Button btn = (System.Windows.Forms.Button)sender;
            string phepTinh = btn.Name;
            // Tính toán
            double kq = 0;
            switch (phepTinh)
            {
                case "btnCong":
                    kq = a + b;
                    break;
                case "btnTru":
                    kq = a - b;
                    break;
                case "btnNhan":
                    kq = a * b;
                    break;
                case "btnChia":
                    // Kiểm tra chia cho 0
                    if (b == 0)
                    {
                        MessageBox.Show("Không thể chia cho 0");
                        return;
                    }
                    kq = a / b;
                    break;
            }
            // Hiển thị kết quả
            txtKetQua.Text = kq.ToString();
        }

        private void txtSoA_KeyPress(object sender, KeyPressEventArgs e)
        {
            //// Kiểm tra nếu ký tự không phải là số và không phải là phím điều khiển (như Backspace)
            //if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            //{
            //    e.Handled = true; // Hủy thao tác nếu ký tự không hợp lệ
            //                      // Hiển thị lỗi với ErrorProvider
            //    errNhapSo.SetError(txtSoA, "Chỉ cho phép nhập số!");
            //}
            //else
            //{
            //    // Nếu nhập hợp lệ, xóa lỗi nếu có
            //    errNhapSo.SetError(txtSoA, string.Empty);
            //}
        }

        private void txtSoA_Validating(object sender, CancelEventArgs e)
        {
            // Kiểm tra xem TextBox có chứa giá trị hợp lệ khi mất focus
            if (string.IsNullOrEmpty(txtSoA.Text))
            {
                errNhapSo.SetError(txtSoA, "Không được để trống!");
            }
            //kiểm tra trường hợp không phải là số 
            else if (!double.TryParse(txtSoA.Text, out double soA))
            {
                errNhapSo.SetError(txtSoA, "Chỉ cho phép nhập số!");
            }
            else
            {
                // Xóa lỗi khi có giá trị hợp lệ
                errNhapSo.SetError(txtSoA, string.Empty);
            }
        }
    }
}
