// See https://aka.ms/new-console-template for more information


using DecouverteDelegues;

void MaFaconDafficher(string message)
{
    Console.WriteLine(message);
}

void MaFaconDafficher2(string test, string message)
{
    Console.WriteLine(message);
}

Afficher afficher = MaFaconDafficher;
afficher("Coucou");


Afficher afficher2 = message => Console.WriteLine(message);
afficher2("truc");
