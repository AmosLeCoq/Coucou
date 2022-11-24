// See https://aka.ms/new-console-template for more information

using Model;

public class Program
{
    static void Main()
    {
        A a = new A();
        B b = new B();
        C c = new C();

        //string lettre = Console.ReadLine();

        Console.WriteLine(a.ToString());
        Console.WriteLine(b.ToString());
        Console.WriteLine(c.ToString());
    }
}
    