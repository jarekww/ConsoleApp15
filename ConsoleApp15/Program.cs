using System;
using System.Collections.Generic;
using System.Linq;

namespace apka
{
    public class Pizza
    {
        public string Nazwa { get; set; }
        public double Cena { get; set; }
        public double CenaDodatkow { get; set; }

        public class NazwaPizza : Pizza
        {
            public override double CalculateCost()
            {
                return 20.00;
            }

            public override string GetName()
            {
                return "Pizza";
            }
        }

        public abstract class Pizza
        {
            public abstract double CalculateCost();

            public override bool Equals(object obj)
            {
                return base.Equals(obj);
            }

            public override int GetHashCode()
            {
                return base.GetHashCode();
            }

            public abstract string GetName();

            public override string ToString()
            {
                return base.ToString();
            }
        }

        public class PizzaDecorator : Pizza
        {

            protected Pizza _pizza;

            public PizzaDecorator(Pizza pizza)
            {
                _pizza = pizza;
            }
            public override double CalculateCost()
            {
                return _pizza.CalculateCost();
            }

            public override bool Equals(object obj)
            {
                return obj is PizzaDecorator decorator &&
                       EqualityComparer<Pizza>.Default.Equals(_pizza, decorator._pizza);
            }

            public override string GetName()
            {
                return _pizza.GetName();
            }

            public class SerDecorator : PizzaDecorator
            {
                public SerDecorator(Pizza pizza)
                    : base(pizza)
                {

                }

                public override double CalculateCost()
                {
                    return base.CalculateCost() + 2.50;
                }

                public override string GetName()
                {
                    return base.GetName() + " Ser";
                }
            }
            public class SzynkaDecorator : PizzaDecorator
            {
                public SzynkaDecorator(Pizza pizza)
                    : base(pizza)
                {

                }

                public override double CalculateCost()
                {
                    return base.CalculateCost() + 2.50;
                }

                public override string GetName()
                {
                    return base.GetName() + " Szynka";
                }
            }
            public class OliwkiDecorator : PizzaDecorator
            {
                public OliwkiDecorator(Pizza pizza)
                    : base(pizza)
                {

                }

                public override double CalculateCost()
                {
                    return base.CalculateCost() + 2.50;
                }

                public override string GetName()
                {
                    return base.GetName() + " Oliwki";
                }
            }

            public class OwoceMorzaDecorator : PizzaDecorator
            {
                public OwoceMorzaDecorator(Pizza pizza)
                    : base(pizza)
                {

                }

                public override double CalculateCost()
                {
                    return base.CalculateCost() + 2.50;
                }

                public override string GetName()
                {
                    return base.GetName() + " Owoce Morza";
                }
            }

            public class KurczakDecorator : PizzaDecorator
            {
                public KurczakDecorator(Pizza pizza)
                    : base(pizza)
                {

                }

                public override double CalculateCost()
                {
                    return base.CalculateCost() + 2.50;
                }

                public override string GetName()
                {
                    return base.GetName() + " Kurczak";
                }
            }
            public class PieczarkiDecorator : PizzaDecorator
            {
                public PieczarkiDecorator(Pizza pizza)
                    : base(pizza)
                {

                }

                public override double CalculateCost()
                {
                    return base.CalculateCost() + 2.50;
                }

                public override string GetName()
                {
                    return base.GetName() + " Pieczarki";
                }
            }

            public class AnanasDecorator : PizzaDecorator
            {
                public AnanasDecorator(Pizza pizza)
                    : base(pizza)
                {

                }

                public override double CalculateCost()
                {
                    return base.CalculateCost() + 2.50;
                }

                public override string GetName()
                {
                    return base.GetName() + " Ananas";
                }
            }

        }

        public void NazwaPizzy()
        {
            Console.WriteLine("Pizza ");
        }


        public double FinalPrice()
        {
            return Cena;
        }
        public double Price()
        {
            return CenaDodatkow;
        }



    }

    static void Main(string[] args)
    {
        string[] Dodatki = new string[] { "ser", "szynka", "pieczarki",
        "owoce morza", "oliwki", "ananas", "kurczak" };


        // Gdzieś trzeba stworzyć obiekt Pizza. Nie wiem w któym miejscu i jakie metody do niej użyć
        // Tak jakby w naszej aplikacji niepotrzebna jest klasa hmm... 
        // Podziałaj coś z tym kodem może na coś wpadniesz
        Console.WriteLine("Witamy w Pizzeri XYZ :D Ile pizz chciałbyś zamówić");
        int n = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i <= n; i++)
        {
            Console.WriteLine("Ile dodatków do {0} pizzy", n);
            int l = Convert.ToInt32(Console.ReadLine());
            // tu tworze petle do wyliczania dodatkow ale doszedłem do wniosku że można wypisać je 
            // na ekranie, policzyć i pomnożyć ilość słów przez cene dodatku
            // na razie pętla została jakbyśmy woleli po kolei dodawać dodatki
            for (int k = 0; k <= l; k++)
            {
                Console.WriteLine("Jakie dodatki chcesz do pizzy (rozdzielone przecinkiem");
                // Console.WriteLine(Dodatki);
                string dodatki = Console.ReadLine();
                string searchTerm = dodatki;

                //Convert the string into an array of words  
                string[] source = dodatki.Split(new char[] { '.', '?', '!', ' ', ';', ':', ',' }, StringSplitOptions.RemoveEmptyEntries);

                // Create the query.  Use the InvariantCultureIgnoreCase comparision to match "data" and "Data"
                var matchQuery = from word in source
                                 where word.Equals(searchTerm, StringComparison.InvariantCultureIgnoreCase)
                                 select word;

                // Count the matches, which executes the query.  
                int wordCount = matchQuery.Count();

                var Ilosc = dodatki.Count();
                double CenaKoncowa = 10 + (2.5 * Ilosc);

            }


        }


        Console.ReadKey();
    }
}