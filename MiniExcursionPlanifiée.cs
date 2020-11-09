using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Thali
{
    class MiniExcursionPlanifiee
    {
        private MiniExcursion laMiniExcursion;
        private DateTime heurePrevue;
        private int nombreInscrits;
        public MiniExcursionPlanifiee(MiniExcursion uneMiniExcursion, DateTime uneHeureDepart)
        {
            this.laMiniExcursion = uneMiniExcursion;
            this.heurePrevue = uneHeureDepart;
        }
        /// <summary>
        /// Retourne VRAI si le nombre d’inscrits est égal au nombre de places
        /// et FAUX dans le cas contraire
        /// </summary>
        /// <returns></returns>
        public bool estComplete()
        {
			bool ok = false;
			if(this.nombreInscrits == this.laMiniExcursion.getNombrePlaces())
			{
				ok = true;
			}
            return ok;
        }
        
    }
}
