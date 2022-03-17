using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Aplikasi Calculator";

            char pilihan;
            int a, b;

            Console.WriteLine("|    Pilih menu calculator :  |");
            Console.WriteLine("|    1. Penjumlahan           |");
            Console.WriteLine("|    2. Pengurangan           |");
            Console.WriteLine("|    3. Perkalian             |");
            Console.WriteLine("|    4. Pembagian             |");
            Console.WriteLine();

            Console.WriteLine("Input nomor menu (1...4) : "); pilihan=Convert.ToChar(Console.ReadLine());
            //pilihan=Convert.ToChar(Console.ReadLine());

            Console.WriteLine();

            if (pilihan == '1')
            {
                Console.Write("Inputkan nilai a = ");
                a = int.Parse(Console.ReadLine());

                Console.Write("Inputkan nilai b = ");
                b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("Hasil Penambahan {0} + {1} = {2} ", a, b, Penambahan(a, b));
            }
            else if (pilihan == '2')
            {
                Console.Write("Inputkan nilai a = ");
                a = int.Parse(Console.ReadLine());

                Console.Write("Inputkan nilai b = ");
                b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("Hasil Pengurangan {0} - {1} = {2} ", a, b, Pengurangan(a, b));
            }
            else if (pilihan == '3')
            {
                Console.Write("Inputkan nilai a = ");
                a = int.Parse(Console.ReadLine());

                Console.Write("Inputkan nilai b = ");
                b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("Hasil Perkalian {0} * {1} = {2} ", a, b, Perkalian(a, b));
            }
            else if (pilihan == '4')
            {
                Console.Write("Inputkan nilai a = ");
                a = int.Parse(Console.ReadLine());

                Console.Write("Inputkan nilai b = ");
                b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("Hasil Pembagian {0} / {1} = {2} ", a, b, Pembagian(a, b));
            }
            else
            {
                Console.WriteLine("Maaf, menu yang anda pilih tidak tersedia");
            }
            Console.WriteLine("\nTekan sembarang key untuk keluar");
            Console.ReadKey();
      
        }
        static int Penambahan(int a, int b)
        {
            return a + b;
        }
        static int Pengurangan(int a, int b)
        {
            return a - b;
        }
        static int Perkalian(int a, int b)
        {
            return a * b;
        }
        static int Pembagian(int a, int b)
        {
            return a / b;
        }
    }
}