using System;
namespace tpInterfaces
{
     class EleveMaster: EleveECT
    {
        public EleveMaster(string unNom):base(unNom)
        {
        }

        public override int resultat()
        {
            int resultat1 =0;
            foreach (int n in this.LesNotes)
            {
               if(n >=10 )
                {
                    resultat1 = resultat1 + 6;
                }
               else
                    if(n >= 8 && n < 10)
                {
                    resultat1 = resultat1 + 3;
                }

              
            }

            return resultat1;
        }
    }
}
