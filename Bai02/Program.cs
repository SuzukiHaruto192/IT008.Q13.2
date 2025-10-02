using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai02
{
    internal class Program
    {
        //Ham kiem tra so nguyen to
        static bool LaSoNguyenTo(int n) { 
            if (n < 2) return false;

            int limit = (int)Math.Sqrt(n);
            for (int i = 2; i <= limit; i++) { 
                if (n % i == 0) return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so nguyen duong n: ");
            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            for (int i = 2; i < n; i++) {
                if (LaSoNguyenTo(i))
                    sum += i;
            }
            Console.WriteLine("Tong cac so nguyen to be hon " + n + ": " + sum);
        }
    }
}
