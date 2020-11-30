using System;
namespace tpInterfaces
{
     abstract class EleveECT : Eleve

    {
        public EleveECT(string unNom):base(unNom)
        {

        }
        public abstract int resultat();
    }
}
