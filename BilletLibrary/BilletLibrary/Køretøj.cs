using System;
using System.Collections.Generic;
using System.Text;

namespace BilletLibrary
{
    public abstract class Køretøj
    {
        public Køretøj(string nummerplade, DateTime dato)
        {
            if (nummerplade.Length > 7)
            {
                throw new ArgumentException();
            }
            Nummerplade = nummerplade;
            Dato = dato;
        }
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
            return KøretøjPris;
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
