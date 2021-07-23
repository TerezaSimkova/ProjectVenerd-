using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectVenerdí
{
    class Tecnico : Impiegato
    {
        public int PagaOraria { get; set; }
        public int OreLavoro { get; set; }


        public Tecnico(string nome, string cognome, string codiceFiscale, SettoreEnum settore,int pagaOraria,int oreLavoro) //stipendio: ore lavoro*paga ore
            : base(nome, cognome, codiceFiscale, settore)
        {
            PagaOraria = pagaOraria;
            OreLavoro = oreLavoro;
        }
        public Tecnico() { }
    }
}
