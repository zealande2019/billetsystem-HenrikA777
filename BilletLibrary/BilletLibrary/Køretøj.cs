using System;
using System.Collections.Generic;
using System.Text;

namespace BilletLibrary
{
    public abstract class Køretøj
    {
        private string _nummerplade;

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
        public string Nummerplade
        {
            get => _nummerplade;
            set
            {
                if (value.Length > 7)
                {
                    throw new ArgumentException();
                }

                _nummerplade = value;
            }
        }

        /// <summary>
        /// Gets or sets datoen for billeten
        /// </summary>
        public DateTime Dato { get; set; }

        /// <summary>
        /// Prisen for billeten
        /// </summary>
        /// <returns>Pris</returns>
        public abstract decimal Pris();

        /// <summary>
        /// Typen af køretøj
        /// </summary>
        /// <returns>Typen af køretøj</returns>
        public abstract string Type();

    }
}
