// See https://aka.ms/new-console-template for more information

using Model;

public class Program
{
    static void Main()
    {
        A a = new A();
        B b = new B();
        C c = new C();
        D d = new D();

        //string lettre = Console.ReadLine();

        Console.WriteLine(a.ToString()+a.OpenDay(DateTime.Now)+a.test());
        Console.WriteLine(b.ToString());
        Console.WriteLine(c.ToString());
        Console.WriteLine(d.ToString());
    }
}
    