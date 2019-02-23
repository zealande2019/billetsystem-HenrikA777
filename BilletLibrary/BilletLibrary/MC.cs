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
        public MC(string nummerplade, DateTime dato)
            : base(nummerplade, dato)
        {
        }

        /// <summary>
        /// Gets typen af køretøj
        /// </summary>
        protected override string KøretøjType
        {
            get
            {
                return "MC";
            }
        }

        /// <summary>
        /// Gets prisen for køretøjet
        /// </summary>
        protected override decimal KøretøjPris
        {
            get
            {
                return 125;
            }
        }
    }
}
