using System;
using System.Collections.Generic;

namespace ereditarietàDelleClassi2
{
    
    class Conto
    {
        protected int saldo;   //il saldo posseduto

        public virtual int Versa(int quantita)  //permette di versare una certa quantità di soldi
        {
            if(quantita > 0)
            {
                saldo += quantita;
                return 0;
            }
            else
            {
                return -1;
            }
        }
        public virtual int Preleva(int quantita)
        {
            if(quantita > 0)
            { 
                saldo -= quantita;
                return 0;
            }
            else
            {
                return -1;
            }
        }
        public int GetSaldo()
        {
            return saldo;
        }
    }

    class ContoSpeciale : Conto
    {
        public ContoSpeciale(int saldo)
        {
            this.saldo = saldo;
        }
        public override int Versa(int quantita)
        {
            if(quantita <= 3000)
            {
                base.Versa(quantita);
                return 0;
            }
            else
            {
                return -1;
            }
        }

        public override int Preleva(int quantita)
        {
            if (quantita <= 3000)
            {
                base.Versa(quantita);
                return 0;
            }
            else
            {
                return -1;
            }
        }
    }

    class Conti
    {
        public static List<Conto> contiNormali = new List<Conto>();
        public static List<ContoSpeciale> contiSpeciali = new List<ContoSpeciale>();

        public static void CreaConto(int tipo, int saldoIniziale)
        {
            switch (tipo)
            {
                case 1:
                    contiNormali.Add(CreaContoNormale(saldoIniziale));
                    break;
                case 2:
                    contiSpeciali.Add(CreaContoSpeciale(saldoIniziale));
                    CreaContoSpeciale(saldoIniziale);
                    break;
            }
        }

        static Conto CreaContoNormale(int saldoIniziale)
        {
            Conto c = new Conto();
            c.Versa(saldoIniziale);
            return c;
        }

        static ContoSpeciale CreaContoSpeciale(int saldoIniziale)
        {
            ContoSpeciale c = new ContoSpeciale(saldoIniziale);
            return c;
        }

        public static string ListaContiNormali()
        {
            string lista = "";
            for(int i = 0; i < contiNormali.Count; i++)
            {
                lista += i + 1 + ") " + contiNormali[i].GetSaldo() + " euro\n";
            }
            return lista;
        }

        public static string ListaContiSpeciali()
        {
            string lista = "";
            for (int i = 0; i < contiNormali.Count; i++)
            {
                lista += i + 1 + ") " + contiSpeciali[i].GetSaldo() + " euro\n";
            }
            return lista;
        }
    }

    class Program
    {
        static void Main()
        {
            while (true)
            {
                Menu();
            }
        }

        static void Menu()
        {
            Console.Clear();
            Console.Write("1) Crea conto\n2) Seleziona conto\nRisposta: ");
            bool success;
            do
            {
                success = true;
                switch (Console.ReadLine())
                {
                    case "1":
                        CreazioneConto();
                        break;
                    case "2":
                        SelezionaConti();
                        break;
                    default:
                        success = false;
                        Console.Write("\nRisposta non valida, reinserire: ");
                        break;
                }
            } while (!success);
        }

        static void CreazioneConto()
        {
            bool success;
            string tipoConto;
            int saldoIniziale;

            Console.Write("\nChe tipo di conto vuoi?\n1) Conto normale\n2) Conto speciale\nRisposta: ");
            do
            {
                success = true;
                tipoConto = Console.ReadLine();
                if (tipoConto != "1" && tipoConto != "2")
                {
                    Console.Write("\nRisposta non valida, reinserire.\nRisposta: ");
                    success = false;
                }
            } while (!success);

            Console.Write("\nQuanti soldi vuoi mettere nel conto?\nRisposta: ");
            do
            {
                if (!success)
                {
                    Console.Write("\nRisposta non valida. Reinserire: ");
                }
                success = Int32.TryParse(Console.ReadLine(), out saldoIniziale);
            } while (!success);
            Conti.CreaConto(Int32.Parse(tipoConto), saldoIniziale);
        }

        static void SelezionaConti()
        {
            bool success;
            Console.Write("\nChe tipo di conto vuoi selezionare?\n1) Conti normali\n2) Conti speciali\nRisposta: ");
            do
            {
                success = true;
                switch (Console.ReadLine())
                {
                    case "1":
                        AzioniConto(1);
                        break;
                    case "2":
                        AzioniConto(2);
                        break;
                    default:
                        success = false;
                        Console.Write("\nRisposta non valida, reinserire: ");
                        break;
                }
                //if (success)
                //{
                //    Console.WriteLine("Premi un tasto qualsiasi per continuare...");
                //    Console.ReadKey(true);
                //}

            } while (!success);
        }

        static void AzioniConto(int tipo)
        {
            bool success;
            int contoSelezionato, numeroConti = 0, soldiConto = 0;
            string lista = "";
            Console.Clear();
            switch (tipo)
            {
                case 1:
                    lista = Conti.ListaContiNormali();
                    numeroConti = Conti.contiNormali.Count;
                    break;
                case 2:
                    lista = Conti.ListaContiSpeciali();
                    numeroConti = Conti.contiSpeciali.Count;
                    break;
            }
            if (numeroConti == 0)
            {
                Console.WriteLine("Non esistono conti di questo tipo");
            }
            else
            {
                Console.WriteLine(lista);

                Console.Write("Quale conto vuoi selezionare?\nRisposta: ");
                do
                {
                    success = Int32.TryParse(Console.ReadLine(), out contoSelezionato);
                    if (success && (contoSelezionato > numeroConti || contoSelezionato < 1))
                    {
                        success = false;
                        Console.Write("Inserimento non valido. Reinserire: ");
                    }
                } while (!success);

                switch (tipo)
                {
                    case 1:
                        soldiConto = Conti.contiNormali[contoSelezionato - 1].GetSaldo();
                        break;
                    case 2:
                        soldiConto = Conti.contiSpeciali[contoSelezionato - 1].GetSaldo();
                        break;
                }
                Console.WriteLine("Il conto selezionato contiene {0} euro.", soldiConto);
                Console.Write("\nCosa vuoi fare con questo conto?\n1)Preleva\n2)Versa\nRisposta: ");
                do
                {
                    success = true;
                    switch (Console.ReadLine())
                    {
                        case "1":
                            break;
                        case "2":
                            break;
                        default:
                            break;
                    }
                } while (!success);
            }
            
        }

        static void Preleva(int tipo, int contoSelezionato)
        {
            int risultato = 0, daPrelevare = 0;
            bool success;
            Console.Write("Quanti soldi vuoi prelevare?\nRisposta: ");
            do
            {
                success = Int32.TryParse(Console.ReadLine(), out daPrelevare);
            } while (!success);

            switch (tipo)
            {
                case 1:
                    risultato = Conti.contiNormali[contoSelezionato].Preleva(daPrelevare);
                    break;
                case 2:
                    risultato = Conti.contiSpeciali[contoSelezionato].Preleva(daPrelevare);
                    break;
            }
            if(risultato == -1)
            {
                Console.WriteLine("Prelevamento riuscito");
            }
            else
            {

            }
        }
    }
}
