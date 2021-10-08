//Nickname: @Sandstorm
//Data: 01/20/2021
/*Consegna: Dopo aver acquisito da tastiera una serie di dati relativi alla misurazione della temperatura di una
* certa città, scrivere il codice di un programma(OOP) in C# che determini e visualizzi la temperatura
* più bassa e quella più alta. */
using System;

namespace programmazioneAdOggetti5
{
    //la classe 
    class City
    {
        string name;
        double[] temperatures = new double[0]; //creo un array vuoto
        public City(string name) //tramite il costruttore chiedo il nome della città
        {
            this.name = name;
        }

        public void AddTemperature(double temperature) //aggiungo temperature all'array
        {
            Array.Resize(ref temperatures, temperatures.Length + 1);
            temperatures[temperatures.Length - 1] = temperature;
            Array.Sort(temperatures);
        }

        public override string ToString() //comunico il nome della città e il valore delle temperature
        {
            return $"TEMPERATURE DI {name.ToUpper()} \nTemperatura Massima: {temperatures[temperatures.Length - 1]}, \nTemperatura Minima: {temperatures[0]}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string redo = "y";

            Console.Write("Inserire il nome della città: "); //chiedo il nome della città
            name = Console.ReadLine();

            City city = new City(name); //creo un'istanza della classe città col nome inserito dall'utente

            while (redo == "y")
            {
                Console.Write("\nInserire la temperatura registrata: ");
                city.AddTemperature(Double.Parse(Console.ReadLine()));
                Console.Write("\nVuoi inserire una nuova temperatura? Inserire 'y' per continuare, altro per terminare l'inserimento.\n");
                redo = Console.ReadLine();
            }

            Console.WriteLine(city.ToString()); //visualizzo il nome della città e la temperatura massima e minima
        }
    }
}
