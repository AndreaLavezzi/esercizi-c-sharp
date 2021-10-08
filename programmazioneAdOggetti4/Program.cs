//Nickname: @Sandstorm7
//Data: 01/10/2021
/*Consegna: Tramite la programmazione ad oggetti scrivere un programma in C# che dopo aver letto in input il
* raggio di una circonferenza, calcoli e visualizzi in output la misura del diametro (2*r), della
* circonferenza (2*r*pi) e la sua area (r 2 *pi). (Utilizzare la funzione Math.PI).*/
using System;

namespace programmazioneAdOggetti4
{
    class Circumference //creo la classe Circonferenza
    {
        double radius, diameter, circumference, area;
        public Circumference(double radius) //tramite il costruttore acquisisco il raggio e calcolo gli altri attributi
        {
            this.radius = radius;
            diameter = radius * 2;
            circumference = 2 * radius * Math.PI;
            area = radius * radius * Math.PI;
        }

        public override string ToString() //mostro a schermo le misure della figura
        {
            return $"Raggio: {radius}, Diametro: {diameter}, Circonferenza: {circumference}, Area: {area}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            double radius;
            string redo = "y"; //stringa che permette all'utente di creare varie circonferenze senza dover chiudere e riaprire il programma

            while(redo == "y")
            {
                Console.Write("Inserire la misura del raggio:\nRisposta: "); //chiedo la misura del raggio
                radius = Double.Parse(Console.ReadLine()); //ottengo la misura del raggio da tastiera
                while(radius < 0)
                {
                    Console.Write("\nUna misura non può essere minore di 0. Reinserire la misura del raggio: ");
                    radius = Double.Parse(Console.ReadLine());
                }

                Circumference c = new Circumference(radius); //creo un'istanza della classe Circonferenza passandole il raggio

                Console.WriteLine(c.ToString()); //mostro a schermo le misure

                //chiedo all'utente se vuole continuare
                Console.WriteLine("\nVuoi creare una nuova circonferenza? [Scrivere 'y' per continuare, altro per terminare il programma.]\n");
                redo = Console.ReadLine();
            }
        }
    }
}
