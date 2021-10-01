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

        public void AggiungiTemperatura() //aggiungo temperature all'array in base a quante ne vuole l'utente, affinchè egli risponda con "y"
        {
            string redo = "y";
            while(redo == "y")
            {
                Console.Write("\nInserire la temperatura registrata: ");
                Array.Resize(ref temperature, temperature.Length + 1);
                temperature[temperature.Length - 1] = double.Parse(Console.ReadLine());
                Console.Write("\nVuoi inserire una nuova temperatura? Inserire 'y' per continuare, altro per terminare l'inserimento.\n");
                redo = Console.ReadLine();
            }
        }

        public void VisualizzaTemperature() //comunico il nome della città e il valore delle temperature
        {
            Array.Sort(temperature);
            Console.WriteLine("TEMPERATURE DI {0} \nTemperatura Massima: {1}, \nTemperatura Minima: {2}", nome.ToUpper(), temperature[temperature.Length - 1], temperature[0]);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Inserire il nome della città: "); //chiedo il nome della città
            string nome = Console.ReadLine();
            Città città = new Città(nome); //creo un'istanza della classe città col nome inserito dall'utente
            città.AggiungiTemperatura(); //aggiungo le temperature
            città.VisualizzaTemperature(); //visualizzo il nome della città e la temperatura massima e minima
        }
    }
}
