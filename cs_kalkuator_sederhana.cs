using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("1. Penjumlahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");
            Console.Write("Pilihan:");
            string? pilihan = Console.ReadLine();
            if (pilihan == "1")
            {
                Console.Write("Masukkan Angka Pertama: ");
                string? angka1 = Console.ReadLine();
                int angka1int = Convert.ToInt32(angka1);
                Console.Write("Masukkan Angka Kedua: ");
                string? angka2 = Console.ReadLine();
                int angka2int = Convert.ToInt32(angka2);
                int hasil = angka1int + angka2int;
                Console.WriteLine($"Hasil dari {angka1} + {angka2} adalah {hasil}");
                Console.WriteLine();
            }
            else if (pilihan == "2")
            {
                Console.Write("Masukkan Angka Pertama: ");
                string? min1 = Console.ReadLine();
                int min1int = Convert.ToInt32(min1);
                Console.Write("Masukkan Angka Kedua: ");
                string? min2 = Console.ReadLine();
                int min2int = Convert.ToInt32(min2);
                int hasilmin = min1int - min2int;
                Console.WriteLine($"Hasil dari {min1} - {min2} adalah {hasilmin}");
            }
            else if (pilihan == "3")
            {
                Console.Write("Masukkan Angka Pertama: ");
                string? kali1 = Console.ReadLine();
                int kaliint = Convert.ToInt32(kali1);
                Console.Write("Masukkan Angka Kedua: ");
                string? kali2 = Console.ReadLine();
                int kali2int = Convert.ToInt32(kali2);
                int hasilkali = kaliint * kali2int;
                Console.WriteLine($"Hasil dari {kali1} x {kali2} adalah {hasilkali}");
            }
            else if (pilihan == "4")
            {
                Console.Write("Masukkan Angka Pertama: ");
                string? bagi1 = Console.ReadLine();
                double bagi1int = Convert.ToDouble(bagi1);
                Console.Write("Masukkan Angka Kedua: ");
                string? bagi2 = Console.ReadLine();
                double bagi2int = Convert.ToDouble(bagi2);
                double hasilbagi = bagi1int / bagi2int;
                Console.WriteLine($"Hasil dari {bagi1} : {bagi2} adalah {hasilbagi}");
            }
            else
            {
                Console.WriteLine("Maaf, Pilihan TIdak Ada");
                Console.WriteLine();
            }
        }
    }
}
