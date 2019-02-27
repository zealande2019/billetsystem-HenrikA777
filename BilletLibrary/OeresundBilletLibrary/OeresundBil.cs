using System;

namespace OeresundBilletLibrary
{
    using BilletLibrary;
    public class OeresundBil : Bil
    {
        public OeresundBil(string nummerplade, DateTime dato, bool brobizz)
            : base(nummerplade, dato, brobizz)
        {
        }

        public override decimal Pris()
        {
            if (Brobizz)
            {
                return 161;
            }
            else
            {
                return 410;
            }
        }

        public override string Type()
        {
            return "Øresund Bil";
        }
    }
}
