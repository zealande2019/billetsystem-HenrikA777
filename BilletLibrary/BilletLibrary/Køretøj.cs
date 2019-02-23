using System;
using System.Collections.Generic;
using System.Text;

namespace BilletLibrary
{
    public abstract class Køretøj
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Køretøj"/> class.
        /// </summary>
        /// <param name="nummerplade">
        /// Køretøjets nummerplade
        /// </param>
        /// <param name="dato">
        /// Datoen for billeten
        /// </param>
        /// <param name="brobizz">
        /// Om der er brugt brobizz
        /// </param>
        protected Køretøj(string nummerplade, DateTime dato, bool brobizz)
        {
            if (nummerplade.Length > 7)
            {
                throw new ArgumentException();
            }
            Nummerplade = nummerplade;
            Dato = dato;
            Brobizz = brobizz;
        }

        /// <summary>
        /// Gets or sets om der er brugt brobizz
        /// </summary>
        public bool Brobizz { get; set; }

        /// <summary>
        /// Gets or sets nummerpladen
        /// </summary>
        public string Nummerplade { get; set; }

        /// <summary>
        /// Gets or sets datoen for billeten
        /// </summary>
        public DateTime Dato { get; set; }

        /// <summary>
        /// Gets typen af køretøj
        /// </summary>
        protected abstract string KøretøjType { get; }

        /// <summary>
        /// Gets prisen for køretøjet
        /// </summary>
        protected abstract decimal KøretøjPris { get; }

        /// <summary>
        /// Prisen for billeten
        /// </summary>
        /// <returns>Pris</returns>
        public decimal Pris()
        {
            if (Brobizz)
            {
                return KøretøjPris - (KøretøjPris * Convert.ToDecimal(0.05));
            }
            else
            {
                return KøretøjPris;
            }
        }

        /// <summary>
        /// Typen af køretøj
        /// </summary>
        /// <returns>Typen af køretøj</returns>
        public string Type()
        {
            return KøretøjType;
        }
    }
}
