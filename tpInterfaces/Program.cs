using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace tpInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            // Test classe Eleve
            //Eleve e1 = new Eleve("Laïla");
            //Eleve e2 = new Eleve("Jean");
            //Eleve e3 = new Eleve("Marie");
            //Eleve e4 = new Eleve("Pierre");
            //Eleve e5 = new Eleve("Kamel");

            //e1.ajouterNote(3);
            //e1.ajouterNote(4);
            //e1.ajouterNote(10);

            //e2.ajouterNote(0);

            //e3.ajouterNote(4);
            //e3.ajouterNote(10);
            //e3.ajouterNote(14);

            //e4.ajouterNote(10);
            //e4.ajouterNote(17);
            //e4.ajouterNote(12);

            //e5.ajouterNote(11);
            //e5.ajouterNote(23);
            //e5.ajouterNote(12);


            


            //Console.WriteLine(e1);
            //Console.ReadLine();
            //Console.WriteLine(e2);
            //Console.ReadLine();
            //Console.WriteLine(e3);
            //Console.ReadLine();

            //groupeEleve g1 = new groupeEleve();
            //g1.ajouterEleve(e1);
            //g1.ajouterEleve(e2);
            //g1.ajouterEleve(e3);
            //g1.ajouterEleve(e4);
            //g1.ajouterEleve(e5);

            //g1.lister();




            //Console.ReadLine();
            //Console.WriteLine("recherche d'un élève Jean:"+ g1.chercher("Jean"));
            //Console.WriteLine("recherche d'un élève 'Paul' (qui n'existe pas) :" + g1.chercher("Paul"));

            //Console.ReadLine();

            //Console.WriteLine("nombre d'élève dans le groupe:" + g1.nombre());

            //Console.WriteLine( "La moyenne la plus basse:" + e1.CompareTo(e1) );

            //g1.lister();

            //Console.ReadLine();
            //g1.trierEleve();

            //g1.lister();


            //Console.WriteLine("La moyenne la plus haute" + g1.meilleurEleve());


            List<EleveECT> ElevesList = new List<EleveECT>();

            EleveECT el1 = new Eleve1("Robert");
            EleveECT el2 = new Eleve1("Jeanne");
            EleveECT el3 = new EleveMaster("Gerard");
            EleveECT el4 = new EleveMaster("Lila");

            ElevesList.Add(el1);
            ElevesList.Add(el2);
            ElevesList.Add(el3);
            ElevesList.Add(el4);


            el1.ajouterNote(10);
            el1.ajouterNote(10);
            el2.ajouterNote(14);
            el2.ajouterNote(19);
            el3.ajouterNote(8);
            el4.ajouterNote(9);
            el4.ajouterNote(12);

            Console.WriteLine( "Liste sans tri:");

            foreach(EleveECT e in ElevesList)
            {
                Console.WriteLine("  Nombre de crédit: " + e.Nom +" -->"+ e.resultat());
            }
            Console.ReadLine();


            ElevesList.Sort();
            Console.WriteLine("Liste avec tri:");
            Console.ReadLine();

            foreach (EleveECT e in ElevesList)
            {
                Console.WriteLine(e +"  Nombre de crédit: " + " -->" + e.resultat());
            }
            Console.ReadLine();

            groupeEleve g2 = new groupeEleve();
            g2.ajouterEleve(el1);
            g2.ajouterEleve(el2);
            g2.ajouterEleve(el3);
            g2.ajouterEleve(el4);

            Console.WriteLine("Le meilleur élève est: " + g2.meilleurEleve());

            Console.WriteLine(el1.GetType());

        }
    }
}
