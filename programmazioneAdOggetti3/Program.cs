//Autore: Andrea Lavezzi
//Data: 30/09/2021
/*Consegna: Tramite la programmazione ad oggetti scrivere un programma in C# 
 * che dopo aver letto in input 3
 * età, di 3 persone diverse, calcoli e visualizzi in output la loro media.*/
using System;

namespace programmazioneAdOggetti3
{
    class Persona //definizione della classe Persona
    {
        public int età { get; } //creo l'attributo "età" e lo imposto di sola lettura

        public Persona(int età) //metodo costruttore
        {
            this.età = età;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //inserimento da tastiera delle età delle tre persone
            int età;
            Console.Write("Inserire l'età della prima persona: ");
            età = int.Parse(Console.ReadLine());
            Persona a = new Persona(età);

            Console.Write("Inserire l'età della seconda persona: ");
            età = int.Parse(Console.ReadLine());
            Persona b = new Persona(età);

            Console.Write("Inserire l'età della terza persona: ");
            età = int.Parse(Console.ReadLine());
            Persona c = new Persona(età);

            //comunico all'utente la media delle età, calcolata tramite la funzione MediaEtà
            Console.WriteLine("La media delle età è: {0}", MediaEtà(a, b, c));
        }

        static float MediaEtà(Persona a, Persona b, Persona c) //prendo come parametri le tre persone
        {
            float media = (a.età + b.età + c.età) / 3; //leggo le età e ne faccio la media
            return media;
        }
    }
}
