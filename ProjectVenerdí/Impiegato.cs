using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectVenerdí
{
    class Impiegato : Persona
    {
        public SettoreEnum Settore { get; set; }
        //public int StipendioMensile = calcoloStipendio();
        // qui volevo aggiungere il metodo che condividono tutti con il calcolo dello stipendio


        public Impiegato(string nome, string cognome, string codiceFiscale, SettoreEnum settore)
            : base(nome, cognome, codiceFiscale)
        {
            Settore = settore;
            //StipendioMensile = stipendioMensile;
        }
        public Impiegato() { }

        //private static int calcoloStipendio()
        //{
        //    int giorni;
        //    int ore;

        //}

    }
    public enum SettoreEnum
    {
        Vendite,
        Amministrazione,
        Sviluppo
    }
}
