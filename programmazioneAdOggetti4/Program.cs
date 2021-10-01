//Autore: Lavezzi Andrea
//Data: 01/10/2021
/*Consegna: Tramite la programmazione ad oggetti scrivere un programma in C# che dopo aver letto in input il
raggio di una circonferenza, calcoli e visualizzi in output la misura del diametro (2*r), della
circonferenza (2*r*pi) e la sua area (r 2 *pi). (Utilizzare la funzione Math.PI).*/
using System;

namespace programmazioneAdOggetti4
{
    class Circonferenza //creo la classe Circonferenza
    {
        double raggio, diametro, circonferenza, area;
        public Circonferenza(double raggio) //tramite il costruttore acquisisco il raggio e calcolo gli altri attributi
        {
            this.raggio = raggio;
            this.diametro = raggio * 2;
            this.circonferenza = 2 * raggio * Math.PI;
            this.area = raggio * raggio * Math.PI;
        }

        public void MostraMisure() //mostro a schermo le misure della figura
        {
            Console.WriteLine("\nQueste sono le misure della figura: Raggio: {0}, Diametro: {1}, Circonferenza: {2}, Area: {3}", raggio, diametro, circonferenza, area);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            double raggio;
            string ricreare = "y"; //stringa che permette all'utente di creare varie circonferenze senza dover chiudere e riaprire il programma
            while(ricreare == "y")
            {
                Console.Write("Inserire la misura del raggio:\nRisposta: "); //chiedo la misura del raggio
                raggio = Double.Parse(Console.ReadLine()); //ottengo la misura del raggio da tastiera
                while(raggio < 0)
                {
                    Console.Write("\nUna misura non può essere minore di 0. Reinserire la misura del raggio: ");
                    raggio = Double.Parse(Console.ReadLine());
                }
                Circonferenza c = new Circonferenza(raggio); //creo un'istanza della classe Circonferenza passandole il raggio
                c.MostraMisure(); //mostro a schermo le misure
                //chiedo all'utente se vuole continuare
                Console.WriteLine("\nVuoi creare una nuova circonferenza? [Scrivere 'y' per continuare, altro per terminare il programma.]\n");
                ricreare = Console.ReadLine();
            }
        }
    }
}
