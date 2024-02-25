public class MyClass
{
    public static int globalVar = 10;

    public static void MyMethod()
    {
        globalVar += 5;
        Console.WriteLine("Inside method: " + globalVar);
    }
}

class Program
{
    static void Main()
    {
        MyClass.MyMethod();
        Console.WriteLine("Outside method: " + MyClass.globalVar);
    }
}
