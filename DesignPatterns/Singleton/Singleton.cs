using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton
{
    internal class Singleton
    {
        private static Singleton instance = new Singleton();
        private bool baseOuverte = false;

        private Singleton()
        {
            
        }


        public void OuvertureBaseDeDonnees()
        {
            if (! this.baseOuverte)
            {
                this.baseOuverte = true;
            }
        }

        public static Singleton Instance => instance;

        // ici je dois avoir un new 

    //    public static void Test() { }
    }
}
