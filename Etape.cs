using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Thali
{
    class Etape
    {
        private int numEtape;
        private string description;
        private int dureePrevue;
        public Etape(int numEtape, string description, int dureePrevue)
        {
            this.numEtape = numEtape;
            this.description = description;
            this.dureePrevue = dureePrevue;
        }
        public int getNumEtape()
        {
            return this.numEtape;
        }
        public int getDureePrevue()
        {
            return this.dureePrevue;
        }
        public override string ToString()
        {
            return this.numEtape + "\t" + this.description + "\t \t\t" + this.dureePrevue + "\n";
        }
    }
}
