using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai06
{
    internal class Program
    {
        //Ham kiem tra so nguyen to
        static bool LaSoNguyenTo(int n) {
            if (n < 2) return false;

            int limit = (int)Math.Sqrt(n);
            for(int i = 2; i <= limit; i++)
                if(n % i == 0) return false;
            return true;
        }

        static void Main(string[] args)
        {
            //Khoi tao ma tran n hang, m cot cac so nguyen ngau nhien
            Console.WriteLine("Nhap so hang, so cot: ");
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            Random random = new Random();
            int[,] a = new int[n,m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    a[i,j] = random.Next(int.MinValue,int.MaxValue);
                }
            }

            //Cau a
            Console.WriteLine("Xuat ma tran: ");
            for (int i = 0; i < n; i++) 
            {
                for (int j = 0; j < m; j++) 
                {
                    Console.Write(a[i, j] + "\t");
                }
                Console.WriteLine();
            }

            //Cau b
            int min = int.MaxValue;
            int max = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if(min > a[i,j]) min = a[i,j];
                    if(max < a[i,j]) max = a[i,j];
                }
            }
            Console.WriteLine("Phan tu lon nhat: " + max);
            Console.WriteLine("Phan tu nho nhat: " + min);

            //Cau c
            int maxSum = int.MinValue;
            int index = -1;
            for (int i = 0; i < n; i++) 
            {
                int sum = 0;
                for (int j = 0; j < m; j++) 
                {
                    sum += a[i,j];
                }
                if (sum > maxSum)
                {
                    maxSum = sum;
                    index = i;
                }
            }
            Console.WriteLine("Dong co tong lon nhat la dong thu " + index);

            //Cau d
            int sum1 = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++) 
                {
                    if (!LaSoNguyenTo(a[i,j]))
                        sum1 += a[i,j];
                }
            }
            Console.WriteLine("Tong cac so khong phai so nguyen to: " + sum1);

            //Cau e
            int[,] b = new int[n - 1, m];
            Console.WriteLine("Nhap dong muon xoa: ");
            int k = int.Parse(Console.ReadLine());

            int newRow = 0;
            for (int i = 0; i < n; i++) {
                if (i == k) continue;
                for (int j = 0; j < m; j++) 
                {
                    b[newRow,j] = a[i,j];
                }
                newRow++;
            }
            Console.WriteLine("Ma tran sau khi xoa dong thu " + k + ":");
            for (int i = 0; i < n - 1; i++) 
            {
                for (int j = 0; j < m; j++) 
                {
                    Console.Write(b[i, j] + "\t");
                }
                Console.WriteLine();
            }

            //Cau f
            int erase_column = -1;
            bool flag = false;
            for (int i = 0; i < n; i++) 
            {
                for (int j = 0; j < m; j++) 
                {
                    if (flag == true) break;
                    if (a[i, j] == max)
                    {
                        erase_column = j;
                        flag = true; 
                        break;
                    }
                }
            }

            int[,] c = new int[n, m - 1];
            int newCol = 0;
            for (int j = 0; j < m; j++) 
            {
                if (erase_column == j) continue;
                for (int i = 0; i < n; i++) 
                {
                    c[i, newCol] = a[i, j];
                }
                newCol++;
            }

            Console.WriteLine("Ma tran sau khi xoa cot chua phan tu lon nhat: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m - 1; j++)
                {
                    Console.Write(c[i, j] + "\t");
                }
                Console.WriteLine();
            }

        }
    }
}
