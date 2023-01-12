using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecouverteDelegues
{
    // Contrat de méthode => signature de méthode
    // Ca dit la structure technique d'une méthode (fonction / action = procédure => renvoie void)
    // Le type de retour (void, int, ....), le nombre de paramètres en entrée (et leur type respectif)

    public delegate void Afficher(string message);

}
