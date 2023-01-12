// See https://aka.ms/new-console-template for more information
using CalculTTC;

Calculateur calculateur = new();
calculateur.ComputeTTC(20, 1, typeProduit =>
{
    return 1.2f;
});
