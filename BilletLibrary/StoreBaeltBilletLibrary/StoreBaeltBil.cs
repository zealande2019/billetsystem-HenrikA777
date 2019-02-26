using System;

namespace StoreBaeltBilletLibrary
{
    using BilletLibrary;
    public class StoreBaeltBil : Bil
    {
        public StoreBaeltBil(string nummerplade, DateTime dato, bool brobizz)
            : base(nummerplade, dato, brobizz)
        {
        }

        public override decimal Pris()
        {
            if (this.Dato.DayOfWeek == DayOfWeek.Saturday || this.Dato.DayOfWeek == DayOfWeek.Sunday)
            {
                double pris = 240 - 240 * 0.2;
                if (Brobizz)
                {
                    return Convert.ToDecimal(pris - (pris * 0.05));
                }
                else
                {
                    return Convert.ToDecimal(pris);
                }
            }
            else
            {
                if (Brobizz)
                {
                    return 240 - Convert.ToDecimal(240 * 0.05);
                }
                else
                {
                    return 240;
                }
            }
        }
    }
}
