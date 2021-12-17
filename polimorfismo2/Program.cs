using System;

namespace polimorfismo2
{
    class Veicolo
    {
        int codVeicolo;
        string nome, marca;
        protected Veicolo(int codVeicolo, string nome, string marca)
        {
            this.codVeicolo = codVeicolo;
            this.nome = nome;
            this.marca = marca;
        }
        public virtual float CalcolaCosto()
        {
            return 5000;
        }
        public virtual float CalcolaCosto(float km)
        {
            return km;
        }
        public override string ToString()
        {
            return $"{marca} {nome}, Codice: {codVeicolo}, Costo: {CalcolaCosto()}";
        }
    }
    class Auto : Veicolo
    {
        public Auto(int codVeicolo, string nome, string marca) : base(codVeicolo, nome, marca) { }
        public override float CalcolaCosto()
        {
            return base.CalcolaCosto() * 1.25f;
        }
        public override float CalcolaCosto(float km)
        {
            return km * 5;
        }
    }
    class Furgone : Veicolo
    {
        public Furgone(int codVeicolo, string nome, string marca) : base(codVeicolo, nome, marca) { }
        public override float CalcolaCosto()
        {
            return base.CalcolaCosto() * 1.40f;
        }
        public override float CalcolaCosto(float km)
        {
            return km * 10;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Auto auto = new Auto(1, "Fiesta", "Ford");
            Furgone furgone = new Furgone(2, "Dokker", "Dacia");
            Console.WriteLine($"Primo veicolo: \n{auto.ToString()}");
            Console.WriteLine("Inserire numero Km percorsi");
            float kmPercorsi = float.Parse(Console.ReadLine());
            Console.WriteLine($"Costo utilizzo: {auto.CalcolaCosto(kmPercorsi)}");

            Console.WriteLine($"Secondo veicolo: \n{furgone.ToString()}");
            Console.WriteLine("Inserire numero Km percorsi");
            kmPercorsi = float.Parse(Console.ReadLine());
            Console.WriteLine($"Costo utilizzo: {furgone.CalcolaCosto(kmPercorsi)}");
        }
    }
}
