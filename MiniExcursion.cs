using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Thali
{
    class MiniExcursion
    {
        private int numMiniExcursion;
        private string libelleMiniExcursion;
        private int nombrePlaces;
        private List<Etape> lesEtapes;
        public MiniExcursion(int numMiniExcursion, string libelleMiniExcursion, int nbPlaces)
        {
            this.nombrePlaces = nbPlaces;
            this.numMiniExcursion = numMiniExcursion;
            this.libelleMiniExcursion = libelleMiniExcursion;
            this.lesEtapes = new List<Etape>();
        }
        /// <summary>
        /// Retourne la durée totale de la mini-excursion en minutes. Cette durée est 
        /// la somme des durées en minutes des étapes constituant la mini-excursion.
        /// </summary>
        /// <returns></returns>
        public int getDureePrevue()
        {
			int dureeTotale = 0;
			foreach(Etape a in this.lesEtapes)
			{
				dureeTotale = dureeTotale + a.getDureePrevue();
				
			}
			//dureeTotale += dureeTotale;
            return dureeTotale;
        }
        public int getNombrePlaces()
        {
            return this.nombrePlaces;
        }
        /// <summary>
        /// Elle renvoie VRAI si le numéro d’étape n'existe pas déjà dans la liste des étapes de la mini-
        /// excursion et ajoute une nouvelle étape dans la liste. Elle renvoie FAUX dans le cas contraire. 
        /// </summary>

        public bool ajouteEtape(int numetape, string descriptions, int dureeprevue)
        {
			bool ok = true;
			foreach(Etape a in this.lesEtapes)
			{
				if(a.getNumEtape() == numetape)
				{
					ok = false;
				}
			}
			//si ok est true j'enregriste une nouvelle etape.
			//si ok est false je return false.
			if(ok == true)
			{
				Etape b = new Etape(numetape, descriptions, dureeprevue);
				this.lesEtapes.Add(b);
			}
            return ok;
            
        }

		public override string ToString()
		{
			string s, r ="";
			s = "Mini Excursion : " + this.libelleMiniExcursion;
			foreach (Etape a in this.lesEtapes)
			{
				r += a.ToString();

			}
			s = s + "\n" + "Numéro \nEtape: \t Description: \t\t Durée prevu : \n" + r;
			return s;
		}


	}
}