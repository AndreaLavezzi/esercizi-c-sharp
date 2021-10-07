//Autore: Lavezzi Andrea
//Data: 01/20/2021
/*Consegna: Dopo aver acquisito da tastiera una serie di dati relativi alla misurazione della temperatura di una
certa città, scrivere il codice di un programma(OOP) in C# che determini e visualizzi la temperatura
più bassa e quella più alta. */
using System;

namespace programmazioneAdOggetti5
{
    class Città
    {
        string nome;
        double[] temperature = new double[0]; //creo un array vuoto
        public Città(string nome) //tramite il costruttore chiedo il nome della città
        {
            this.nome = nome;
        }

        public void AggiungiTemperatura(double temperatura) //aggiungo temperature all'array
        {
            Array.Resize(ref temperature, temperature.Length + 1);
            temperature[temperature.Length - 1] = temperatura;
            Array.Sort(temperature);
        }

        public string ToString() //comunico il nome della città e il valore delle temperature
        {
            return $"TEMPERATURE DI {nome.ToUpper()} \nTemperatura Massima: {temperature[temperature.Length - 1]}, \nTemperatura Minima: {temperature[0]}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Inserire il nome della città: "); //chiedo il nome della città
            string nome = Console.ReadLine();
            Città città = new Città(nome); //creo un'istanza della classe città col nome inserito dall'utente

            string redo = "y";
            while (redo == "y")
            {
                Console.Write("\nInserire la temperatura registrata: ");
                città.AggiungiTemperatura(Double.Parse(Console.ReadLine()));
                Console.Write("\nVuoi inserire una nuova temperatura? Inserire 'y' per continuare, altro per terminare l'inserimento.\n");
                redo = Console.ReadLine();
            }

            Console.WriteLine(città.ToString()); //visualizzo il nome della città e la temperatura massima e minima
        }
    }
}
