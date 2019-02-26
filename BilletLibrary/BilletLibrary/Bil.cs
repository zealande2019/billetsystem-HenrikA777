using System;

namespace BilletLibrary
{
    public class Bil : Køretøj
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Bil"/> class.
        /// </summary>
        /// <param name="nummerplade">Køretøjets nummerplade
        /// </param>
        /// <param name="dato">Datoen for billeten
        /// </param>
        /// <param name="brobizz">
        /// Om der er brugt brobizz
        /// </param>
        public Bil(string nummerplade, DateTime dato, bool brobizz)
        :base(nummerplade, dato, brobizz)
        {
        }

        /// <summary>
        /// Prisen for billeten
        /// </summary>
        /// <returns>Pris</returns>
        public override decimal Pris()
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

        /// <summary>
        /// Typen af køretøj
        /// </summary>
        /// <returns>Typen af køretøj</returns>
        public override string Type()
        {
            return "Bil";
        }
    }
}
