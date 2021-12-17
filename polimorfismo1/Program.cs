using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polimorfismo1
{
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

        public virtual string Retribuzione()
        {
            return "";
        }
    }

    class Operaio : Dipendente
    {
        string retribuzione;
        public Operaio(int matricola, string nome, string cognome) : base(matricola, nome, cognome)
        {
            this.retribuzione = "35 euro/h";
        }
        public override string Retribuzione()
        {
            return retribuzione;
        }
    }

    class Dirigente : Dipendente
    {
        string retribuzione;
        public Dirigente(int matricola, string nome, string cognome) : base(matricola, nome, cognome)
        {
            this.retribuzione = "52.5 euro/h";
        }
        public override string Retribuzione()
        {
            return retribuzione;
        }
    }

    class Impiegato : Dipendente
    {
        string retribuzione;
        public Impiegato(int matricola, string nome, string cognome) : base(matricola, nome, cognome) 
        {
            this.retribuzione = "45.5 euro/h"; 
        }

        public override string Retribuzione()
        {
            return retribuzione;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Operaio operaio = new Operaio(1, "Mario", "Rossi");
            Impiegato impiegato = new Impiegato(2, "Alberto", "Bianchi");
            Dirigente dirigente = new Dirigente(3, "Giuseppe", "Verdi");
            Console.WriteLine(operaio.ToString() + ":\n" + operaio.Retribuzione());
            Console.WriteLine(impiegato.ToString() + ":\n" + impiegato.Retribuzione());
            Console.WriteLine(dirigente.ToString() + ":\n" + dirigente.Retribuzione());
            Console.ReadKey();
        }
    }
}
