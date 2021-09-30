/*Tramite la programmazione ad oggetti scrivere il codice di un programma
 *che dopo aver costruito la classe Calciatore visualizzi in output: il 
 *nome del calciatore, il ruolo, la squadra ed i gol segnati (i dati vengono
 *assegnati all'interno del codice).*/

using System; /*istruzione per l'utilizzo della libreria system che permette di usare
               * la classe console, che contiene i metodi Write, ReadLine e altri*/

namespace programmazioneAdOggetti1
{
    class Calciatore //definizione della classe (pag. 20)
    {
        //attributi
        string nome, squadra, ruolo;
        int golSegnati;

        //metodo di default: costruttore
        public Calciatore(string nome, string squadra, string ruolo)
        {
            this.nome = nome;
            this.squadra = squadra;
            this.ruolo = ruolo;
            golSegnati = 0;
        }

        //metodi
        public void aggiornaGolSegnati(int gol)
        {
            golSegnati += gol;
        }

        public void visualizzaGol()
        {
            Console.WriteLine("{0} - {1} - {2} - gol segnati: {3}", nome, squadra, ruolo, golSegnati);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string nome, ruolo, squadra;
            Console.Write("Inserire il nome del giocatore:\nRisposta: ");
            nome = Console.ReadLine();
            Console.Write("\nInserire la squadra del giocatore:\nRisposta: ");
            squadra = Console.ReadLine();
            Console.Write("\nInserire il ruolo del giocatore:\nRisposta: ");
            ruolo = Console.ReadLine();
            Calciatore c = new Calciatore(nome, squadra, ruolo);
            Console.WriteLine("\nIl tuo calciatore:");
            c.visualizzaGol();

        }
    }
}
