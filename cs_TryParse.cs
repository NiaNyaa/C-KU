using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("1. Penjumlahan");
        Console.Write("Pilihan: ");
        string? pil = Console.ReadLine();

        if (pil == "1"){
            Console.Write("Angka pertama:");
            string? a1 = Console.ReadLine();
            Console.Write("Angka kedua:");
            string? a2 = Console.ReadLine();

            if (int.TryParse(a1, out int hasil1) && int.TryParse(a2, out int hasil2))
            {
                Console.WriteLine("Hasil penjumlahan: " + (hasil1 + hasil2));
            }

        }

        


    }
}
