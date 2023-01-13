using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FondamentauxInterfaces
{
    internal abstract class Animal
    {
        // public TypeAnimal TypeAnimal { get; set; }

        //         public void Manger() => Console.WriteLine("");
        //public void Manger()
        //{
        //    Console.WriteLine("");
        //}

        //public void Dormir()
        //{
        //    switch (TypeAnimal) 
        //    {
        //        case TypeAnimal.Chat: Console.WriteLine("Je dors sur le canapé, affalé"); break;
        //        case TypeAnimal.Gorille: Console.WriteLine("Je dors sur un lit de feuille"); break;
        //        case TypeAnimal.Perroquet: Console.WriteLine("Je dors dans un arbre"); break;
        //    }
        //}
        public virtual void Naitre()
        {
            Console.WriteLine("Je nais");
        }

        public abstract void Dormir();
    }
}
