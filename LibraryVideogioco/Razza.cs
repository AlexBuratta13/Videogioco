using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryVideogioco
{
    public abstract class Razza
    {
        public int attacco { get; private set; }
        public int difesa { get; private set; }
        private Schieramento schieramento;
    }
}
