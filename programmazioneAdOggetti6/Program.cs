using System;
using System.Collections.Generic;

namespace programmazioneAdOggetti6
{
    class Smartphone
    {
        string nome;
        public double prezzo { get; }
        public Smartphone(string nome, double prezzo)
        {
            this.nome = nome;
            this.prezzo = prezzo;
        }

        public int CompareTo(Smartphone smartphone2)
        {
            if(this.prezzo > smartphone2.prezzo)
            {
                return 1;
            } else
            {
                return 0;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Smartphone> smartphonesList = new List<Smartphone>();
            
            string nome;
            double prezzo;
            string redo = "y";

            while (redo == "y")
            { 
                Console.WriteLine("Inserisci il nome di uno smartphone");
                nome = Console.ReadLine();
                Console.WriteLine("Inserisci il prezzo dello smartphone");
                prezzo = double.Parse(Console.ReadLine());
                smartphonesList.Add(new Smartphone(nome, prezzo));
                Console.WriteLine("Vuoi continuare? Inserisci 'y' per continuare, inserisci altro per terminare l'inserimento.");
                redo = Console.ReadLine();
            }
            Smartphone[] smartphonesArray = new Smartphone[0];
            smartphonesArray = SortSmartphones(smartphonesList.ToArray());

        }

        static Smartphone[] SortSmartphones(Smartphone[] smartphones)
        {
            Smartphone temp;
            for (int j = 0; j < (smartphones.Length - 1); j++)
            {
                for (int i = 0; i < (smartphones.Length - 1); i++)
                {
                    if (smartphones[i].CompareTo(smartphones[2]) == 1)
                    {
                        temp = smartphones[i];
                        smartphones[i] = smartphones[i + 1];
                        smartphones[i + 1] = temp;
                    }
                }
            }
            return smartphones;
        }

        static int FindIndex(Smartphone[] smartphones)
        {
            bool indexFound = false;
            int index = 0;
            while(indexFound == false)
            {
                if(smartphones[index].prezzo > 100)
                {
                    indexFound = true;
                } else
                {
                    index++;
                }

                return index;
            }
        }
    }
}
