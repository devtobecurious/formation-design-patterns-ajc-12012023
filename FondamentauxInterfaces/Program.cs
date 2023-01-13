using FondamentauxInterfaces;

// Animal animal = new Animal(); A cause de l'abstract

Animal animal = new Gorille(); // J'ai fait un if
animal.Dormir();


animal = new Perroquet();
animal.Dormir();


// Zoo
List<Animal> animals = new()
{
    new Gorille(),
    new Perroquet(),
    new Gorille()
};

foreach (var item in animals)
{
    item.Dormir();
}


void FaireVoler(IVoler quiVole)
{
    quiVole.Voler();
}


FaireVoler(new Perroquet());
FaireVoler(new SuperMan());
