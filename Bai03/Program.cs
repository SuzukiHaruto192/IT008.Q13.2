using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap ngay thang nam (dd/MM/yyyy):");
            string input = Console.ReadLine();

            if (DateTime.TryParseExact(input, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime date))
            {
                Console.WriteLine("Ngay hop le");
            }
            else
            {
                Console.WriteLine("Ngay khong hop le");    
            }

        }
    }
}
