using BossTravailInterfaces;

Salarie salarie = new(new ConsoleLogger());

//salarie.Travailler(); // vu que l'on ne passe rien, on écrira sur la console, ça prend le logger par défaut
//salarie.Travailler(new ToFileLogger(@"F:\Tmps\Tests\log.txt"));

//salarie.Travailler(new ColorConsoleLogger(ConsoleColor.Red));
//salarie.Travailler(new ColorConsoleLogger(ConsoleColor.Green));

Chef chef = new Chef();

salarie.TravailFini += chef.VerifierContenuCode;

salarie.Travailler();
