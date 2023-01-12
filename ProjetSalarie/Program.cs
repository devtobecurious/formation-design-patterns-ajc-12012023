//using ProjetSalarie;

//Console.WriteLine("Le prenom du/de la salarié-e ?");
//var prenom = Console.ReadLine();

//Console.WriteLine("Il/elle y va comment ?");
//Console.WriteLine($" {(int)TypeDeplacement.APied}. A pied");
//Console.WriteLine($"{(int)TypeDeplacement.EnVelo}. A vélo");
//Console.WriteLine($"{(int)TypeDeplacement.EnVoiture}. En voiture");
//Console.WriteLine($"{(int)TypeDeplacement.EnTrain}. En train");
//var moyenDeplacement = Console.ReadLine();

//TypeDeplacement typeDeplacement = (TypeDeplacement) int.Parse(moyenDeplacement);

//switch (typeDeplacement)
//{
//	case TypeDeplacement.APied : Console.WriteLine($"{prenom} se déplace A pied"); break;
//    case TypeDeplacement.EnVelo: Console.WriteLine($"{prenom} se déplace A vélo"); break;
//    case TypeDeplacement.EnVoiture: Console.WriteLine($"{prenom} se déplace En voiture"); break;
//    case TypeDeplacement.EnTrain: Console.WriteLine($"{prenom} se déplace En train"); break;
//    default:
//		break;
//}

using ProjetSalarie;

void AfficherEnRouge(string mess)
{
    Console.ForegroundColor= ConsoleColor.Red;
    Console.WriteLine(mess);
    Console.ForegroundColor = ConsoleColor.White;
}

void AfficherEnVert(string mess)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(mess);
    Console.ForegroundColor = ConsoleColor.White;
}

Salarie salarie = new();
salarie.SeDeplacerAuTravail2(AfficherEnRouge);
salarie.SeDeplacerAuTravail2(AfficherEnVert);

