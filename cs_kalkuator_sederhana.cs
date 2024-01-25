using System;

class Program
{
    static void Main()
    {
        Console.Write("Angka Pertama: ");
        string? angka1 = Console.ReadLine();
        int angka1int = Convert.ToInt32(angka1);
        Console.Write("Angka Kedua: ");
        string? angka2 = Console.ReadLine();
        int angka2int = Convert.ToInt32(angka2);
        int hasil = angka1int + angka2int;
        Console.WriteLine(hasil);


    }
}               
