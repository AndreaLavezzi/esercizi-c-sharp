// Autore: Lavezzi Andrea
// Classe: 4F
// Data: 17/12/2021
/* Consegna:
 * Si crei la classe dipendente con i soli attributi: matricola, nome e cognome. La classe avrà un
 * metodo che calcola la retribuzione oraria. Dalla nostra classe dipendente vogliamo derivare tre
 * differenti classi: dirigente, impiegato e operaio. Visualizzare la retribuzione oraria dei tre dipendenti
 * sapendo che la retribuzione oraria per l’operario è 35€/h mentre per l’impiegato la retribuzione
 * aumenta del 30% e per il dirigente del 50%.
 */
using System;

namespace polimorfismo1
{
    // Classe base "Dipendente", ha un numero di matricola, un nome, un cognome. Il metodo costruttore assegna dei valori a questi attributi. Ha un metodo ToString() per ottenere i valori degli attributi. Ha un metodo vuoto "GetRetribuzione" per vedere la retribuzione oraria.
    class Dipendente
    {
        int matricola;
        string nome, cognome; 
        public Dipendente(int matricola, string nome, string cognome)
        {
            this.matricola = matricola;
            this.nome = nome;
            this.cognome = cognome;
        }

        public override string ToString()
        {
            return $"{nome} {cognome}, Matricola: {matricola}";
        }

        public virtual string GetRetribuzione()
        {
            return "";
        }
    }

    
    class Operaio : Dipendente
    {
        public Operaio(int matricola, string nome, string cognome) : base(matricola, nome, cognome)
        {
            
        }
        public override string GetRetribuzione()
        {
            return "35 euro/h";
        }
    }

    class Dirigente : Dipendente
    {
        public Dirigente(int matricola, string nome, string cognome) : base(matricola, nome, cognome)
        {
  
        }
        public override string GetRetribuzione()
        {
            return "52.5 euro/h";
        }
    }

    class Impiegato : Dipendente
    {
        public Impiegato(int matricola, string nome, string cognome) : base(matricola, nome, cognome) 
        {

        }

        public override string GetRetribuzione()
        {
            return "45.5 euro/h";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Operaio operaio = new Operaio(1, "Mario", "Rossi");
            Impiegato impiegato = new Impiegato(2, "Alberto", "Bianchi");
            Dirigente dirigente = new Dirigente(3, "Giuseppe", "Verdi");
            Console.WriteLine(operaio.ToString() + ":\n" + operaio.GetRetribuzione());
            Console.WriteLine(impiegato.ToString() + ":\n" + impiegato.GetRetribuzione());
            Console.WriteLine(dirigente.ToString() + ":\n" + dirigente.GetRetribuzione());
            Console.ReadKey();
        }
    }
}
