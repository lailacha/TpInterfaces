using System;
using System.Collections.Generic;
using System.Linq;

namespace tpInterfaces
{
    public class groupeEleve
    {

        private List<Eleve> _lesEleves = new List<Eleve>();
        public groupeEleve()
        {
        }

        public int nombre()
        {

            int nbEleve =0;

            nbEleve = _lesEleves.Count;
            return nbEleve;
        }

        public List<Eleve> getListe()
        {

             
            return _lesEleves;

        
        }

        public void ajouterEleve(Eleve e)
        {
            _lesEleves.Add(e);
        }

        public Eleve chercher (string unNom)
        {

            Eleve eleve = null;
            foreach(Eleve e in _lesEleves)
            {
                if(e.Nom.Equals(unNom))
                {
                    eleve = e;
                    
                }
                

               
            }
            return eleve;
        }
       

        public void lister()
        {
            foreach(Eleve e in _lesEleves)
            {
                
                Console.WriteLine(e); 
            }
        }

        public Eleve meilleurEleve()
        {
            return _lesEleves.Max();
        }

        public void trierEleve()
        {
             _lesEleves.Sort();
        }


    }
}
