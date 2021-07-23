using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectVenerdí
{
    class Stagista : Impiegato
    {
        public int DurataStage { get; set; }
        public int StipendioMensile { get; set; }

        public Stagista(string nome, string cognome, string codiceFiscale, SettoreEnum settore, int durataStage, int stipendioMensile) 
           : base(nome, cognome, codiceFiscale, settore)
        {
            DurataStage = durataStage;
            StipendioMensile = stipendioMensile;
        }
        public Stagista() { }
    }
}
