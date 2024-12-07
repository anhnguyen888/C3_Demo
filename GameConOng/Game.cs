using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConOng
{
    internal class Game
    {
        public List<ConOng> DanhSachConOng { get; set; }

        public Game()
        {
            //khởi tạo 30 con ong, mỗi loại 10 con
            DanhSachConOng = new List<ConOng>();
            for (int i = 0; i < 10; i++)
            {
                DanhSachConOng.Add(new ConOng("OngTho"));
                DanhSachConOng.Add(new ConOng("OngChua"));
                DanhSachConOng.Add(new ConOng("OngPhucKich"));
            }
        }

        public void TanCong()
        {
            //tạo một số ngẫu nhiên từ 0 đến 50
            Random random = new Random();
            
            //tấn công cả 30 con ong
            foreach (var conOng in DanhSachConOng)
            {
                float soMauBiMat = random.Next(0, 50);
                conOng.TanCong(soMauBiMat);
            }
        }

        public void LayTrangThai()
        {
            foreach (var conOng in DanhSachConOng)
            {
                conOng.XuatThongTin();
            }
        }
    }
}
