using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConOng
{
    internal class ConOng
    {
        public string Loai { get; set; }
        //SucKhoe dựa theo loại con ong mà nó sẽ khác nhau
        //Nếu Loại là "OngTho" thì SucKhoe = 90
        //Nếu Loại là "OngChua" thì SucKhoe = 80
        //Nếu Loại là "OngPhucKich" thì SucKhoe = 70

        public float SoMau { get; set; }

        public ConOng(string loai)
        {
            Loai = loai;
            SoMau = 100;
        }

        public void TanCong(float soMauBiMat)
        {
            //nếu ong trạng thái là CHET thì không tấn công nữa

            if (LayTrangThai() == "CHET")
                return;
            SoMau -= soMauBiMat;
        }



        public string LayTrangThai()
        {
            string tinhTrang = "SONG";

            switch (Loai)
            {
                case "OngTho":
                    if (SoMau <= 90)
                    {
                        tinhTrang = "CHET";
                    }
                    break;
                case "OngChua":
                    if (SoMau <= 80)
                    {
                        tinhTrang = "CHET";
                    }
                    break;
                case "OngPhucKich":
                    if (SoMau <= 70)
                    {
                        tinhTrang = "CHET";
                    }
                    break;

            }


            return tinhTrang;
        }

        public void XuatThongTin()
        {
            Console.WriteLine("{0} | {1} | {2}", Loai, SoMau, LayTrangThai());
        }
    }
}
