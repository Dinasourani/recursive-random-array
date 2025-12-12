using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void arr(int[] arra, int index, Random rnd)
        {
       
            if (index == arra.Length)
                return;

      
            arra[index] = rnd.Next(0, 101);

            
            arr(arra, index + 1, rnd);
        }

        static void Main(string[] args)
        {
            Console.Write("تعداد عناصر آرایه را وارد کنید: ");
            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];
            Random rnd = new Random();

            // مقداردهی بازگشتی
            arr(array, 0, rnd);

            // نمایش مقادیر آرایه
            Console.WriteLine("\nمقادیر آرایه:");
            foreach (int x in array)
            {
                Console.Write(x + " ");
            }
            Console.ReadKey();
        }
    }
}
