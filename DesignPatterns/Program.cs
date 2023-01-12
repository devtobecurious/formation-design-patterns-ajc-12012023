using DesignPatterns.Singleton;

//var instance1 = new Singleton();// 1° instance
//var instance2 = new Singleton();// 2° instance

// Singleton.Test();


// On ne peut pas car le constructeur est privé
// var singleton = new Singleton();

var singleton = Singleton.Instance;
var singleton2 = Singleton.Instance;

singleton.OuvertureBaseDeDonnees();
singleton2.OuvertureBaseDeDonnees();
singleton2.OuvertureBaseDeDonnees();