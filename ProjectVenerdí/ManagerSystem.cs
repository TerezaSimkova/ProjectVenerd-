using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectVenerdí
{
    class ManagerSystem
    {

        public static List<Impiegato> impiegati = new List<Impiegato>()
        {
            new Impiegato{Nome = "Carl", Cognome = "Stone", CodiceFiscale ="ABC123", Settore = SettoreEnum.Amministrazione},
            new Impiegato{Nome = "Mike", Cognome = "Blake", CodiceFiscale ="DEF456", Settore = SettoreEnum.Amministrazione},
            new Tecnico{Nome = "Tommy", Cognome = "Bow", CodiceFiscale = "GHI789", Settore = SettoreEnum.Sviluppo, OreLavoro = 140, PagaOraria = 12},
            new Stagista{Nome = "Tania", Cognome = "Moon", CodiceFiscale ="JKL321", Settore = SettoreEnum.Amministrazione, StipendioMensile = 600},
            new Stagista{Nome = "Andrea", Cognome = "Reed", CodiceFiscale ="MNO654", Settore = SettoreEnum.Vendite, StipendioMensile = 600},
            new Manager {Nome = "Michael", Cognome = "Rode", CodiceFiscale ="PQR987", Settore = SettoreEnum.Vendite, Straordinari = 15, StipendioBase = 900},
            new Manager {Nome = "Alice", Cognome = "Smile", CodiceFiscale ="STU147", Settore = SettoreEnum.Vendite, Straordinari = 20, StipendioBase = 900},
        };

       

        internal static void MostraImpiegati(int scelta)
        {
            
            foreach (Impiegato imp in impiegati)
            {
                Console.WriteLine($"{imp.Nome} {imp.Cognome} - {imp.Settore}");
            }
        }

        internal static void AddImpiegato(Impiegato imp1)
        {
            impiegati.Add(imp1);
        }

        internal static Impiegato GetImpByCodiceF(string codiceFiscale)
        {
            foreach (Impiegato imp in impiegati)
            {
                if (imp.CodiceFiscale != codiceFiscale)
                {
                    return imp;
                }
                
            }
            return null;
        }

        internal static void DeleteEvent(Impiegato impi)
        {
           
            impiegati.Remove(impi);
           
        }

        internal static void StampaImpVendite(int impiega) // volevo stampare lista di impiegati e poi scegliare quale mostrare secondo il nome che inserisce utente dopo ever scelto la categoria
        {
            foreach (Impiegato imp in impiegati)
            {
                //if (imp == impiegati.settore)
                //{
                //    Console.WriteLine($"{imp.Nome} {imp.Cognome} - {imp.Settore}");
                //}
                
            }
        }
    }
}
