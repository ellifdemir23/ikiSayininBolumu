using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ikiSayınınBölümü1ElifDemir
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Girilen İki Sayıyı Kontrol Eden Bir Program.");
            Console.Write("Lütfen 1. Sayıyı Giriniz = ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Lütfen 2. Sayıyı Giriniz = ");
            int b = Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                if (a % b == 0)
                {
                    Console.Write(a + " Sayısı " + b + " Sayısına Tam Bölünüyor");
                }
                else
                {
                    Console.Write("Bu Sayılar Birbirine Tam Bölünmez");
                }
            }
            else
            {
                if (b % a == 0)
                {
                    Console.Write(b + " Sayısı " + a + " Sayısına Tam Bölünüyor.");
                }
                else
                {
                    Console.Write("Bu Sayılar Birbirine Tam Bölünmez");
                }
            }
            Console.ReadKey();










        }
    }
}
