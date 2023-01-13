using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FondamentauxInterfaces
{
    internal class Perroquet : Animal, IVoler, IEtreVivant
    {
        public override void Dormir()
        {
            Console.WriteLine("Je dors sur une branche");
        }

        public void Voler()
        {
            Console.WriteLine("Je vole avec de belles ailes de perroquet");
        }
    }
}
