using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConOng
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //output Unicode 
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Game Con Ong");
            Game game = new Game();

            while (true)
            {
                Console.WriteLine("1. Tấn công");
                Console.WriteLine("2. Lấy trạng thái");
                Console.WriteLine("3. Thoát");
                int chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        game.TanCong();
                        break;
                    case 2:
                        game.LayTrangThai();
                        break;
                    case 3:
                        return;
                }
            }
        }
    }
}
