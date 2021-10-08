//Nickname: @Sandstorm
//Data: 07/10/2021
/*Consegna: Dopo aver acquisito da tastiera una serie di prezzi
 * relativi ai cellulari in vendita in un negozio, scrivere il 
 * codice di un programma(OOP) in C# che visualizzi i prezzi maggiori di 100€.*/
using System;
using System.Collections.Generic;

namespace programmazioneAdOggetti6
{
    //la classe Smartphone possiede il nome del modello e il prezzo dello smartphone
    //inoltre possiete il metodo ToString per ottenere una stringa contenente i dati
    //dello smartphone e il metodo CompareTo per compararlo a un altro smartphone.
    class Smartphone
    {
        string model;
        public double price { get; }

        //il costruttore riceve in ingresso modello e prezzo
        public Smartphone(string model, double price)
        {
            this.model = model;
            this.price = price;
        }

        //ritorna una stringa dove possiamo conoscere il nome e il prezzo dello smartphone
        public override string ToString()
        {
            return $"Modello: {model}, Prezzo: {price} euro.";
        }

        //riceve in ingresso un secondo smartphone e lo compara a questo smartphone in base al prezzo
        public int CompareTo(Smartphone smartphone2)
        {
            if(price > smartphone2.price)
            {
                return 1;
            } else if (price < smartphone2.price)
            {
                return -1;
            }
            return 0;
        }
    }

    class Program
    {
        /*nel main viene chiesto di inserire nome e prezzo degli smartphones,
        * e dopo averli inseriti in una lista essa viene convertita in array
        * e viene ordinato. In seguito vengono mostrati gli smartphone più
        * costosi di 100€*/
        static void Main(string[] args)
        {
            List<Smartphone> smartphonesList = new List<Smartphone>();
            
            string model;
            double price;
            string redo = "y";

            while (redo == "y")
            { 
                Console.Write("Inserisci il nome di uno smartphone: ");
                model = Console.ReadLine();
                Console.Write("\nInserisci il prezzo dello smartphone: ");
                price = double.Parse(Console.ReadLine());
                smartphonesList.Add(new Smartphone(model, price));
                Console.Write("\nVuoi continuare? Inserisci 'y' per continuare, inserisci altro per terminare l'inserimento: ");
                redo = Console.ReadLine();
                if (redo == "y")
                    Console.WriteLine();
            }

            Smartphone[] smartphonesArray = smartphonesList.ToArray();
            smartphonesArray = SortSmartphones(smartphonesArray);

            Console.WriteLine("\nSmartphones che costano più di 100 euro:");
            for(int i = FindIndex(smartphonesArray); i < smartphonesArray.Length; i++)
            {
                Console.WriteLine(smartphonesArray[i].ToString());
            }
        }

        //attraverso un insertion sort e il metodo public CompareTo della classe Smartphones viene riordinato l'array di Smartphones
        static Smartphone[] SortSmartphones(Smartphone[] inputArray)
        {
            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    int t = inputArray[j - 1].CompareTo(inputArray[j]);
                    if (t == 1)
                    {
                        Smartphone temp = inputArray[j - 1];
                        inputArray[j - 1] = inputArray[j];
                        inputArray[j] = temp;
                    }
                }
            }
            return inputArray;
        }

        //trova l'indice nell'array ordinato dove iniziano gli smartphone più costosi di 100€
        static int FindIndex(Smartphone[] smartphones)
        {
            bool indexFound = false;

            int index = 0;
            while(indexFound == false)
            {
                if(smartphones[index].price > 100)
                {
                    indexFound = true;
                } else
                {
                    index++;
                }
            }

            return index;
        }
    }
}
