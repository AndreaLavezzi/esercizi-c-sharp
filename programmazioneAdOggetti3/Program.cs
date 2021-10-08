//Nickname: @Sandstorm7
//Data: 30/09/2021
/*Consegna: Tramite la programmazione ad oggetti scrivere un programma in C# 
 * che dopo aver letto in input 3
 * età, di 3 persone diverse, calcoli e visualizzi in output la loro media.*/
using System;

namespace programmazioneAdOggetti3
{
    class Person //definizione della classe Persona
    {
        public int age { get; } //creo l'attributo "età" e lo imposto di sola lettura

        public Person(int age) //metodo costruttore
        {
            this.age = age;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //inserimento da tastiera delle età delle tre persone
            int age;
            Console.Write("Inserire l'età della prima persona: ");
            age = int.Parse(Console.ReadLine());
            Person a = new Person(age);

            Console.Write("Inserire l'età della seconda persona: ");
            age = int.Parse(Console.ReadLine());
            Person b = new Person(age);

            Console.Write("Inserire l'età della terza persona: ");
            age = int.Parse(Console.ReadLine());
            Person c = new Person(age);

            //comunico all'utente la media delle età, calcolata tramite la funzione MediaEtà
            Console.WriteLine("La media delle età è: {0}", AverageAge(a, b, c));
        }

        static float AverageAge(Person a, Person b, Person c) //prendo come parametri le tre persone
        {
            float media = (a.age + b.age + c.age) / 3; //leggo le età e ne faccio la media
            return media;
        }
    }
}
