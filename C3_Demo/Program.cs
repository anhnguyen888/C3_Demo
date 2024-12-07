using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C3_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //cấu hình unicode
            Console.OutputEncoding = Encoding.UTF8;

            int a;
            //tạo ngẫu nhiên giá trị cho a từ 100 đến 999
            Random rd = new Random();
            a = rd.Next(100, 1000);

            //nhận giá trị b từ bàn phím 
            int b;
            Console.Write("Nhập giá trị b: ");
            b = int.Parse(Console.ReadLine());

            //in giá trị a 
            Console.WriteLine("Kết quả đoán: " + GetFeedBack(a.ToString(), b.ToString()));

            Console.WriteLine("Kết quả số ngẫu nhiên: " + a.ToString());

            //dừng màn hình 
            Console.ReadLine();
        }

        static string GetFeedBack(string target, string guess)
        {
            string result = "";

            for (int i = 0; i < target.Length; i++)
            {
                if (target[i] == guess[i])
                {
                    result += "+";
                }
                else if (target.Contains(guess[i].ToString()))
                {
                    result += "?";
                }
            }

            return result;
        }
    }
}
