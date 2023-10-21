using Swed32;


Swed swed = new Swed("popcapgame1");
IntPtr moduleBase = swed.GetModuleBase("popcapgame1.exe");
IntPtr Address = swed.ReadPointer(moduleBase, 0x00096BC8, 0x3C, 0x4) + 0x5560;



Console.WriteLine("Program Mulai");


while (true)
{
    //Swed WriteInt(Address,1337);
    int ammo = swed.ReadInt(Address);
    Console.WriteLine(ammo);
}
