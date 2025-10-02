using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai01
{
    internal class Program
    {
        //Ham kiem tra so le
        static bool LaSoLe(int n) {
            return n % 2 != 0;
        }

        //Ham kiem tra so nguyen to
        static bool LaSoNguyenTo(int n) { 
            if(n < 2)
                return false;
            int limit = (int)Math.Sqrt(n);
            for (int i = 2; i <= limit; i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }

        //Ham kiem tra so chinh phuong
        static bool LaSoCP(int n) { 
            int check = (int)Math.Sqrt(n);
            return check * check == n;
        }

        static void Main(string[] args)
        {
            //Khoi tao mang voi n phan tu so nguyen ngau nhien
            Console.WriteLine("Nhap so phan tu cua mang: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                a[i] = rand.Next(0, 100);
            }
            //In cac phan tu cua mang
            Console.WriteLine("Cac phan tu cua mang: ");
            for (int i = 0; i < n; i++) { 
                Console.WriteLine(a[i]);
            }

            //Cau a
            int sum = 0;
            for (int i = 0; i < n; i++) {
                if (LaSoLe(a[i]))
                    sum += a[i];
            }
            Console.WriteLine("Tong cac so le trong mang: " + sum);

            //Cau b
            int count = 0;
            for (int i = 0; i < n; i++) {
                if (LaSoNguyenTo(a[i]))
                    count++;
            }
            Console.WriteLine("So so nguyen to trong mang: " + count);

            //Cau c
            int min_SoCP = int.MaxValue;
            for (int i = 0; i < n; i++) {
                if (LaSoCP(a[i]) && a[i] < min_SoCP) {
                    min_SoCP = a[i];
                }
            }
            Console.WriteLine("So chinh phuong nho nhat trong mang: " + min_SoCP);
        }
    }
}
