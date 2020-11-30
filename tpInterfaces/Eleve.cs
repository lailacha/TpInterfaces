using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace tpInterfaces
{
    public class Eleve : IComparable
    {

        private string _nom; 
        private List<int> _lesNotes = new List<int>();
        private double _moyenne = 0;

        public Eleve(string unNom)
        {

           _nom = unNom;
        }

        public double Moyenne { get => _moyenne; set => _moyenne = value; }


        public string Nom { get => _nom; set => _nom = value; }
        public List<int> LesNotes { get => _lesNotes; set => _lesNotes = value; }


        public void ajouterNote(int Note)

        {
            double totalNote = 0;
            int laNote = 0;

            if(Note > 20)
            {
                laNote = 20;
            }
            else
                if(Note > 0 )
            {
                laNote = Note;
            }

            _lesNotes.Add(laNote);


            foreach(int n in _lesNotes)
            {
                totalNote = totalNote + n;
            }
            _moyenne = totalNote / _lesNotes.Count;

        }

        public int CompareTo(object obj)
        {
            Eleve e = (Eleve)obj;
            return _moyenne.CompareTo(e._moyenne);
        }

       

        public override string ToString()
        {
            string eleveDescription;


            return eleveDescription = this._nom + "  " + Math.Round(this._moyenne, 2);
        }
    }

   
}
