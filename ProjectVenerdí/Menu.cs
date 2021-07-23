using System;

namespace ProjectVenerdí
{
    internal class Menu
    {
        internal static void Start()
        {
            Console.WriteLine("Benvenuto!Scegli tra le opzioni: ");

            int scelta;
            bool continua = false;

            do
            {
                Console.WriteLine("Scegli 1 per visualizzare tutti gli impiegati. ");
                Console.WriteLine("Scegli 2 per visualizzare gli impiegati di un certo settore.");
                Console.WriteLine("Scegli 3 per inserire un nuovo impiegato.");
                Console.WriteLine("Scegli 4 per eliminare.");

                while (!(int.TryParse(Console.ReadLine(), out scelta) || scelta < 0 || scelta > 4))
                {
                    Console.WriteLine("La scelta non valida.");
                }
                switch (scelta)
                {
                    case 1:
                        ManagerSystem.MostraImpiegati(scelta);
                        break;
                    case 2:
                        MostraUnImpiegato();                       
                        break;
                    case 3:
                        AddImpiegato();
                        break;
                    case 4:
                        RemoveImpiegato();
                        break;
                    default:
                        Console.WriteLine("Scelta non valida.");
                        break;
                }


            } while (!continua);
        }

        private static void MostraUnImpiegato()
        {
            int settore;
            string nome;
            do
            {
                Console.WriteLine($"Scegli da che settore vuoi mostrare gli impiegati:\n{ (int)SettoreEnum.Vendite} per { SettoreEnum.Vendite}" +
                $"\n{(int)SettoreEnum.Amministrazione} per {SettoreEnum.Amministrazione} " +
                $"\n{(int)SettoreEnum.Sviluppo}  per {SettoreEnum.Sviluppo}");

            } while (!int.TryParse(Console.ReadLine(), out settore) || settore < 0 || settore > 3);
            if (settore == 0)
            {
                ManagerSystem.StampaImpVendite(settore);
                Console.WriteLine("Scegli suo nome.");
                nome = Console.ReadLine();
            }
            else if (settore == 1)
            {
                // ripetere di nuovo Scegli da che settore... E stampare impiegato scelto
            }
            else if(settore == 2)
            {
                //  ripetere di nuovo Scegli da che settore... E stampare impiegato scelto
            }
        }

        private static void RemoveImpiegato()
        {
            string codiceFiscale;
            
            Console.WriteLine("Scegli quale impiegato vuoi eliminare.");
            do
            {
                Console.WriteLine("Inserisci il suo codice fiscale:");
                codiceFiscale = Console.ReadLine();


            } while (codiceFiscale.Length == 0 );
            Impiegato impi = ManagerSystem.GetImpByCodiceF(codiceFiscale);
           
            if (impi != null)
            {
                ManagerSystem.DeleteEvent(impi);
            }
            else
            {
                Console.WriteLine("Non ce nessun impiegato con questo codice fiscale da rimuovere.");
            }
        }

        private static void AddImpiegato()
        {
            string nome, cognome;
            string codiceFiscale;
            int settore;
            do
            {
                Console.WriteLine("Inserisci il nome: ");
                nome = Console.ReadLine();

            } while (nome.Length == 0);
            do
            {
                Console.WriteLine("Inserisci il cognome: ");
                cognome = Console.ReadLine();

            } while (cognome.Length == 0);
            do
            {
                Console.WriteLine("Inserisci il codice fiscale. Esempio: ABC123 : "); // TODO: il controllo se ce giá una persona con questo codice fiscale non funziona bene, si eseque sempre anche se ce giá una persona con questo codice 
                codiceFiscale = Console.ReadLine();
                Impiegato imp = ManagerSystem.GetImpByCodiceF(codiceFiscale);
                if (imp != null)
                {
                    do
                    {
                        Console.WriteLine($"Scegli il settore :\n{ (int)SettoreEnum.Vendite} per { SettoreEnum.Vendite}" +
                        $"\n{(int)SettoreEnum.Amministrazione} per {SettoreEnum.Amministrazione} " +
                        $"\n{(int)SettoreEnum.Sviluppo}  per {SettoreEnum.Sviluppo}");


                    } while (!int.TryParse(Console.ReadLine(), out settore) || settore < 0 || settore > 3);


                    Impiegato imp1 = new Impiegato { Nome = nome, Cognome = cognome, CodiceFiscale = codiceFiscale, Settore = (SettoreEnum)settore };

                    ManagerSystem.AddImpiegato(imp1);
                }
                else
                {
                    Console.WriteLine("Impiegato esiste giá nella database.");
                }

            } while (codiceFiscale.Length == 0);
            


        }
    }
}