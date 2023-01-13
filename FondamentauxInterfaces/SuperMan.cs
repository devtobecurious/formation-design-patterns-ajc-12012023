using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FondamentauxInterfaces
{
    internal class SuperMan : IVoler
    {
        public void Voler()
        {
            Console.WriteLine("Je vole dans le ciel, car je suis SM");
        }
    }
}
