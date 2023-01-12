using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculTTC
{
    internal class Calculateur
    {
        public float ComputeTTC(float prixHT, int typeProduit, GetValidTva getTva)
        {
            // un delegue
            //float quoiObtenirLaBonneTva = 1.2f;
            //if (typeProduit == 0)
            //{
            //    quoiObtenirLaBonneTva = 1.2f;
            //}
            //else if (typeProduit == 1)
            //{
            //    quoiObtenirLaBonneTva = 1.055f;
            //}
            float quoiObtenirLaBonneTva = getTva(typeProduit);

            return prixHT * quoiObtenirLaBonneTva;
        }
    }
}
