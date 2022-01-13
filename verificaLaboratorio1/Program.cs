using System;

namespace verificaLaboratorio1
{
    class Treno //  Classe padre "Treno", ha un nome, un tipo, un codice e un costo. Ha un metodo che restituisce il costo, che per un treno generico è di 100000€, e un altro che resituisce il costo per l'utilizzo in base ai km percorsi.
    {
        int codtreno, costo;
        string tipo, nome;
        protected Treno(string nome, int codtreno, string tipo) //  Metodo costruttore, accetta in input il nome, il codice del treno e il tipo.
        {
            this.nome = nome;
            this.codtreno = codtreno;
            this.tipo = tipo;
        }
        public virtual float GetCosto() //  Restituisce il costo di acquisto del treno, che è di 100000€ per un treno generico.
        {
            costo = 100000;
            return costo;
        }
        public virtual float GetCosto(float km) //  Tramite l'overloading è stato creato un metodo con lo stesso nome di quello precedente a cui si può dare in input il numero di chilometri percorsi per conoscere il costo dell'utilizzo del treno.
        {
            return km;  //  Dato che la consegna non specifica il costo per l'utilizzo di un treno generico, viene restituito il numero di km percorsi.
        }
        public override string ToString()   //  Restituisce le informazioni del treno.
        {
            return $"Nome: {nome}, Codice: {codtreno}, Tipo: {tipo}, Costo: {GetCosto()}";
        }
    }
    class Passeggeri : Treno    //  Classe che rappresenta un treno passeggeri, derivata dalla classe Treno.
    {
        int numvagoni;
        string alimentazione;
        public Passeggeri(string nome, int codtreno, string tipo, int numvagoni, string alimentazione):base(nome, codtreno, tipo)   //  Metodo costruttore, rispetto a quello originale accetta in input anche il numero di vagoni e il tipo di alimentazione.
        {
            this.numvagoni = numvagoni;
            this.alimentazione = alimentazione;
        }
        public override float GetCosto()    //  Tramite overriding si modifica il metodo originale che restituisce il prezzo di acquisto del treno. Un treno passeggeri ha lo stesso costo del treno generale aumentato del 25%, per cui si ottiene ciò che restituisce il metodo originale e si moltiplica per 1,25.
        {
            return base.GetCosto() * 1.25f;
        }
        public override float GetCosto(float km)    //  Tramite overriding si modifica il metodo orginale che restituisce il costo di utilizzo del treno. Siccome il metodo originale restituisce il numero di chilometri percorsi, si moltiplica la quantità restiuita per 150, ovvero i soldi spesi per ogni chilometro percorso da un treno passeggeri.
        {
            return base.GetCosto(km) * 150;
        }
        public override string ToString()   // Tramite overriding si aggiunge alle informazioni del treno anche il numero di vagoni e il tipo di alimentazione.
        {
            return base.ToString() + $" ,Numvagoni: {numvagoni}, Alimentazione: {alimentazione}";
        }
    }
    class Merci : Treno
    {
        int numvagoni;
        string alimentazione;
        public Merci(string nome, int codtreno, string tipo, int numvagoni, string alimentazione):base(nome, codtreno, tipo)    //  Metodo costruttore, rispetto a quello originale accetta in input anche il numero di vagoni e il tipo di alimentazione.
        {
            this.numvagoni = numvagoni;
            this.alimentazione = alimentazione;
        }
        public override float GetCosto()    //  Tramite overriding si modifica il metodo originale che restituisce il prezzo di acquisto del treno. Un treno merci ha lo stesso costo del treno generale aumentato del 35%, per cui si ottiene ciò che restituisce il metodo originale e si moltiplica per 1,35.
        {
            return base.GetCosto() * 1.35f;
        }
        public override float GetCosto(float km)    //  Tramite overriding si modifica il metodo orginale che restituisce il costo di utilizzo del treno. Siccome il metodo originale restituisce il numero di chilometri percorsi, si moltiplica la quantità restiuita per 100, ovvero i soldi spesi per ogni chilometro percorso da un treno merci.
        {
            return base.GetCosto(km) * 100;
        }
        public override string ToString()   // Tramite overriding si aggiunge alle informazioni del treno anche il numero di vagoni e il tipo di alimentazione.
        {
            return base.ToString() + $" ,Numvagoni: {numvagoni}, Alimentazione: {alimentazione}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            float kmPercorsi;   //  Variabile in cui vengono contenuti i km percorsi inseriti dall'utente.
            Passeggeri passeggeri = new Passeggeri("pippo", 123, "regionale", 10, "elettrico"); //  Viene istanziata una variabile di tipo passeggeri generica.
            Merci merci = new Merci("pluto", 321, "internazionale", 7, "diesel");   // Viene istanziata una variabile di tipo merci generica.
            Console.WriteLine(passeggeri);  //  Vengono mostrate le informazioni del treno passeggeri.
            Console.Write("Inserire il numero di km percorsi dal treno passeggeri.\nRisposta: ");   // Viene chiesto il numero di chilometri percorsi dal treno passeggeri.
            kmPercorsi = float.Parse(Console.ReadLine());   //  Viene immagazzinata la risposta in una variabile di tipo float.
            Console.WriteLine("Costo per il percorrimento di " + kmPercorsi + "km: " + merci.GetCosto(kmPercorsi)); //  Viene mostrato all'utente il costo dell'utilizzo tramite il metodo GetCosto(int km).
            Console.WriteLine("\n" + merci);    //  Vengono visualizzate le informazioni del treno merci.
            Console.Write("Inserire il numero di km percorsi dal treno merci.\nRisposta: ");    //  Viene chiesto il numero di chilometri percorsi dal treno merci.
            kmPercorsi = float.Parse(Console.ReadLine());   //  Viene immagazzinata la risposta in una variabile di tipo float.
            Console.WriteLine("Costo per il percorrimento di " + kmPercorsi + "km: " + passeggeri.GetCosto(kmPercorsi));    //  Viene mostrato all'utente il costo dell'utilizzo tramite il metodo GetCosto(int km).
        }
    }
}
