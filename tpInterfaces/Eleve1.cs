using System;
namespace tpInterfaces
{
     class Eleve1 : EleveECT
    {
        public Eleve1( string unNom):base(unNom)
        {

        }

        public override int resultat()
        {
            if(this.Moyenne >= 12)
            {
                return 60;
            }
            else
            {
                return 0;
            }
        }
    }
}
