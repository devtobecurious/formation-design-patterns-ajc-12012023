using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetSalarie
{
    internal class Salarie
    {
        public void SeDeplacerAuTravail(int typeEcran)
        {
            //switch (typeEcran)
            //{
            //    case 0: Console.WriteLine("Je me déplace"); break;
            //    case 1: break; // Appel d'un label.Text = "Je me déplace";

            //    default:
            //        break;
            //}
            AfficheSelonTypeEcran(typeEcran);
            // ****** le code réel de déplacement
        }

        void AfficheSelonTypeEcran(int typeEcran)
        {
            switch (typeEcran)
            {
                case 0: Console.WriteLine("Je me déplace"); break;
                case 1: break; // Appel d'un label.Text = "Je me déplace";

                default:
                    break;
            }
        }

        public void SeDeplacerAuTravail2(Afficher afficher)
        {
            // Qu'est ce je fais ici ? je cherche à afficher quelque chose à "quelqu'un" (à priori l'écran)
            // v1: Console.WriteLine("Je me déplace au travail");
            // v2
            afficher("Je me déplace au travail");
        }
    }
}
