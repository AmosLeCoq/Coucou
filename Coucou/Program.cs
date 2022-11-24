// See https://aka.ms/new-console-template for more information
using Coucou;

Console.WriteLine("lettre:");

A r = new rep("Coucou je suis A", "Coucou je suis A et B", "Je suis malade avec certificat");


string lettre = Console.ReadLine();

switch (lettre)
{
	case "A":
        Console.WriteLine(A.PhraseA);
        break;
        
	case "B":
	Console.WriteLine();
	break;
        
	case "C":
	Console.WriteLine(r.C);
	break;
        
	default:
	break;
}