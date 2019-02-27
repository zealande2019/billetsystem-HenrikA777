using System;
using System.Collections.Generic;
using System.Text;

namespace OeresundBilletLibrary
{
    using BilletLibrary;
    class OeresundMC : MC
    {
        public OeresundMC(string nummerplade, DateTime dato, bool brobizz)
            : base(nummerplade, dato, brobizz)
        {
        }

        public override decimal Pris()
        {
            if (Brobizz)
            {
                return 73;
            }
            else
            {
                return 210;
            }
        }

        public override string Type()
        {
            return "Øresund MC";
        }
    }
}
