using System;

class Program
{
    static void Main()
    {
        Console.Write("Masukkan Angka:");
        string? masukan = Console.ReadLine();

        if (masukan != null)
        {
            int keinteger = int.Parse(masukan);
            Console.WriteLine(keinteger);
        }
    }
}
