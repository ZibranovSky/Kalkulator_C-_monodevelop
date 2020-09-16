using System;

namespace KalkulatorCc
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Masukkan angka pertama !");
            int angka1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Masukkan angka kedua !");
            int angka2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Masukkan Simbol Hitung!");
            string simbol = Console.ReadLine();

            switch (simbol)
            {
                case("+"):
                    Console.WriteLine(angka1 + angka2);
                    break;
                case ("-"):
                    Console.WriteLine(angka1 - angka2);
                    break;
                case ("/"):
                    Console.WriteLine(angka1 / angka2);
                    break;
                case ("*"):
                    Console.WriteLine(angka1 * angka2);
                    break;


                default:
                    break;
            }
        }
    }
}
