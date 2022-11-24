// See https://aka.ms/new-console-template for more information
using Coucou;

Console.WriteLine("lettre:");

rep r = new rep("Coucou je suis A", "Coucou je suis A et B", "Je suis malade avec certificat");
rep salut = new List<rep>();

string lettre = Console.ReadLine();

switch (lettre)
{
	case "A":
	Console.WriteLine(r.A);
	break;
        
	case "B":
	Console.WriteLine(r.B);
	break;
        
	case "C":
	Console.WriteLine(r.C);
	break;
        
	default:
	break;
}