using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectVenerdí
{
    class Manager : Impiegato
    {
        public int Straordinari { get; set; }
        public int StipendioBase { get; set; }

        public Manager(string nome, string cognome, string codiceFiscale, SettoreEnum settore, int straordinari, int stipendioBase)
            : base(nome, cognome, codiceFiscale,settore)
        {
            Straordinari = straordinari;
            StipendioBase = stipendioBase;
        }
        public Manager() { }
    }
}
