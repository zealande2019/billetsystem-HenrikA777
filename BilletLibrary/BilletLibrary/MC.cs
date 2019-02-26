using System;
using System.Collections.Generic;
using System.Text;

namespace BilletLibrary
{
    public class MC : Køretøj
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MC"/> class.
        /// </summary>
        /// <param name="nummerplade">Køretøjets nummerplade
        /// </param>
        /// <param name="dato">Datoen for billeten
        /// </param>
        /// <param name="brobizz">
        /// Om der er brugt brobizz
        /// </param>
        public MC(string nummerplade, DateTime dato, bool brobizz)
            : base(nummerplade, dato, brobizz)
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
                return 125 - Convert.ToDecimal(125 * 0.05);
            }
            else
            {
                return 125;
            }
        }

        /// <summary>
        /// Typen af køretøj
        /// </summary>
        /// <returns>Typen af køretøj</returns>
        public override string Type()
        {
            return "MC";
        }
    }
}
