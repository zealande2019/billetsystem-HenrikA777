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
        /// Gets typen af køretøj
        /// </summary>
        protected override string KøretøjType
        {
            get
            {
                return "Bil";
            }
        }

        /// <summary>
        /// Gets prisen for køretøjet
        /// </summary>
        protected override decimal KøretøjPris
        {
            get
            {
                return 240;
            }
        }
    }
}
