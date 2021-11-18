using System;


namespace ClassDeriv
{
    class ClassDeriv
    {
        // Classe base.
        class Persona
        {
            public int Badge { get; set; }
            public string Cognome { get; set; }
            public string Nome { get; set; }

            public void StampaInformazioni()
            {
                Console.WriteLine("Badge: {0} Cognome: {1} Nome: {2} ", Badge.ToString(), Cognome, Nome);
            }
        }
        // Prima classe derivata.
        class Dipendente : Persona
        {
            public int Matricola { get; set; }
            public int Rettribuzione { get; set; }

        }

        // Seconda classe derivata.
        class Collaboratore : Persona
        {
            public string Azienda { get; set; }
        }
        static void Main(string[] args)
        {
            Persona p = new Persona()
            {
                Badge = 1,
                Cognome = "Da Vinci",
                Nome = "Leonardo"
            };
            Dipendente d = new Dipendente()
            {
                Badge = 2,
                Cognome = "Buonarroti",
                Nome = "Michelangelo",
                Matricola = 1,
                Rettribuzione = 100
            };
            Collaboratore c = new Collaboratore()
            {
                Badge = 3,
                Cognome = "Vecellio",
                Nome = "Tiziano",
                Azienda = "Abc"
            };
            p.StampaInformazioni();
            d.StampaInformazioni();
            c.StampaInformazioni();
        }
    }
}
