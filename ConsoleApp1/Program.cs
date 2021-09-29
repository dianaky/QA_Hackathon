using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1.symma 2.rand numbers 3.generate numbers and write\nВаш выбор:");
            string choose = Console.ReadLine();
            switch (choose)
            {
                case "1":
                    symma();
                    Console.ReadKey();
                    break;
                case "2":
                    double R = RND();
                    Console.Write(R);
                    Console.Write(" ");
                    break;
                case "3": //нужно переделать
                    for (int i = 0; i < 100; i++) 
                    {
                        double R2 = RND();
                        Console.Write(R2);
                        Console.Write(" ");
                    }
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }

        }
        static void symma()
        {
            try
            {
                Console.WriteLine("Введите первое число:");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите второе число:");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"   Сумма = {a + b}");
            }
            catch
            {
                Console.WriteLine("Error input");
            }
        }
        public static byte RND()
        {
            RNGCryptoServiceProvider Rand = new RNGCryptoServiceProvider();
            byte[] randomNumber = new byte[1];
            Rand.GetBytes(randomNumber);
            return (randomNumber[0]);
        }
    }
}
