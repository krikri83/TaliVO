using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Thali
{
	 class MiniExcursionPayante: MiniExcursion
	{
		private int tarif;

		public MiniExcursionPayante(int numMiniExcursion, string libelleMiniExcursion, int nbPlaces, int tar)
			:base(numMiniExcursion,libelleMiniExcursion, nbPlaces)
		{
			this.tarif = tar;
		}
	}
}