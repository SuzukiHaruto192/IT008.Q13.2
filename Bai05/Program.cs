using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap ngay thang nam (dd/MM/yyyy): ");
            string input = Console.ReadLine();

            //Kiem tra dieu kien cua input
            if (DateTime.TryParseExact(input, "dd/MM/yyyy",
                CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime date))
            {
                DayOfWeek Thu = date.DayOfWeek;
                Console.WriteLine("Thu trong tuan: ");
                switch (Thu)
                {
                    case DayOfWeek.Sunday: 
                        Console.WriteLine("Chu nhat"); break;
                    case DayOfWeek.Monday: 
                        Console.WriteLine("Thu hai"); break;
                    case DayOfWeek.Tuesday: 
                        Console.WriteLine("Thu ba"); break;
                    case DayOfWeek.Wednesday: 
                        Console.WriteLine("Thu tu"); break;
                    case DayOfWeek.Thursday: 
                        Console.WriteLine("Thu nam"); break;
                    case DayOfWeek.Friday: 
                        Console.WriteLine("Thu sau"); break;
                    case DayOfWeek.Saturday: 
                        Console.WriteLine("Thu bay"); break;
                }
            }
            else
            {
                Console.WriteLine("Ngay thang nam khong hop le!");
            }
        }
    }
}
