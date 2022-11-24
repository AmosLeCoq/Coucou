// See https://aka.ms/new-console-template for more information
using Coucou;

Console.WriteLine("lettre:");

A test = new A("Coucou je suis A");
B test1 = new B("Coucou je suis A et B");
C test2 = new C("Je suis malade avec certificat");

//string lettre = Console.ReadLine();

Console.WriteLine(test.PhraseA);
Console.WriteLine(test1.PhraseB);
Console.WriteLine(test2.PhraseC);
