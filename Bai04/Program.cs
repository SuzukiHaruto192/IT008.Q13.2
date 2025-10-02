using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int thang, nam;
            // Nhập tháng hợp lệ
            do
            {
                Console.Write("Nhap thang (1-12): ");
            } while (!int.TryParse(Console.ReadLine(), out thang) || thang < 1 || thang > 12);

            // Nhập năm hợp lệ
            do
            {
                Console.Write("Nhap nam (>0): ");
            } while (!int.TryParse(Console.ReadLine(), out nam) || nam <= 0);

            Console.WriteLine("So ngay trong thang " + thang + "/" + nam + ": " + DateTime.DaysInMonth(nam, thang));
        }
    }
}
