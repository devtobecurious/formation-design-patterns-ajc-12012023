using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FondamentauxInterfaces
{
    internal class Gorille : Animal
    {
        public override void Dormir()
        {
            Console.WriteLine("Je dors sur un lit de feuille");
        }

        public override void Naitre()
        {
            base.Naitre();
            Console.WriteLine("Je fais ouiiin ");
        }
    }
}
