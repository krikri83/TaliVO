using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Thali
{
    class Program
    {
        static void Main(string[] args)
        {
			MiniExcursion miniexcursion;
			miniexcursion = new MiniExcursion(1, "Visite de l’île au large du centre THALI", 50);
			miniexcursion.ajouteEtape(1, "traversée aller", 30);
			miniexcursion.ajouteEtape(2, "promenade dans l’île", 60);
			miniexcursion.ajouteEtape(3, "visite de la chapelle", 20);
			miniexcursion.ajouteEtape(4, "visite du phare", 30);
			miniexcursion.ajouteEtape(5, "promenade sur une petite crique", 15);
			miniexcursion.ajouteEtape(6, "visite du jardin exotique", 45);
			miniexcursion.ajouteEtape(7, "traversée retour ", 30);

			
			int n = miniexcursion.getDureePrevue();
			Console.WriteLine(n);
			Console.WriteLine(miniexcursion.ToString());

		}
	}
    
    
}
